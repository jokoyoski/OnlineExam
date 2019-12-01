import { Component, OnInit, ElementRef, ViewChild } from '@angular/core';
import { CookieService } from 'ngx-cookie-service';
import { QuestionService } from '../services/question.service';

@Component({
  selector: 'app-question',
  templateUrl: './question.component.html',
  styleUrls: ['./question.component.scss']
})

export class QuestionComponent implements OnInit {


  questionList = [];
  isLoad = true;

  materialExampleRadios: any;
  question: any = {};
  constructor(private cookie: CookieService, private questionService: QuestionService) {


   }


  radioModel: any;
 



    ngOnInit() {
      this.questionService.seconds = 36000;
      this.setTimer();
  this.materialExampleRadios = '';

  this.question = this.questionService.getQuestions();
  console.log(4);
  console.log( this.question[0].Question);

  }

   setTimer() {
     this.questionService.timer = setInterval(() => {
this.questionService.seconds--;
     if (this.questionService.seconds === 0) {

     }
     }, 1000);  // the function will be called after a second
   }


  selectedOption(value: any, QId: number) {
    const savedQuestions = JSON.parse(this.cookie.get('questions'));


    for (let i = 0; i < savedQuestions.length; i++) {

     if (savedQuestions[i].Question_Number === QId) {


        savedQuestions[i].Selected_Answer = value;

        savedQuestions[i].selected = 'selected';

     }



  }

  // tslint:disable-next-line: align
  this.cookie.set('questions', JSON.stringify(savedQuestions));


  }






 goTo(QId: any) {

  const savedQuestions = JSON.parse(this.cookie.get('questions'));


  this.question.Current.Options[0] = savedQuestions[QId - 1].Options[0];
  this.question.Current.Options[1] = savedQuestions[QId - 1].Options[1];
  this.question.Current.Options[2] = savedQuestions[QId - 1].Options[2];
  this.question.Current.Options[3] = savedQuestions[QId - 1].Options[3];
  this.question.Current.Options[4] = savedQuestions[QId - 1].Options[4];

  this.question.Current = savedQuestions[QId - 1];

  this.materialExampleRadios = this.question.Current.Selected_Answer;
  this.question.QuestionList = savedQuestions;




 }




}
