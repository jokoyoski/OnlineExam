import { Injectable } from '@angular/core';
import { Category } from '../../app/layout/QuestionModel';
import { Resolve, Router, ActivatedRouteSnapshot } from '@angular/router';
import { QuestionService } from '../../app/layout/services/question.service';
import { Observable, of } from 'rxjs';
import { catchError } from 'rxjs/operators';


@Injectable()

export class CategoryResolver implements Resolve<Category[]> {
pageNumber = 1;
pageSize = 5;
    constructor(private questionService: QuestionService , private router: Router) {}

resolve(route: ActivatedRouteSnapshot): Observable<Category[]> {

    return this.questionService.getCategories().pipe(


        catchError(error => {

            this.router.navigate(['/members']);
            return of(null);
        }


        )
    );
}
}
