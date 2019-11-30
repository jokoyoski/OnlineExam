import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { TranslateModule } from '@ngx-translate/core';

import { SignupRoutingModule } from './signup-routing.module';
import { SignupComponent } from './signup.component';
import {FormsModule, ReactiveFormsModule} from '@angular/forms';
import { AuthService } from '../services/Auth.service';
import { AlertifyService } from '../services/AlertifyService';
import { ErrorInterceptorProvider } from '../services/error.Interceptor';

@NgModule({
  imports: [
    CommonModule,
    TranslateModule,
    SignupRoutingModule,
    FormsModule,
    ReactiveFormsModule
  ],
  declarations: [SignupComponent],
  providers: [ AuthService, AlertifyService, ErrorInterceptorProvider]   // errror interceptor was created and it was used in the register
})
export class SignupModule { }
