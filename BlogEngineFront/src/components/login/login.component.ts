import { Component , OnInit } from '@angular/core';
import { FormBuilder } from '@angular/forms';
import { User } from 'src/models/User.model';
import { LoginService } from 'src/services/login.services';
import { Router } from '@angular/router';
import { LoginInterface } from './login.class';
import { Login } from '../../models/login.model';
@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css'],
  providers: [LoginService],
})
export class LoginComponent implements OnInit  {
  checkLoginForm: any;
  user: User = new User();
  listUsers: Array<User> = [];
  routeHome: string = '';
  login : Login = new Login();
  tokenExpiration: string = '';
  email!: string;
  password!: string;

  constructor (
    private fb: FormBuilder,
    private loginService: LoginService,
    private router: Router
  ) { }

  ngOnInit(): void { 
    this.checkLoginForm = this.fb.group({
      email: "",
      password: "",
   });
  };

  async onSubmit() {

    let loginInterface: LoginInterface = Object.assign({}, this.checkLoginForm.value);

    (await this.loginService.LoginUsers(loginInterface)).subscribe(token => this.getToken(token))
      this.checkLoginForm.reset()
    }

    getToken(token: { token: string; }) {
      
      localStorage.setItem('token', token.token);
      localStorage.setItem('tokenExpiration', this.tokenExpiration);
      if(token.token === undefined ){
        console.log(token.token);
        this.router.navigate(['login']);
      } else {
        this.router.navigate(['home']);
        alert("Login Successful");
      }

     
    }
  }

  
 






