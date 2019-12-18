import { Component, OnInit } from '@angular/core';
import { routerTransition } from '../../router.animations';
import { AuthService } from 'src/app/services/Auth.service';
import { Progress , BarChart} from '../QuestionModel';
import { ActivatedRoute } from '@angular/router';

@Component({
    selector: 'app-charts',
    templateUrl: './charts.component.html',
    styleUrls: ['./charts.component.scss'],
    animations: [routerTransition()]
})
export class ChartsComponent implements OnInit {

    constructor(private authService: AuthService, private route: ActivatedRoute) {

    }


   loader = true;
    value: BarChart[];
    barDataChart: any;
    progress: Progress;
    response: any;
    categoryList: [] = [];
    progressParams: any = {};


    submitCategory() {

        this.authService.GetProgress(this.progressParams).subscribe((data: any) => {
          this.barDataChart = data;
        });
    }


    ngOnInit() {




       this.route.data.subscribe((data: any) => {
        this.loader = true;
        setTimeout(() => {

            this.categoryList = JSON.parse(localStorage.getItem('categories'));
      console.log(this.categoryList);
            this.loader = false;
        }, 3000);


      });






    }


}
