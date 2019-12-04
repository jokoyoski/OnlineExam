import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { DashboardComponent } from './dashboard.component';
import { CategoryResolver } from 'src/app/resolver/category-list.resolver';


const routes: Routes = [
    {
        path: '', component: DashboardComponent , resolve: {categories: CategoryResolver}
    }
];

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule]
})
export class DashboardRoutingModule {
}
