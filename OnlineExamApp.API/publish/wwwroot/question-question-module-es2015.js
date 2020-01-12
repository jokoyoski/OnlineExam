(window["webpackJsonp"] = window["webpackJsonp"] || []).push([["question-question-module"],{

/***/ "./node_modules/raw-loader/index.js!./src/app/layout/question/question.component.html":
/*!***********************************************************************************!*\
  !*** ./node_modules/raw-loader!./src/app/layout/question/question.component.html ***!
  \***********************************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "\n\n\n<!--<div class=\"text-center centre_item\" *ngIf=\"showLoader\">\n  <div class=\"a\" style=\"--n: 5;\">\n      <div class=\"dot\" style=\"--i: 0;\"></div>\n      <div class=\"dot\" style=\"--i: 1;\"></div>\n      <div class=\"dot\" style=\"--i: 2;\"></div>\n      <div class=\"dot\" style=\"--i: 3;\"></div>\n      <div class=\"dot\" style=\"--i: 4;\"></div>\n  </div>\n</div>-->\n<div>\n  <h4 class=\"text-center alert alert-success\">Curent Affairs</h4>\n  <h6 class=\"text-center alert alert-primary\">You have done this subject 25 times</h6>\n  <h6 class=\"text-center alert alert-danger\">Warning! Please do not reload the page as your progress will be lost </h6>\n \n<span>Time Elapsed : {{questionService.displayTimeElapsed()}}</span>\n<div class=\"container-fluid pt-1\">\n    <div class=\"row\"> \n        <div class=\"col-6 jumbotron pb-0\">\n            <div class=\"card\">\n                <div class=\"card-header\">\n                  Question &nbsp; &nbsp;{{currentQuestion.questionNumber}}\n                  </div>\n                <div class=\"card-body\">\n              {{currentQuestion.questions}}\n                    </div>\n              </div>\n    \n  </div>\n        <div class=\"col-6 jumbotron\">\n            <div *ngFor=\"let item of currentQuestion.options\">\n                <div class=\"card\" style=\"width: 18rem;\">\n                    <ul class=\"list-group list-group-flush\">\n                      <div>\n                          <li class=\"list-group-item\">\n                              <div class=\"row\">\n                                  \n                              \n                                  <input type=\"radio\" [(ngModel)]=\"radioSelected\" name=\"item.optionName\" value=\"{{item.optionName}}\" (change)=\"getSelecteditem(currentQuestion.questionNumber,item.optionId)\"/> \n                                 &nbsp; &nbsp;\n                                  {{item.optionName}}\n                                  \n                              \n            \n                              </div>\n                               \n                            </li>\n                      </div>\n                     \n                    </ul>\n                  </div>\n        \n            </div>\n           \n\n                \n    </div>\n      \n   \n       \n \n\n    \n  \n</div>\n\n         <div class=\"row\">\n    \n    <button (click)=\"submitQuestion()\" class=\"btn btn-success mx-auto\" >Submit</button>\n   \n </div>                        \n</div>\n<div class=\"text-center pt-0\">\n  <div class=\"card\">\n    <div class=\"card-header\">\n      Progress\n    </div>\n    <div class=\"card-body\">\n      <div class=\"border-radius\">\n        <div class=\"row\">\n           <div *ngFor=\"let a of allQuestion\">\n     \n             \n                <div *ngIf=\"a.selectedAnswer!==0; else red\" >\n                   <div (click)=\"goTo(a.questionNumber)\" style=\"background:green;width:20px;height:25px;padding:2px;text-align:center;border-radius:10em;color:#fff;cursor:pointer;\">{{a.questionNumber}}</div>\n                </div>\n                \n              <ng-template #red>\n                   <div (click)=\"goTo(a.questionNumber)\" style=\"background:red;width:20px;height:25px;padding:2px;text-align:center;border-radius:10em;color:#fff;cursor:pointer;\">{{a.questionNumber}}</div>\n              \n              </ng-template>\n                     \n                </div>\n  </div>\n      </div>\n    </div>\n  </div>\n</div>\n\n"

/***/ }),

/***/ "./src/app/layout/question/question-routing.module.ts":
/*!************************************************************!*\
  !*** ./src/app/layout/question/question-routing.module.ts ***!
  \************************************************************/
/*! exports provided: QuestionRoutingModule */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "QuestionRoutingModule", function() { return QuestionRoutingModule; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm2015/router.js");
/* harmony import */ var _question_component__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ./question.component */ "./src/app/layout/question/question.component.ts");
/* harmony import */ var src_app_resolver_question_resolver__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! src/app/resolver/question-resolver */ "./src/app/resolver/question-resolver.ts");





