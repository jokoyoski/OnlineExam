import { Injectable } from '@angular/core';
import { questionEnviroment } from './questionEnvironment';
import {questionFromDb} from './questionfromServer';
import { CookieService } from 'ngx-cookie-service';
import { HttpClient } from '@angular/common/http';
import {map} from 'rxjs/operators';
import { Category } from '../QuestionModel';


@Injectable({
  providedIn: 'root'
})
export class QuestionService {

  questions = questionEnviroment;

  private cookieValue = [];
   questionList: any;
    newquestion: any;
    questionNumber: number;
   question: any = [];
   seconds: number;
   timer: any;
   result: any;
   categories: Category[];
   componentQuestion: any = {};
   url = 'http://localhost:5000/api/question/';
   value: string;
  constructor(private cookie: CookieService, private httpClient: HttpClient) { }



  displayTimeElapsed() {



    return Math.floor(this.seconds / 3600) + ':' + Math.floor((this.seconds % 3600) / 60) + ':' + Math.floor(this.seconds % 60);

  }
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

  GetQuestion(categoryId: number) {


  return  this.httpClient.get(this.url  + categoryId);
  }


  getCategories() {

    return this.httpClient.get(this.url);

  }



        Submit(question: any) {

       console.log(question);
          const tokenId = localStorage.getItem('userId');
          const url = this.url + tokenId + '/submitTest';

         return this.httpClient.post(this.url + 5 + '/submitTest', question).pipe(

            map((response: any) => {
            this.result = response;
            localStorage.setItem('result', this.result);
              }));

        }


  }



