import { Injectable } from '@angular/core';
import { CanActivate, ActivatedRouteSnapshot } from '@angular/router';
import { Router } from '@angular/router';
import { AuthService } from 'src/app/services/Auth.service';
import { AlertifyService } from 'src/app/services/AlertifyService';

@Injectable()
export class AuthGuard implements CanActivate {
    constructor(private authService: AuthService,
        private router: Router, private alertify: AlertifyService) {}

    canActivate(next: ActivatedRouteSnapshot
        ): boolean {
  const roles = next.firstChild.data['roles'] as Array<string>;
  console.log(roles);
  if (roles) {
    const match = this.authService.roleMatch(roles);
    if (match) {
      return true;
    } else {
      this.router.navigate(['members']);
      this.alertify.error('Not authorized');
    }
  }
          if (this.authService.loggedIn()) {
            return true;
          }

          this.router.navigate(['/home']);
      }



    }