const routes = [
    {
        path: 'question/:id', component: _question_component__WEBPACK_IMPORTED_MODULE_3__["QuestionComponent"], resolve: { question: src_app_resolver_question_resolver__WEBPACK_IMPORTED_MODULE_4__["QuestionResolver"] }
    }
];
let QuestionRoutingModule = class QuestionRoutingModule {
};
QuestionRoutingModule = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["NgModule"])({
        imports: [_angular_router__WEBPACK_IMPORTED_MODULE_2__["RouterModule"].forChild(routes)],
        exports: [_angular_router__WEBPACK_IMPORTED_MODULE_2__["RouterModule"]]
    })
], QuestionRoutingModule);



/***/ }),

/***/ "./src/app/layout/question/question.component.scss":
/*!*********************************************************!*\
  !*** ./src/app/layout/question/question.component.scss ***!
  \*********************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = ".page-footer {\n  background: #222;\n}\n\n.footer-copyright {\n  color: white;\n}\n\n.card-header img {\n  width: 20px;\n  height: 20px;\n}\n\nbody {\n  padding-top: 1em;\n  background: currentcolor;\n  color: black;\n  text-align: center;\n}\n\n.dot {\n  background: black;\n  top: 50%;\n  bottom: 50%;\n}\n\n.dot,\n.dot:after {\n  display: inline-block;\n  width: 2em;\n  height: 2em;\n  border-radius: 50%;\n  -webkit-animation: a 1.5s calc(((var(--i) + var(--o, 0)) / var(--n) - 1) * 1.5s) infinite;\n          animation: a 1.5s calc(((var(--i) + var(--o, 0)) / var(--n) - 1) * 1.5s) infinite;\n}\n\n.dot:after {\n  --o: 1;\n  background: currentcolor;\n  content: \"\";\n}\n\n@-webkit-keyframes a {\n  0%, 50% {\n    -webkit-transform: scale(0);\n            transform: scale(0);\n  }\n}\n\n@keyframes a {\n  0%, 50% {\n    -webkit-transform: scale(0);\n            transform: scale(0);\n  }\n}\n\n.centre_item {\n  margin-top: 12rem;\n}\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbIi9Vc2Vycy9tYWMvUHJvamVjdHMvT25saW5lRXhhbS9PbmxpbmVFeGFtQXBwLVNQQS9zcmMvYXBwL2xheW91dC9xdWVzdGlvbi9xdWVzdGlvbi5jb21wb25lbnQuc2NzcyIsInNyYy9hcHAvbGF5b3V0L3F1ZXN0aW9uL3F1ZXN0aW9uLmNvbXBvbmVudC5zY3NzIl0sIm5hbWVzIjpbXSwibWFwcGluZ3MiOiJBQUFBO0VBQ0ksZ0JBQUE7QUNDSjs7QURFQTtFQUNJLFlBQUE7QUNDSjs7QURFQTtFQUNJLFdBQUE7RUFDQSxZQUFBO0FDQ0o7O0FER0E7RUFDSSxnQkFBQTtFQUNBLHdCQUFBO0VBQ0EsWUFBQTtFQUNBLGtCQUFBO0FDQUo7O0FERUE7RUFDSSxpQkFBQTtFQUNBLFFBQUE7RUFDQSxXQUFBO0FDQ0o7O0FEQ0E7O0VBRUkscUJBQUE7RUFDQSxVQUFBO0VBQ0EsV0FBQTtFQUNBLGtCQUFBO0VBQ0EseUZBQUE7VUFBQSxpRkFBQTtBQ0VKOztBRENBO0VBQ0ksTUFBQTtFQUNBLHdCQUFBO0VBQ0EsV0FBQTtBQ0VKOztBREFBO0VBQ0k7SUFFSSwyQkFBQTtZQUFBLG1CQUFBO0VDRU47QUFDRjs7QUROQTtFQUNJO0lBRUksMkJBQUE7WUFBQSxtQkFBQTtFQ0VOO0FBQ0Y7O0FEQ0E7RUFDSSxpQkFBQTtBQ0NKIiwiZmlsZSI6InNyYy9hcHAvbGF5b3V0L3F1ZXN0aW9uL3F1ZXN0aW9uLmNvbXBvbmVudC5zY3NzIiwic291cmNlc0NvbnRlbnQiOlsiLnBhZ2UtZm9vdGVyIHtcbiAgICBiYWNrZ3JvdW5kOiAjMjIyO1xufVxuXG4uZm9vdGVyLWNvcHlyaWdodCB7XG4gICAgY29sb3I6IHdoaXRlO1xufVxuXG4uY2FyZC1oZWFkZXIgaW1nIHtcbiAgICB3aWR0aDogMjBweDtcbiAgICBoZWlnaHQ6IDIwcHg7XG59XG5cbi8vIExvYWRlclxuYm9keSB7XG4gICAgcGFkZGluZy10b3A6IDFlbTtcbiAgICBiYWNrZ3JvdW5kOiBjdXJyZW50Y29sb3I7XG4gICAgY29sb3I6IGJsYWNrO1xuICAgIHRleHQtYWxpZ246IGNlbnRlcjtcbn1cbi5kb3Qge1xuICAgIGJhY2tncm91bmQ6IGJsYWNrO1xuICAgIHRvcDogNTAlO1xuICAgIGJvdHRvbTogNTAlO1xufVxuLmRvdCxcbi5kb3Q6YWZ0ZXIge1xuICAgIGRpc3BsYXk6IGlubGluZS1ibG9jaztcbiAgICB3aWR0aDogMmVtO1xuICAgIGhlaWdodDogMmVtO1xuICAgIGJvcmRlci1yYWRpdXM6IDUwJTtcbiAgICBhbmltYXRpb246IGEgMS41cyBjYWxjKCgodmFyKC0taSkgKyB2YXIoLS1vLCAwKSkgLyB2YXIoLS1uKSAtIDEpICogMS41cylcbiAgICAgICAgaW5maW5pdGU7XG59XG4uZG90OmFmdGVyIHtcbiAgICAtLW86IDE7XG4gICAgYmFja2dyb3VuZDogY3VycmVudGNvbG9yO1xuICAgIGNvbnRlbnQ6IFwiXCI7XG59XG5Aa2V5ZnJhbWVzIGEge1xuICAgIDAlLFxuICAgIDUwJSB7XG4gICAgICAgIHRyYW5zZm9ybTogc2NhbGUoMCk7XG4gICAgfVxufVxuXG4uY2VudHJlX2l0ZW0ge1xuICAgIG1hcmdpbi10b3A6IDEycmVtO1xufVxuIiwiLnBhZ2UtZm9vdGVyIHtcbiAgYmFja2dyb3VuZDogIzIyMjtcbn1cblxuLmZvb3Rlci1jb3B5cmlnaHQge1xuICBjb2xvcjogd2hpdGU7XG59XG5cbi5jYXJkLWhlYWRlciBpbWcge1xuICB3aWR0aDogMjBweDtcbiAgaGVpZ2h0OiAyMHB4O1xufVxuXG5ib2R5IHtcbiAgcGFkZGluZy10b3A6IDFlbTtcbiAgYmFja2dyb3VuZDogY3VycmVudGNvbG9yO1xuICBjb2xvcjogYmxhY2s7XG4gIHRleHQtYWxpZ246IGNlbnRlcjtcbn1cblxuLmRvdCB7XG4gIGJhY2tncm91bmQ6IGJsYWNrO1xuICB0b3A6IDUwJTtcbiAgYm90dG9tOiA1MCU7XG59XG5cbi5kb3QsXG4uZG90OmFmdGVyIHtcbiAgZGlzcGxheTogaW5saW5lLWJsb2NrO1xuICB3aWR0aDogMmVtO1xuICBoZWlnaHQ6IDJlbTtcbiAgYm9yZGVyLXJhZGl1czogNTAlO1xuICBhbmltYXRpb246IGEgMS41cyBjYWxjKCgodmFyKC0taSkgKyB2YXIoLS1vLCAwKSkgLyB2YXIoLS1uKSAtIDEpICogMS41cykgaW5maW5pdGU7XG59XG5cbi5kb3Q6YWZ0ZXIge1xuICAtLW86IDE7XG4gIGJhY2tncm91bmQ6IGN1cnJlbnRjb2xvcjtcbiAgY29udGVudDogXCJcIjtcbn1cblxuQGtleWZyYW1lcyBhIHtcbiAgMCUsIDUwJSB7XG4gICAgdHJhbnNmb3JtOiBzY2FsZSgwKTtcbiAgfVxufVxuLmNlbnRyZV9pdGVtIHtcbiAgbWFyZ2luLXRvcDogMTJyZW07XG59Il19 */"

