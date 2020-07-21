import { CommonModule } from '@angular/common';
import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { LanguageTranslationModule } from './shared/modules/language-translation/language-translation.module';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { AuthGuard } from './shared';
import { CookieService } from 'ngx-cookie-service';
import { AlertifyService } from './services/AlertifyService';
import { ErrorInterceptorProvider } from './services/error.Interceptor';
import { RoleDirective } from './_directives/role.directive';
import { LoginComponent } from './login/login.component';
import { HomeComponent } from './home/home.component';
import { ReactiveFormsModule, FormsModule } from '@angular/forms';
import { SignupComponent } from './signup/signup.component';
import { NavComponent } from './nav/nav.component';


@NgModule({
   imports: [
      CommonModule,
      BrowserModule,
      BrowserAnimationsModule,
      HttpClientModule,
      LanguageTranslationModule,
      AppRoutingModule,
      ReactiveFormsModule,
      FormsModule
   ],
   declarations: [
      AppComponent,
      LoginComponent,
      SignupComponent,
      HomeComponent,
      NavComponent
   ],
   providers: [
      AuthGuard,
      CookieService,
      AlertifyService,

      ErrorInterceptorProvider,
      RoleDirective
   ],
   bootstrap: [
      AppComponent
   ]
})
export class AppModule {}
