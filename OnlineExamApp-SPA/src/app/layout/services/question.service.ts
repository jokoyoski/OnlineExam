import { Injectable } from '@angular/core';
import { questionEnviroment } from './questionEnvironment';
import { CookieService } from 'ngx-cookie-service';

@Injectable({
  providedIn: 'root'
})
export class QuestionService {

  questions = questionEnviroment;
  private cookieValue = [];
   questionList: any;
   question: any = {};

  constructor(private cookie: CookieService) { }

   getQuestions() {
    let j = 1;

    for (let i = 0; i <= this.questions.length - 1; i++) {

     this.questions[i].Question_Number = j;
     j++;
     }
    this.cookie.set('questions', JSON.stringify(this.questions));

    this.question.QuestionList = this.questions;
    this.question.Current = this.questions[0];
    console.log(this.question.QuestionList);
    return  this.question;


   }
}
