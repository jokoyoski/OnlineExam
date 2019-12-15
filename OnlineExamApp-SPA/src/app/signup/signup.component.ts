import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators, FormControl } from '@angular/forms';
import { routerTransition } from '../router.animations';
import { AuthService } from '../services/Auth.service';
import { AlertifyService } from '../services/AlertifyService';
import { Router } from '@angular/router';
import { LoaderService } from '../layout/services/loader.service';

@Component({
    selector: 'app-signup',
    templateUrl: './signup.component.html',
    styleUrls: ['./signup.component.scss'],
    animations: [routerTransition()]
})
export class SignupComponent implements OnInit {
    registerForm: FormGroup;
    loader = false;
    constructor(private authService: AuthService, private alertifyService:
      AlertifyService, private router: Router) {
        this.loader = true;
      }
  model: any = {};
    ngOnInit() {

        this.registerForm = new FormGroup({   // we created a new instance here

          firstName: new FormControl('', Validators.required),
          lastName: new FormControl('', Validators.required),
          email: new FormControl('', Validators.required),
          password: new FormControl('', [Validators.required, Validators.minLength(4), Validators.maxLength(8)]),
          confirmPassword: new FormControl('', Validators.required),
          dateOfBirth: new FormControl('', Validators.required)



        }, this.passwordMatchValidator);

      }
      passwordMatchValidator(g: FormGroup) {  // if password are equal

       return g.get('password').value === g.get('confirmPassword').value ? null : {mismatch: true};
     }

     register() {

      if (this.registerForm.valid) {
       this.model = Object.assign({}, this.registerForm.value);

      }

      this.authService.register(this.model).subscribe((response: any) => {

      this.alertifyService.success(response.success);

     }, (error) => {

       this.alertifyService.error(error);
     }, () => {
       this.model.userName = this.model.email;

     this.authService.login(this.model).subscribe((response: any) => {

       this.router.navigate(['']);   // redirect users to the memeber page when they login
     });
     } );
     }

    }
