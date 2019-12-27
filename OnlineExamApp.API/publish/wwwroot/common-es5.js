(window["webpackJsonp"] = window["webpackJsonp"] || []).push([["common"],{

/***/ "./src/app/layout/services/question.service.ts":
/*!*****************************************************!*\
  !*** ./src/app/layout/services/question.service.ts ***!
  \*****************************************************/
/*! exports provided: QuestionService */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "QuestionService", function() { return QuestionService; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _questionEnvironment__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ./questionEnvironment */ "./src/app/layout/services/questionEnvironment.ts");
/* harmony import */ var ngx_cookie_service__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ngx-cookie-service */ "./node_modules/ngx-cookie-service/ngx-cookie-service.es5.js");
/* harmony import */ var _angular_common_http__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! @angular/common/http */ "./node_modules/@angular/common/fesm5/http.js");
/* harmony import */ var rxjs_operators__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! rxjs/operators */ "./node_modules/rxjs/_esm5/operators/index.js");






var QuestionService = /** @class */ (function () {
    function QuestionService(cookie, httpClient) {
        this.cookie = cookie;
        this.httpClient = httpClient;
        this.questions = _questionEnvironment__WEBPACK_IMPORTED_MODULE_2__["questionEnviroment"];
        this.cookieValue = [];
        this.question = [];
        this.componentQuestion = {};
        //url = 'http://localhost:5000/api/question/';
        this.prodUrl = 'http://adeola-001-site1.ftempurl.com/api/question';
    }
    QuestionService.prototype.displayTimeElapsed = function () {
        return Math.floor(this.seconds / 3600) + ':' + Math.floor((this.seconds % 3600) / 60) + ':' + Math.floor(this.seconds % 60);
    };
    QuestionService.prototype.getQuestions = function () {
        var j = 1;
        for (var i = 0; i <= this.questions.length - 1; i++) {
            this.questions[i].Question_Number = j;
            j++;
        }
        this.cookie.set('questions', JSON.stringify(this.questions));
        this.question.QuestionList = this.questions;
        this.question.Current = this.questions[0];
        return this.question;
    };
    QuestionService.prototype.GetQuestion = function (categoryId) {
        var tokenId = localStorage.getItem('userId');
        return this.httpClient.get(this.prodUrl + tokenId + '/' + categoryId);
    };
    QuestionService.prototype.getCategories = function () {
        return this.httpClient.get(this.prodUrl);
    };
    QuestionService.prototype.Submit = function (question) {
        var _this = this;
        var tokenId = localStorage.getItem('userId');
        var url = this.prodUrl + tokenId + '/submitTest';
        return this.httpClient.post(this.prodUrl + tokenId + '/submitTest', question).pipe(Object(rxjs_operators__WEBPACK_IMPORTED_MODULE_5__["map"])(function (response) {
            _this.result = response;
            localStorage.setItem('result', _this.result.score);
        }));
    };
    QuestionService.ctorParameters = function () { return [
        { type: ngx_cookie_service__WEBPACK_IMPORTED_MODULE_3__["CookieService"] },
        { type: _angular_common_http__WEBPACK_IMPORTED_MODULE_4__["HttpClient"] }
    ]; };
    QuestionService = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Injectable"])({
            providedIn: 'root'
        }),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [ngx_cookie_service__WEBPACK_IMPORTED_MODULE_3__["CookieService"], _angular_common_http__WEBPACK_IMPORTED_MODULE_4__["HttpClient"]])
    ], QuestionService);
    return QuestionService;
}());



/***/ }),

/***/ "./src/app/layout/services/questionEnvironment.ts":
/*!********************************************************!*\
  !*** ./src/app/layout/services/questionEnvironment.ts ***!
  \********************************************************/
/*! exports provided: questionEnviroment */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "questionEnviroment", function() { return questionEnviroment; });
var questionEnviroment = [
    {
        Question: 'What is the capital of lagos ?',
        Options: [
            {
                isAvailable: 1,
                checked: '0',
                A: 'Oshodi',
            },
            {
                isAvailable: 1,
                checked: '0',
                B: 'Epe',
            },
            {
                isAvailable: 1,
                checked: '0',
                C: 'Lekki',
            },
            {
                isAvailable: 1,
                checked: '0',
                D: 'Lambasa',
            },
            {
                isAvailable: 1,
                checked: '0',
                E: 'Ajah',
            },
        ],
        QID: 3,
        Selected_Answer: '',
        Question_Number: 0
    },
    {
        Question: 'What is the capital of Ogun ?',
        Options: [
            {
                isAvailable: 0,
                checked: '0',
                A: 'Abeokuta',
            },
            {
                isAvailable: 1,
                checked: '0',
                B: 'Sagamu',
            },
            {
                isAvailable: 1,
                checked: '0',
                C: 'Ijebu',
            },
            {
                isAvailable: 1,
                checked: '0',
                D: 'Yewa',
            },
            {
                isAvailable: 1,
                checked: '0',
                E: 'Remo',
            }
        ],
        QID: '2',
        Selected_Answer: '0',
        Question_Number: 0
    },
    {
        Question: 'What is the capital of Oyo?',
        Options: [
            {
                isAvailable: 0,
                checked: '0',
                A: 'Challenge',
            },
            {
                isAvailable: 1,
                isChecked: 0,
                B: 'Apata',
            },
            {
                isAvailable: 1,
                checked: '0',
                C: 'Cocoa House',
            },
            {
                isAvailable: 1,
                checked: '0',
                D: 'Dugbe',
            },
            {
                isAvailable: 1,
                checked: '0',
                E: 'Ibadan',
            }
        ],
        QID: 1,
        Selected_Answer: '0',
        Question_Number: '0'
    },
];


/***/ })

}]);
//# sourceMappingURL=common-es5.js.map