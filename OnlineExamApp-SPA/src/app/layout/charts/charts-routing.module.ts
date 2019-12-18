import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ChartsComponent } from './charts.component';
import { ProgressResolver } from 'src/app/resolver/progress-list.resolver';

const routes: Routes = [
    {
        path: '',
        component: ChartsComponent , resolve: {progress: ProgressResolver}
    }
];

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule]
})
export class ChartsRoutingModule {}
