import { Injectable, Inject } from "@angular/core";
import { HttpClient, HttpHeaders, HttpErrorResponse } from "@angular/common/http";
import { CookieService } from "ngx-cookie-service";
import { url_api } from "src/app/app-constants";
import { Observable, throwError } from "rxjs";
import { LoginInterface } from "src/components/login/login.class";
import { Router } from "@angular/router";
import { catchError } from "rxjs/operators";


const httpOptions = {
  headers: new HttpHeaders({ 'Content-Type': 'application/json'})
};

@Injectable({
    providedIn: 'root'
  })
  export class LoginService {
    router!: Router

    constructor(private http: HttpClient, 
                  private cookies: CookieService,
                  
                ) {}

  async LoginUsers(loginInterface: LoginInterface): Promise<Observable<any>>{

    console.log(loginInterface);

    return await this.http.post<any>(`${url_api}/api/Account/Login`, loginInterface, httpOptions)
                      .pipe(catchError(this.ErrorHandler))
    }

    GetToken(){
      return localStorage.getItem('token');
    }

    GetExpirationToken() {
      return localStorage.getItem('expiration_token');
    }

    isLoggedIn(): boolean {
      var exp = this.GetToken();
      if(!exp) {
        //there is no expiration token
        console.log(exp);
        
        return false;
      }

      var now = new Date().getTime();
      var dateExp = new Date(exp);

      if(now >= dateExp.getTime()) {
        //token is expired
        localStorage.removeItem('token');
        localStorage.removeItem('epiration_token');
        return false;
      } else {
        return true;
      }
    }

    ErrorHandler(error: HttpErrorResponse) {
      //console.log(error.message);
      alert("Email or password is incorrect, please try again.");
      return error.message;
  }
}