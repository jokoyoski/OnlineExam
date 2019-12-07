import { Injectable } from '@angular/core';
import { Category, Question, Result } from '../../app/layout/QuestionModel';
import { Resolve, Router, ActivatedRouteSnapshot } from '@angular/router';
import { QuestionService } from '../../app/layout/services/question.service';
import { Observable, of } from 'rxjs';
import { catchError } from 'rxjs/operators';


@Injectable()

export class ResultResolver implements Resolve<Result> {

    constructor(private questionService: QuestionService , private router: Router) {}

resolve(route: ActivatedRouteSnapshot): Observable<Result> {

    return this.questionService.GetQuestion(+route.params['id']).pipe(


        catchError(error => {

            this.router.navigate(['/members']);
            return of(null);
        }


        )
    );
}
}