/***/ }),

/***/ "./src/app/layout/question/question.component.ts":
/*!*******************************************************!*\
  !*** ./src/app/layout/question/question.component.ts ***!
  \*******************************************************/
/*! exports provided: QuestionComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "QuestionComponent", function() { return QuestionComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
/* harmony import */ var ngx_cookie_service__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ngx-cookie-service */ "./node_modules/ngx-cookie-service/ngx-cookie-service.js");
/* harmony import */ var _services_question_service__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ../services/question.service */ "./src/app/layout/services/question.service.ts");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm2015/router.js");
/* harmony import */ var src_app_services_Auth_service__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! src/app/services/Auth.service */ "./src/app/services/Auth.service.ts");






let QuestionComponent = class QuestionComponent {
    constructor(cookie, route, router, questionService, authService) {
        this.cookie = cookie;
        this.route = route;
        this.router = router;
        this.questionService = questionService;
        this.authService = authService;
        this.questionList = [];
        this.isLoad = true;
        this.materialExampleRadios = {};
        this.radioSelected = {};
        this.answerInfo = {};
        this.answerArray = [];
        this.allQuestion = {};
        this.questionFromService = {};
        this.question = {};
        this.gender = {};
        this.answered = {};
        this.showLoader = true;
    }
    ngOnInit() {
        setTimeout(() => {
            this.showLoader = false;
        }, 4000);
        this.route.data.subscribe((data) => {
            this.authService.canUpdateTrials(data.question.trials);
            localStorage.setItem('trials', data.question.trials);
            this.getQuestion(data.question.questionsCollections);
        });
        this.questionService.seconds = 1000;
        this.setTimer();
        this.radioSelected = 'Lamba1';
    }
    setTimer() {
        this.questionService.timer = setInterval(() => {
            this.questionService.seconds--;
            if (this.questionService.seconds === 0) {
                this.submitQuestion();
            }
        }, 1000); // the function will be called after a second
    }
    selectedOption(value, QId) {
        console.log(value, QId);
        const question = this.allQuestion.find(x => x.questionId === QId);
        question.selectedAnswer = value;
        try {
            const values = question.options.find(x => x.checked === true);
            values.checked = false;
            const newValues = question.options.find(x => x.optionId === value);
            newValues.checked = true;
            values.selectedAnswer = newValues.optionId;
        }
        catch (e) {
            const newValues = question.options.find(x => x.optionId === value);
            newValues.checked = true;
            this.radioSelected = newValues.optionName;
        }
    }
    getSelecteditem(QId, optionId) {
        try {
            this.currentQuestion = this.allQuestion.find(x => x.questionNumber === QId);
            this.radioSel = this.currentQuestion.options.find(Item => Item.checked === true);
            this.radioSel.checked = false;
            this.updateRadioSel = this.currentQuestion.options.find(x => x.optionId === optionId);
            this.updateRadioSel.checked = true;
            this.radioSelected = this.updateRadioSel.optionName;
        }
        catch (_a) {
            this.currentQuestion = this.allQuestion.find(x => x.questionNumber === QId);
            this.updateRadioSel = this.currentQuestion.options.find(x => x.optionId === optionId);
            this.updateRadioSel.checked = true;
            this.radioSelected = this.updateRadioSel.optionName;
        }
        this.currentQuestion.selectedAnswer = optionId;
    }
    goTo(QId) {
        try {
            this.currentQuestion = this.allQuestion.find(x => x.questionNumber === QId);
            this.updateRadioSel = this.currentQuestion.options.find(x => x.checked === true);
            this.radioSelected = this.updateRadioSel.optionName;
        }
        catch (e) {
        }
    }
    getQuestion(question) {
        this.questionArray = question;
        this.questionNumber = 1;
        for (let i = 0; i < this.questionArray.length; i++) {
            this.questionArray[i].questionNumber = this.questionNumber;
            this.questionArray[i].selectedAnswer = 0;
            this.questionNumber++;
        }
        this.currentQuestion = this.questionArray[0];
        this.allQuestion = this.questionArray;
    }
    submitQuestion() {
        for (let i = 0; i < this.allQuestion.length; i++) {
            const joko = this.allQuestion[i].questionId;
            // this.answerInfo.questionId = this.allQuestion[i].questionId;
            // this.answerInfo.optionId = this.allQuestion[i].selectedAnswer;
            this.questionId = this.allQuestion[i].questionId;
            this.optionId = this.allQuestion[i].selectedAnswer;
            this.categoryId = this.allQuestion[i].categoryId;
            // this.options.push(this.allQuestion[i].selectedAnswer);
            this.answered.questionId = this.questionId;
            this.answered.optionId = this.optionId;
            this.answered.categoryId = this.categoryId;
            this.answerArray.push(this.answered);
            this.answered = {};
        }
        console.log(this.answerArray);
        this.questionService.Submit(this.answerArray).subscribe((data) => {
        }, error => {
        }, () => {
            this.router.navigate(['/result']);
        });
    }
};
QuestionComponent.ctorParameters = () => [
    { type: ngx_cookie_service__WEBPACK_IMPORTED_MODULE_2__["CookieService"] },
    { type: _angular_router__WEBPACK_IMPORTED_MODULE_4__["ActivatedRoute"] },
    { type: _angular_router__WEBPACK_IMPORTED_MODULE_4__["Router"] },
    { type: _services_question_service__WEBPACK_IMPORTED_MODULE_3__["QuestionService"] },
    { type: src_app_services_Auth_service__WEBPACK_IMPORTED_MODULE_5__["AuthService"] }
];
QuestionComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
        selector: 'app-question',
        template: __webpack_require__(/*! raw-loader!./question.component.html */ "./node_modules/raw-loader/index.js!./src/app/layout/question/question.component.html"),
        styles: [__webpack_require__(/*! ./question.component.scss */ "./src/app/layout/question/question.component.scss")]
    }),
    tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [ngx_cookie_service__WEBPACK_IMPORTED_MODULE_2__["CookieService"],
        _angular_router__WEBPACK_IMPORTED_MODULE_4__["ActivatedRoute"], _angular_router__WEBPACK_IMPORTED_MODULE_4__["Router"], _services_question_service__WEBPACK_IMPORTED_MODULE_3__["QuestionService"], src_app_services_Auth_service__WEBPACK_IMPORTED_MODULE_5__["AuthService"]])
], QuestionComponent);



