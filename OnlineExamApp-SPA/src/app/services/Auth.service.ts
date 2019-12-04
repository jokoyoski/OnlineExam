import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {map} from 'rxjs/operators';
import {BehaviorSubject} from 'rxjs';
import {JwtHelperService} from '@auth0/angular-jwt';
@Injectable({
  providedIn: 'root'
})
export class AuthService {
decodedToken: any;
decodedTokenName: any;
userPic: any;

  pic: any = '../../assets/web/images/user.png';
result: any;
photoUrl = new BehaviorSubject<string>('../../assets/web/images/user.png');
currentPhotoUrl = this.photoUrl.asObservable();
  jwtHelper = new JwtHelperService();

   Gender: any;

   URL = 'https://localhost:44381/api/';
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



              localStorage.setItem('userId', this.decodedToken.nameid);
              localStorage.setItem('userName', this.decodedToken.unique_name);

              this.decodedTokenName = this.decodedToken.unique_name;






            }
            console.log(localStorage.getItem('token'));
          })
        );



        }



        register(model: any) {
          console.log(model);
          return this.http.post(this.URL + 'account/register', model);

        }


          loggedIn() {
          const token = localStorage.getItem('token');

          const tokens = this.jwtHelper.isTokenExpired(token);

          if (tokens === false) {

            return true;
          }
          return false;
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
