import { Component, OnInit } from '@angular/core';
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
  question: any;
  constructor(private cookie: CookieService, private questionService: QuestionService) {


   }


  radioModel: any;



    ngOnInit() {
  this.materialExampleRadios = 'A';

  this.question = this.questionService.getQuestions();
  console.log( this.question);

  }
  selectedOption(value: any, QId: number) {
    const savedQuestions = JSON.parse(this.cookie.get('questions'));


    for (let i = 0; i < savedQuestions.length; i++) {

     if (savedQuestions[i].Question_Number === QId) {


        savedQuestions[i].Selected_Answer = value;

        savedQuestions[i].selected = 'selected';
        console.log( savedQuestions[i]);

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

  console.log(this.question);


 }




}