/***/ }),

/***/ "./src/app/layout/question/question.module.ts":
/*!****************************************************!*\
  !*** ./src/app/layout/question/question.module.ts ***!
  \****************************************************/
/*! exports provided: TokenGetter, QuestionModule */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "TokenGetter", function() { return TokenGetter; });
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "QuestionModule", function() { return QuestionModule; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
/* harmony import */ var _angular_common__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/common */ "./node_modules/@angular/common/fesm2015/common.js");
/* harmony import */ var _question_component__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ./question.component */ "./src/app/layout/question/question.component.ts");
/* harmony import */ var _question_routing_module__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ./question-routing.module */ "./src/app/layout/question/question-routing.module.ts");
/* harmony import */ var _angular_forms__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! @angular/forms */ "./node_modules/@angular/forms/fesm2015/forms.js");
/* harmony import */ var _angular_common_http__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! @angular/common/http */ "./node_modules/@angular/common/fesm2015/http.js");
/* harmony import */ var _services_question_service__WEBPACK_IMPORTED_MODULE_7__ = __webpack_require__(/*! ../services/question.service */ "./src/app/layout/services/question.service.ts");
/* harmony import */ var _auth0_angular_jwt__WEBPACK_IMPORTED_MODULE_8__ = __webpack_require__(/*! @auth0/angular-jwt */ "./node_modules/@auth0/angular-jwt/index.js");
/* harmony import */ var src_app_resolver_question_resolver__WEBPACK_IMPORTED_MODULE_9__ = __webpack_require__(/*! src/app/resolver/question-resolver */ "./src/app/resolver/question-resolver.ts");










