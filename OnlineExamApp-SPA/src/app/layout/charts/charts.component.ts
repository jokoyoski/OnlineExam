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
    progress: Progress;
    response: any;
    // bar chart
    public barChartOptions: any = {
        scaleShowVerticalLines: false,
        responsive: true
    };
    public barChartLabels: string[] = [
        '2006',
        '2007',
        '2008',
        '2009',
        '2010',
        '2011',
        '2012'
    ];
    public barChartType: string;
    public barChartLegend: boolean;


    public barChartData: any[] = [
       { data: [65], label: 'English' },
        { data: [28], label: 'Math' },
        { data: [28], label: 'Physics' }


  ];



    ComputeProgress(response: any) {
        this.progress = response.categoryScoreCollection;
        console.log(this.progress);

    }



    // events
    public chartClicked(e: any): void {
        // console.log(e);
    }

    public chartHovered(e: any): void {
        // console.log(e);
    }

    public randomize(): void {
        // Only Change 3 values
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

    ngOnInit() {
<<<<<<< HEAD
        this.GetProgress();
        this.barChartType = 'bar';
        this.barChartLegend = true;

=======
       // const result = this.GetProgress();
       // this.ComputeProgress(result);
       this.route.data.subscribe((data: any) => {
        this.loader = true;
        setTimeout(() => {
            this.ComputeProgress(data.progress);
            this.loader = false;
        }, 3000);


      });
        this.barChartType = 'bar';
        this.barChartLegend = true;




>>>>>>> 7312790d2293ffaf672a20348230836c2679ec12
    }
}
