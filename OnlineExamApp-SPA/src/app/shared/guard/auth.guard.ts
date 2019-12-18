import { Injectable } from '@angular/core';
import { CanActivate } from '@angular/router';
import { Router } from '@angular/router';
import { AuthService } from 'src/app/services/Auth.service';
import { AlertifyService } from 'src/app/services/AlertifyService';

@Injectable()
export class AuthGuard implements CanActivate {
    constructor(private authService: AuthService,
        private router: Router, private alertify: AlertifyService) {}

    canActivate(
        ): boolean {
            console.log(this.authService.loggedIn());
          if (this.authService.loggedIn()) {
            return true;
          }
          this.alertify.error('You shall not pass');
          this.router.navigate(['/home']);
      }



    }