function TokenGetter() {
    return localStorage.getItem('token'); // this is the token
}
let QuestionModule = class QuestionModule {
};
QuestionModule = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["NgModule"])({
        imports: [
            _angular_common__WEBPACK_IMPORTED_MODULE_2__["CommonModule"],
            _question_routing_module__WEBPACK_IMPORTED_MODULE_4__["QuestionRoutingModule"],
            _angular_forms__WEBPACK_IMPORTED_MODULE_5__["FormsModule"],
            _angular_forms__WEBPACK_IMPORTED_MODULE_5__["ReactiveFormsModule"],
            _angular_common_http__WEBPACK_IMPORTED_MODULE_6__["HttpClientModule"],
            _auth0_angular_jwt__WEBPACK_IMPORTED_MODULE_8__["JwtModule"].forRoot({
                config: {
                    tokenGetter: TokenGetter,
                    whitelistedDomains: ['adeola-001-site1.atempurl.com'],
                    // it is automatically sending token
                    blacklistedRoutes: ['adeola-001-site1.atempurl.com/api/account'] // we dont want
                    // to send token to this address
                }
            })
        ],
        declarations: [_question_component__WEBPACK_IMPORTED_MODULE_3__["QuestionComponent"]],
        providers: [_services_question_service__WEBPACK_IMPORTED_MODULE_7__["QuestionService"], src_app_resolver_question_resolver__WEBPACK_IMPORTED_MODULE_9__["QuestionResolver"]]
    })
], QuestionModule);



