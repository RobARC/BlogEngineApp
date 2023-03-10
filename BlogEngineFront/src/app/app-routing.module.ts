import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { RegisterComponent } from '../components/register/register.component';

const routes: Routes = [];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule {

  appRoutes: Routes = [{
    path: '',
    component: RegisterComponent,
    pathMatch: 'full',
  }];

routing  = RouterModule.forRoot(this.appRoutes)

}