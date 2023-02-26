import { Component, Input, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { LoginService } from 'src/services/login.services';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css'],
  providers: [LoginService]
  
})
export class HeaderComponent implements OnInit{
  loginService!: LoginService;
  logoutButton: boolean = false;
  option: any = 0;

  constructor(
    private router : Router, 
    loginService: LoginService) 
    { }
  ngOnInit(): void {
  }

    logout() {
      console.log('hola');
      console.log(localStorage);
      localStorage.removeItem('expiration_token');
      localStorage.removeItem('token');
      this.router.navigate(['login']);
      this.option=0;
    }

    loggedIn() {

     const resp2 = this.loginService.isLoggedIn();
     console.log(resp2);
     
      if (resp2 === true) {
        this.option = 1;
      } else {
        this.option = 0
        alert("Login Successful!");
    }
  }
}