/***/ }),

/***/ "./src/app/resolver/question-resolver.ts":
/*!***********************************************!*\
  !*** ./src/app/resolver/question-resolver.ts ***!
  \***********************************************/
/*! exports provided: QuestionResolver */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "QuestionResolver", function() { return QuestionResolver; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm2015/router.js");
/* harmony import */ var _app_layout_services_question_service__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ../../app/layout/services/question.service */ "./src/app/layout/services/question.service.ts");
/* harmony import */ var rxjs__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! rxjs */ "./node_modules/rxjs/_esm2015/index.js");
/* harmony import */ var rxjs_operators__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! rxjs/operators */ "./node_modules/rxjs/_esm2015/operators/index.js");






let QuestionResolver = class QuestionResolver {
    constructor(questionService, router) {
        this.questionService = questionService;
        this.router = router;
    }
    resolve(route) {
        return this.questionService.GetQuestion(+route.params['id']).pipe(Object(rxjs_operators__WEBPACK_IMPORTED_MODULE_5__["catchError"])(error => {
            this.router.navigate(['/members']);
            return Object(rxjs__WEBPACK_IMPORTED_MODULE_4__["of"])(null);
        }));
    }
};
QuestionResolver.ctorParameters = () => [
    { type: _app_layout_services_question_service__WEBPACK_IMPORTED_MODULE_3__["QuestionService"] },
    { type: _angular_router__WEBPACK_IMPORTED_MODULE_2__["Router"] }
];
QuestionResolver = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Injectable"])(),
    tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [_app_layout_services_question_service__WEBPACK_IMPORTED_MODULE_3__["QuestionService"], _angular_router__WEBPACK_IMPORTED_MODULE_2__["Router"]])
], QuestionResolver);



/***/ })

}]);
//# sourceMappingURL=question-question-module-es2015.js.map