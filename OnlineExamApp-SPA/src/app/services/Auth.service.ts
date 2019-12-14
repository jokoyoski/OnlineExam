import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {map} from 'rxjs/operators';
import {BehaviorSubject} from 'rxjs';
import {JwtHelperService} from '@auth0/angular-jwt';
import { Progress, BarChart } from '../layout/QuestionModel';
@Injectable({
  providedIn: 'root'
})
export class AuthService {
decodedToken: any;
decodedTokenName: any;
userPic: any;
barChartData: any[];
barData: BarChart;

  pic: any = '../../assets/web/images/user.png';
result: any;
photoUrl = new BehaviorSubject<string>('../../assets/web/images/user.png');
currentPhotoUrl = this.photoUrl.asObservable();
  jwtHelper = new JwtHelperService();

   Gender: any;
   value: BarChart[];
   URL = 'http://localhost:5000/api/';
  httpClient: any;

constructor(private http: HttpClient, ) { }

canMemberChangePhoto(photoUrl: string) {


this.photoUrl.next(photoUrl);   // the behaviour subject has a next attr which signifies the next value
}

login(model: any) {

        return this.http.post(this.URL + 'account/login', model)
        .pipe(

          map((response: any) => {   // maping of the values

            this.result = response;


            if (this.result) {

              localStorage.setItem('token', this.result.token);




              this.decodedToken = this.jwtHelper.decodeToken(this.result.token);  // decoding token

                    console.log(this.decodedToken);

              localStorage.setItem('userId', this.decodedToken.nameid);
              localStorage.setItem('userName', this.decodedToken.unique_name);
              localStorage.setItem('givenName', this.decodedToken.given_name);


              this.decodedTokenName = this.decodedToken.unique_name;






            }

          })
        );



        }



        register(model: any) {

          return this.http.post(this.URL + 'account/register', model);

        }

        getProgress() {

          const tokenId = localStorage.getItem('userId');
          return this.http.get(this.URL + 'user/' + tokenId);

        }


          loggedIn() {
          const token = localStorage.getItem('token');

          const tokens = this.jwtHelper.isTokenExpired(token);

          if (tokens === false) {

            return true;
          }
          return false;
        }

        Submit(question: any) {
          const tokenId = localStorage.getItem('userId');
          console.log(tokenId);
          // const url = this.url + tokenId + '/submitTest';

          return this.http.post('http://localhost:5000/api/question/' + tokenId + '/submitTest', question).pipe(

            map((response: any) => {
            this.result = response;
            localStorage.setItem('result', this.result);
              }));


        }

roleMatch(allowedRoles): boolean {
let isMatch = false;

const userRoles = this.decodedToken.role as Array<string>;
allowedRoles.forEach(element => {
if (userRoles.includes(element)) {
  isMatch = true;
}

});
return isMatch;
}
}
