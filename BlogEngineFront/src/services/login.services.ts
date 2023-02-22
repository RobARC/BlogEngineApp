import { Injectable, Inject } from "@angular/core";
import { HttpClient, HttpHeaders } from "@angular/common/http";
import { CookieService } from "ngx-cookie-service";
import { url_api } from "src/app/app-constants";
import { Observable, BehaviorSubject } from "rxjs";
import { LoginInterface } from "src/components/login/login.class";
import { Router } from "@angular/router";
import { User } from "src/models/User.model";

const httpOptions = {
  headers: new HttpHeaders({ 'Content-Type': 'application/json'})
};

@Injectable({
    providedIn: 'root'
  })
  export class LoginService {

    constructor(private http: HttpClient, 
                  private cookies: CookieService,
                  private router: Router
                ) {}

  async LoginUsers(loginInterface: LoginInterface): Promise<Observable<any>>{

    console.log(loginInterface);

    return await this.http.post<any>(`${url_api}/api/Account/Login`, loginInterface, httpOptions)
    }

    GetToken(){
      return localStorage.getItem('token');
    }

    GetExpirationToken() {
      return localStorage.getItem('expiration_token');
    }

    async logout() {
      localStorage.removeItem('expiration_token');
      localStorage.removeItem('token');
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
  }
 