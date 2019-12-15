import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-result',
  templateUrl: './result.component.html',
  styleUrls: ['./result.component.scss']
})
export class ResultComponent implements OnInit {

  result: any;
  loader = false;
  constructor() { }

  ngOnInit() {
    this.loader = true;
    setTimeout(() => {
      
        this.result = localStorage.getItem('result');
        this.loader = false;
    }, 3000);

  }

}
