import { Component, OnInit } from '@angular/core';
import { Router, NavigationEnd } from '@angular/router';
import { TranslateService } from '@ngx-translate/core';
import { AlertifyService } from 'src/app/services/AlertifyService';

@Component({
    selector: 'app-header',
    templateUrl: './header.component.html',
    styleUrls: ['./header.component.scss']
})
export class HeaderComponent implements OnInit {
    public pushRightClass: string;
     name: string;
    constructor(private translate: TranslateService, public router: Router,private alertifyService:AlertifyService) {

        this.router.events.subscribe(val => {
            if (
                val instanceof NavigationEnd &&
                window.innerWidth <= 992 &&
                this.isToggled()
            ) {
                this.toggleSidebar();
            }
        });
    }

    ngOnInit() {

        this.name =  localStorage.getItem('userName');


        this.pushRightClass = 'push-right';
    }


    loggedOut() {
        localStorage.removeItem('token');


        this.alertifyService.success('logged Out');
        this.router.navigate(['/login']);  // navigate to home, this was done by setting up the route.ts, setting some route there
        // then coming to add RouteModule in app.module.ts and then injcting the module in the nav.component.ts

      }
    isToggled(): boolean {
        const dom: Element = document.querySelector('body');
        return dom.classList.contains(this.pushRightClass);
    }

    toggleSidebar() {
        const dom: any = document.querySelector('body');
        dom.classList.toggle(this.pushRightClass);
    }

    rltAndLtr() {
        const dom: any = document.querySelector('body');
        dom.classList.toggle('rtl');
    }

    onLoggedout() {
        localStorage.removeItem('isLoggedin');
    }

    changeLang(language: string) {
        this.translate.use(language);
    }
}
