import { Component, OnInit } from '@angular/core';
import { FormGroup,  FormBuilder } from '@angular/forms';
import { User } from 'src/models/User.model';
import { RegisterService } from 'src/services/register.service';
import { Role } from '../../models/role.model';
import { Router } from '@angular/router';


@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css'],
  providers: [RegisterService],
})

export class RegisterComponent implements OnInit  {

  checkoutForm: any;
  user: User = new User();
  router: any;

  constructor (
    private fb: FormBuilder,
    private registerService: RegisterService,
  ) { 
      this.checkoutForm = fb.group({
          userName: "",
          role: "",
          email: "",
          password: "",
          idRole: 0,
          });
    }
    
  ngOnInit(): void { };

  public registerForm: FormGroup = new FormGroup({});
  public event: { preventDefault: () => void; } | undefined;
  
  Roles = [ "Public", "Writer", "Editor" ];
  IdRoles = [ 1, 2 , 3]

  onSubmit() {
    // Process fillout data here
    this.user.UserName = this.checkoutForm.value.userName;
    this.user.Role = this.checkoutForm.value.role;
    this.user.Email = this.checkoutForm.value.email;
    this.user.Password = this.checkoutForm.value.password;
    this.user.IdRole = this.checkoutForm.value.idRole;
  
    const data = this.checkoutForm.value;

    //prueba enviando data
    console.table(data);

    try {
      this.registerService.PostUsers(data);

       alert("Registration Successful");
     
      //this.registerService.getUsers();

    } catch (error) {
      console.log(error);
      alert("Registration Failed");
    }
    this.checkoutForm.reset();
    
  }
}

