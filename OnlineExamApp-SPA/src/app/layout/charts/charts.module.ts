import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ChartsModule as Ng2Charts } from 'ng2-charts';

import { ChartsRoutingModule } from './charts-routing.module';
import { ChartsComponent } from './charts.component';
import { PageHeaderModule } from '../../shared';
import { ProviderAst } from '@angular/compiler';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { BsDropdownModule } from 'ngx-bootstrap/dropdown';

import { ProgressResolver } from 'src/app/resolver/progress-list.resolver';
import { FormsModule } from '@angular/forms';


@NgModule({
    imports: [CommonModule, Ng2Charts, ChartsRoutingModule,
        BsDropdownModule.forRoot(), PageHeaderModule, FormsModule],
    declarations: [ChartsComponent],
    providers: [ProgressResolver]
})
export class ChartsModule {}
