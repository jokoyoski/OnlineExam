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

    progress: Progress;
    response: any;
    char: any = [];
    categoryList: [] = [];
    progressParams: any = {};
    isShowChart: any = false;
    // bar chart
    public barChartOptions: any = {
      scaleShowVerticalLines: false,
      responsive: true
  };
  public barChartType: string;
  public barChartLegend: boolean;

  barChartData: any[] = [


];

public randomize(): void {

  const data = [
      Math.round(Math.random() * 100),
      59,
      80,
      Math.random() * 100,
      56,
      Math.random() * 100,
      40
  ];
  const clone = JSON.parse(JSON.stringify(this.barChartData));
  clone[0].data = data;
  this.barChartData = clone;
  /**
   * (My guess), for Angular to recognize the change in the dataset
   * it has to change the dataset variable directly,
   * so one way around it, is to clone the data, change it and then
   * assign it;
   */
}


    submitCategory() {
     this.barChartData = [];
     this.char = [];
        this.authService.GetProgress(this.progressParams).subscribe((data: any) => {
          console.log(data);
          this.barChartData = data;
          this.char.push(data.userAverageScore);
          this.char.push(data.overallAverageScore);

        this.barChartData = this.char;
        this.isShowChart = true;
       

        });
    }


    // events
    public chartClicked(e: any): void {

  }

  public chartHovered(e: any): void {

  }
    ngOnInit() {
    this.isShowChart = false;
      this.barChartType = 'bar';
      this.barChartLegend = true;


       this.route.data.subscribe((data: any) => {
        this.loader = true;
        setTimeout(() => {

            this.categoryList = JSON.parse(localStorage.getItem('categories'));


            this.loader = false;
        }, 3000);


      });






    }


}
