import { Injectable } from '@angular/core';
import { Category, Question } from '../../app/layout/QuestionModel';
import { Resolve, Router, ActivatedRouteSnapshot } from '@angular/router';
import { QuestionService } from '../../app/layout/services/question.service';
import { Observable, of } from 'rxjs';
import { catchError } from 'rxjs/operators';


@Injectable()

export class QuestionResolver implements Resolve<Question[]> {

    constructor(private questionService: QuestionService , private router: Router) {}

resolve(route: ActivatedRouteSnapshot): Observable<Question[]> {

    return this.questionService.GetQuestion(+route.params['id']).pipe(


        catchError(error => {

            this.router.navigate(['/members']);
            return of(null);
        }


        )
    );
}
}
