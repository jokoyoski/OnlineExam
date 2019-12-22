import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { QuestionComponent } from './question.component';
import { QuestionRoutingModule } from './question-routing.module';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { QuestionService } from '../services/question.service';
import { JwtModule } from '@auth0/angular-jwt';
import { QuestionResolver } from 'src/app/resolver/question-resolver';
export function TokenGetter() {
  return localStorage.getItem('token');      // this is the token
}
@NgModule({
  imports: [
    CommonModule,
    QuestionRoutingModule,
   FormsModule,
   ReactiveFormsModule,
   HttpClientModule,
   JwtModule.forRoot({




    config: {
       tokenGetter: TokenGetter
    ,

  whitelistedDomains: ['adeola-001-site1.ftempurl.com'],  // we just got the token from (Token Getter function above) and we  send request ,
  // it is automatically sending token
  blacklistedRoutes: ['adeola-001-site1.ftempurl.com/api/account']  // we dont want
  // to send token to this address
 }
 })
  ],
  declarations: [QuestionComponent],
  providers: [QuestionService, QuestionResolver]
})
export class QuestionModule { }
