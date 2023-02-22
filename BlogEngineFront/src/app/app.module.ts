import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { RegisterComponent } from '../components/register/register.component';
import { HeaderComponent } from '../components/header/header.component';
import { FooterComponent } from '../components/footer/footer.component';
import { RouterModule, Routes, CanActivate } from '@angular/router';
import { LoginComponent } from '../components/login/login.component';
import { RegisterService } from 'src/services/register.service';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { PostComponent } from '../components/post/post.component';
import { HomeComponent } from '../components/home/home.component';
import { PageNotFoundComponent } from '../components/page-not-found/page-not-found.component';
import { CookieService } from 'ngx-cookie-service';
import { LoginService } from '../services/login.services';
import { RolesComponent } from '../components/roles/roles.component';
import { BoardEditorComponent } from 'src/components/board-editor/board-editor.component';
import { BoardPublicComponent } from 'src/components/board-public/board-public.component';
import { BoardWriterComponent } from 'src/components/board-writer/board-writer.component';
import { StorageService } from 'src/services/storage.service';
import { HomeService } from 'src/services/home.service';
import { AuthGuardService } from '../services/auth-guard.service';
import { PostService } from '../services/post.service';
import { AuthInterceptorService } from 'src/services/auth-interceptor.service';
import { ComentsComponent } from '../components/coments/coments.component';
import { ComentsService } from 'src/services/coments.service';

@NgModule({
  declarations: [
    AppComponent,
    RegisterComponent,
    HeaderComponent,
    FooterComponent,
    LoginComponent,
    PostComponent,
    HomeComponent,
    PageNotFoundComponent,
    RolesComponent,
    BoardEditorComponent,
    BoardPublicComponent,
    BoardWriterComponent,
    ComentsComponent,
   
    
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    ReactiveFormsModule,
    HttpClientModule,
    RouterModule.forRoot([
      {path: 'register', component: RegisterComponent},
      {path: 'login', component: LoginComponent},
      {path: 'home/post-add', component: PostComponent},
      {path: 'home/post-edit/:id', component: PostComponent},
      {path: 'home', component: HomeComponent}, //, canActivate: [AuthGuardService]},
      {path: '',   redirectTo: 'home', pathMatch: 'full'},
      {path: '**', component:     PageNotFoundComponent}
      
    
    ]),
  ],
  providers: [RegisterService, CookieService, LoginService, 
              StorageService, HomeService, AuthGuardService, PostService,
              AuthInterceptorService, ComentsService,
              {
                provide: HTTP_INTERCEPTORS,
                useClass: AuthInterceptorService,
                multi: true
              }
              ],
  bootstrap: [AppComponent]
})
export class AppModule { }
