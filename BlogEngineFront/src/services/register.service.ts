import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { UserInterface } from 'src/components/register/register.class';
import { url_api } from 'src/app/app-constants';


@Injectable({
  providedIn: 'root'
})
export class RegisterService {

  constructor (private http: HttpClient) { }

  //async getUsers(){
  //  return await this.http.get(`${url_api}/api/Users`).subscribe(data => {
  //  });
  //}

  async PostUsers(data: UserInterface) {
    return await this.http.post(`${url_api}/api/Account/Create`, data).subscribe();
}


}
