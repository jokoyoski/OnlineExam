import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { QuestionComponent } from './question.component';
import { QuestionResolver } from 'src/app/resolver/question-resolver';


const routes: Routes = [
    {
        path: 'question/:id', component: QuestionComponent , resolve: {question: QuestionResolver}
    }
];

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule]
})
export class QuestionRoutingModule {
}
