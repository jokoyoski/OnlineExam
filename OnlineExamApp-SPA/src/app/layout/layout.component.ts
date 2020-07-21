import { Component, OnInit } from '@angular/core';
import { AuthService } from '../services/Auth.service';

@Component({
    selector: 'app-layout',
    templateUrl: './layout.component.html',
    styleUrls: ['./layout.component.scss']
})
export class LayoutComponent implements OnInit {

    collapedSideBar: boolean;

    constructor(private authService: AuthService) {}


    ngOnInit() {

        this.authService.canUpdateTrials( localStorage.getItem('trials'));
    }

    receiveCollapsed($event) {
        console.log($event);
        this.collapedSideBar = $event;
    }

}
