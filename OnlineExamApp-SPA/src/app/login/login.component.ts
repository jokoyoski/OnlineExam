import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { routerTransition } from '../router.animations';
import { AuthService } from '../services/Auth.service';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { AlertifyService } from '../services/AlertifyService';

@Component({
    selector: 'app-login',
    templateUrl: './login.component.html',
    styleUrls: ['./login.component.scss'],
    animations: [routerTransition()]
})
export class LoginComponent implements OnInit {
    loginForm: FormGroup;
    model: any = {};
    constructor(public authService: AuthService,
        private alertifyService: AlertifyService, private router: Router) { }

    ngOnInit() {
        this.loginForm = new FormGroup({   // we created a new instance here

            username: new FormControl('', Validators.required),
            password: new FormControl('', Validators.required),




          });
    }

    login() {
        if (this.loginForm.valid) {
            this.model = Object.assign({}, this.loginForm.value);

           }
          
        this.authService.login(this.model).subscribe(value => value,


         (error) => {
           this.alertifyService.error(error);
        }, () => {
          this.router.navigate(['']);
        });
      }


    onLoggedin() {
        localStorage.setItem('isLoggedin', 'true');
    }

}
