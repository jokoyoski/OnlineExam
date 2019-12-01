export interface Question {

   questionId: number;
   question: string;
   options: Options[];
   questionNumber: number;
   selectedAnswer: number;



}


export interface Options {

    optionId: number;
    optionNumber: string;
    optionlabel: string;
    isAvaialable: boolean;
    checked: boolean;

}
