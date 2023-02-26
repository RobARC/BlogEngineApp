import { Injectable } from '@angular/core';
import { ActivatedRouteSnapshot, CanActivate, Router, RouterStateSnapshot, UrlTree } from '@angular/router';
import { Observable } from 'rxjs';
import { RegisterService } from './register.service';
import { LoginService } from './login.services';

@Injectable({
  providedIn: 'root'
})
export class AuthGuardService implements CanActivate{

  constructor( 
    private registerService: RegisterService,
    private loginService: LoginService,
    private router: Router
  ) { }

  canActivate(): boolean | Observable<boolean> {
      if( !this.loginService.isLoggedIn()){
        this.router.navigate(['login']);
        return false;
      } else {
        this.router.navigate(['home']);
        return true;
      }
  }
}
