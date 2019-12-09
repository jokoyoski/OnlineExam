import { Component, OnInit, ElementRef, ViewChild } from '@angular/core';
import { CookieService } from 'ngx-cookie-service';
import { QuestionService } from '../services/question.service';
import { questionFromDb } from '../services/questionfromServer';
import { Question, Options, Answer } from '../QuestionModel';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-question',
  templateUrl: './question.component.html',
  styleUrls: ['./question.component.scss']
})

export class QuestionComponent implements OnInit {


  questionList = [];
  isLoad = true;
  updateRadioSel: Options;
  questionArray: Question[];
  radioSelectedString: string;
  questionNumber: number;
  materialExampleRadios: any = {};
  radioSelected: any = {};
  answerInfo: any = {};
  answerArray: any = [];
  currentQuestion: Question;
  allQuestion: any = {};
  questionFromService: any = {};
  question: any = {};
  radioSel: any;
  gender: any = {};
  questionId: number;
  options: any = [];
  answered: any = {};
  showLoader = true;
  constructor(private cookie: CookieService,
    private route: ActivatedRoute, private router: Router , private questionService: QuestionService) {


   }


  radioModel: any;




    ngOnInit() {

      setTimeout(() => {
        this.showLoader = false;
    }, 4000);
      this.route.data.subscribe((data: any) => {
        console.log(data.question);
 this.getQuestion(data.question);
      });
      this.questionService.seconds = 36000;
      this.setTimer();


   this.radioSelected = 'Lamba1';



  }

   setTimer() {
     this.questionService.timer = setInterval(() => {
this.questionService.seconds--;
     if (this.questionService.seconds === 0) {

     }
     }, 1000);  // the function will be called after a second
   }


  selectedOption(value: any, QId: number) {
  console.log(value, QId);
  const question = this.allQuestion.find(x => x.questionId === QId);

  question.selectedAnswer = value;

  try {
    const values = question.options.find(x => x.checked === true);
    values.checked = false;
    const newValues = question.options.find(x => x.optionId === value);
    newValues.checked = true;
    values.selectedAnswer = newValues.optionId;

  } catch (e) {
    const newValues = question.options.find(x => x.optionId === value);
    newValues.checked = true;
    this.radioSelected = newValues.optionName;
  }




  }

  getSelecteditem(QId: any, optionId: number) {

    try {
      this.currentQuestion = this.allQuestion.find(x => x.questionNumber === QId);
      this.radioSel = this.currentQuestion.options.find(Item => Item.checked === true);
      this.radioSel.checked = false;
      this.updateRadioSel = this.currentQuestion.options.find(x => x.optionId === optionId);
      this.updateRadioSel.checked = true;
      this.radioSelected = this.updateRadioSel.optionName;

    } catch {
      this.currentQuestion = this.allQuestion.find(x => x.questionNumber === QId);

      this.updateRadioSel = this.currentQuestion.options.find(x => x.optionId === optionId);
      this.updateRadioSel.checked = true;
      this.radioSelected = this.updateRadioSel.optionName;
    }
    this.currentQuestion.selectedAnswer = optionId;


  }



 goTo(QId: any) {


   try {

    this.currentQuestion = this.allQuestion.find(x => x.questionNumber === QId);
    this.updateRadioSel = this.currentQuestion.options.find(x => x.checked === true);

    this.radioSelected = this.updateRadioSel.optionName;


   } catch (e) {

   }




 }

 getQuestion(question: Question[]) {

  this.questionArray = question;

  this.questionNumber = 1;
 for (let i = 0; i < this.questionArray.length; i++) {
      this.questionArray[i].questionNumber = this.questionNumber;
      this.questionArray[i].selectedAnswer = 0;
      this.questionNumber++;
   }


   this.currentQuestion = this.questionArray[0];
   this.allQuestion = this.questionArray;



}

submitQuestion() {

  for (let i = 0; i < this.allQuestion.length; i++) {

    const joko = this.allQuestion[i].questionId;

    // this.answerInfo.questionId = this.allQuestion[i].questionId;
    // this.answerInfo.optionId = this.allQuestion[i].selectedAnswer;
    this.questionId = this.allQuestion[i].questionId;
    this.options.push(this.allQuestion[i].selectedAnswer);

    this.answered.questionId = this.questionId;
     this.answered.options = this.options;


  this.answerArray.push(this.answered);
    this.answered = {};

  }

  this.questionService.Submit(this.answerArray).subscribe((data: any) => {
  console.log(data);
  }, error => {
    console.log(error);
  }, () => {
    this.router.navigate(['/result']);

  });


}


}
