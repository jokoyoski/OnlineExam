import { Injectable } from '@angular/core';
import { Category, Question, Progress } from '../../app/layout/QuestionModel';
import { Resolve, Router, ActivatedRouteSnapshot } from '@angular/router';
import { QuestionService } from '../../app/layout/services/question.service';
import { Observable, of } from 'rxjs';
import { catchError } from 'rxjs/operators';
import { AuthService } from '../services/Auth.service';


@Injectable()

export class ProgressResolver implements Resolve<Progress> {

    constructor(private authService: AuthService, private router: Router) {}

resolve(route: ActivatedRouteSnapshot): Observable<Progress> {

    return this.authService.getProgress().pipe(


        catchError(error => {

            this.router.navigate(['/members']);
            return of(null);
        }


        )
    );
}
}
