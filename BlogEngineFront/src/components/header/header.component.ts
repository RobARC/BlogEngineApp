import { Component, Input } from '@angular/core';
import { Router } from '@angular/router';
import { LoginService } from 'src/services/login.services';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css'],
  providers: [LoginService]
  
})
export class HeaderComponent {
  loginService!: LoginService;
  logoutButton: boolean = false;
  loginButton: boolean = true;
  

  constructor(
    private router : Router, 
    loginService: LoginService) 
    { }

    logout() {
      this.loginService.logout();
      this.router.navigate(['/']);
      this.loginButton = true;
    }

    loggedIn() {
     return this.loginService.isLoggedIn();
     this.logoutButton = false;
    }
}
