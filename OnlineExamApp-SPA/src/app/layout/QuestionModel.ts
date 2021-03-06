import { DecimalPipe } from '@angular/common';

export interface Question {

    questionId: number;
    question: string;
    options: Options[];
    questionNumber: number;
    selectedAnswer: number;
    categoryId: number;



 }


 export interface Options {

     optionId: number;
     optionName: string;
     optionNumber: string;
     optionlabel: string;
     isAvaialable: boolean;
     checked: boolean;

 }

 export interface Category {
    categoryId: number;
    categoryName: string;
    duration: number;




   }
 export interface Answer {
  questionId: number;
  optionId: number;
 }

 export interface Result {
     result: number;
 }

 export interface CategoryScoreCollection {
    categoryName: string;
    percentageAverageScore: number;

 }

 export interface Progress {
    categoryName: any;
    percentageAverageScore: number;

 }

 export class BarChart {
     label: string;
     data: number[];
 }
