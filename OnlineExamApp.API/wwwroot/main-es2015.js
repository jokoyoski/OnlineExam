(window["webpackJsonp"] = window["webpackJsonp"] || []).push([["main"],{

/***/ "./node_modules/raw-loader/index.js!./src/app/app.component.html":
/*!**************************************************************!*\
  !*** ./node_modules/raw-loader!./src/app/app.component.html ***!
  \**************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "\n\n<router-outlet></router-outlet>\n"

/***/ }),

/***/ "./node_modules/raw-loader/index.js!./src/app/home/home.component.html":
/*!********************************************************************!*\
  !*** ./node_modules/raw-loader!./src/app/home/home.component.html ***!
  \********************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "\n<div class=\"container-fluid\">\n\n  <app-nav></app-nav>\n        <section   class=\"hero-area bg-img bg-overlay-2by5\" class=\"body-image\">\n           \n                <div class=\"container h-100\">\n                    <div class=\"row h-100 align-items-center\">\n                        <div class=\"col-12\">\n                           \n                            <div class=\"hero-area text-center pt-2\">\n                               <!-- Hero Content -->\n                            <img src=\"assets/pp.png\" width=\"300px\" class=\"user-avatar\" />\n                            <h1>T I S A</h1>\n                                <h2 style=\"font-size:30px;\">Let's Study Together</h2>\n                                <a href=\"#\" class=\"btn btn-primary\">GET STARTED</a>\n                            </div>\n                        </div>\n                    </div>\n                </div>\n            </section>\n        \n          \n        \n        \n        \n            <div class=\"row pt-3 texture-image\">\n                               \n                  \n                    <div class=\"card col-12 col-md-4 col-sm-4\" style=\"width: 18rem;\">\n                            <img class=\"card-img-top\" src=\"../../assets/english1.jfif\" alt=\"Card image cap\">\n                            <div class=\"card-body\">\n                              <h5 class=\"card-title\">Biology</h5>\n                              <p class=\"card-text\">Quick sample text to create the card title and make up the body of the card's content.</p>\n                              <a href=\"#\" class=\"btn btn-primary\">Go somewhere</a>\n                            </div>\n                          </div>\n                       \n                          <div class=\"card col-12 col-md-4 col-sm-4\" style=\"width: 18rem;\">\n                                <img class=\"card-img-top\" src=\"../../assets/pe.jpg\" alt=\"Card image cap\">\n                                <div class=\"card-body\">\n                                  <h5 class=\"card-title\">Physical Education</h5>\n                                  <p class=\"card-text\">Quick sample text to create the card title and make up the body of the card's content.</p>\n                                  <a href=\"#\" class=\"btn btn-primary\">Go somewhere</a>\n                                </div>\n                              </div>\n                             \n                              <div class=\"card col-12 col-md-4 col-sm-4\" style=\"width: 18rem;\">\n                                    <img class=\"card-img-top\" src=\"../../assets/math.jpg\" alt=\"Card image cap\">\n                                    <div class=\"card-body\">\n                                      <h5 class=\"card-title\">Mathematics</h5>\n                                      <p class=\"card-text\">Quick sample text to create the card title and make up the body of the card's content.</p>\n                                      <a href=\"#\" class=\"btn btn-primary\">Go somewhere</a>\n                                    </div>\n                                  </div>\n                                 \n                \n            </div>\n        \n        \n      \n</div>\n    "

/***/ }),

/***/ "./node_modules/raw-loader/index.js!./src/app/login/login.component.html":
/*!**********************************************************************!*\
  !*** ./node_modules/raw-loader!./src/app/login/login.component.html ***!
  \**********************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<app-nav></app-nav>\n<div class=\"container-fluid\">\n      \n        \n              \n           \n              \n        \n    <div class=\"login-page body-image\">\n        <div class=\"row justify-content-md-center\">\n            <div class=\"col-md-4\">\n                <div  class=\"pt-3\"style=\"text-align:center\">\n                        <img src=\"assets/pp.png\" width=\"400px\" class=\"user-avatar\" />\n                        <h1 style=\"color: white;\">Online Exam Center</h1>\n                </div>\n               \n                <form [formGroup]=\"loginForm\" (ngSubmit)=\"login(loginForm)\">\n                    <div class=\"form-content\">\n                        \n    \n                            <div class=\"form-group\">\n                                    <input type=\"email\" [ngClass]=\"{'is-invalid': loginForm.get('username').errors && loginForm.get('username').touched }\"  formControlName=\"username\" class=\"form-control input-underline input-lg\" id=\"\" placeholder=\"{{ 'Email' | translate }}\">\n                                    <div class=\"invalid-feedback\">Please  input a correct Email </div>\n                                </div><div class=\"form-group\">\n                                        <input type=\"password\" [ngClass]=\"{'is-invalid': loginForm.get('password').errors && loginForm.get('password').touched }\"  formControlName=\"password\" class=\"form-control input-underline input-lg\" id=\"\" placeholder=\"{{ 'Password' | translate }}\">\n                                        <div class=\"invalid-feedback\">Please  input a correct password </div>\n                                    </div> \n                    </div>\n                    <div style=\"text-align: center;\">\n                            <button [disabled]=\"!loginForm.valid\" class=\"btn btn-primary my-2 my-sm-0\" type=\"submit\">Submit</button>\n             \n                    </div>\n                      \n                   \n                </form>\n            </div>\n        </div>\n    </div>\n    \n</div>\n        \n\n\n\n"

/***/ }),

/***/ "./node_modules/raw-loader/index.js!./src/app/nav/nav.component.html":
/*!******************************************************************!*\
  !*** ./node_modules/raw-loader!./src/app/nav/nav.component.html ***!
  \******************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<nav class=\"navbar navbar-expand-lg navbar-light bg-light\">\n    <a class=\"navbar-brand\" href=\"#\"><img width=\"80\" src=\"../../assets/pp.jpeg\"/></a>\n    <button class=\"navbar-toggler\" type=\"button\" data-toggle=\"collapse\" data-target=\"#navbarSupportedContent\" aria-controls=\"navbarSupportedContent\" aria-expanded=\"false\" aria-label=\"Toggle navigation\">\n      <span class=\"navbar-toggler-icon\"></span>\n    </button>\n   \n    <div class=\"collapse navbar-collapse\" id=\"navbarSupportedContent\">\n      <ul class=\"navbar-nav mr-auto\">\n        <li class=\"nav-item active\">\n          <a class=\"nav-link\" [routerLink]=\"['/home']\">Home <span class=\"sr-only\">(current)</span></a>\n        </li>\n      \n        <li class=\"nav-item\">\n          <a class=\"nav-link\" href=\"\">About</a>\n        </li>\n      \n        <li class=\"nav-item\">\n            <a class=\"nav-link\" href=\"#\">Contact Us</a>\n          </li>\n       \n       \n      </ul>\n    \n        <button [routerLink]=\"['/signup']\" class=\"btn btn-primary my-2 my-sm-0\" type=\"submit\">REGISTER</button>\n        &nbsp; &nbsp;\n        <button [routerLink]=\"['/login']\" class=\"btn btn-primary my-2 my-sm-0\" type=\"submit\">LOGIN</button>\n    \n    </div>\n  </nav>"

/***/ }),

/***/ "./node_modules/raw-loader/index.js!./src/app/shared/modules/page-header/page-header.component.html":
/*!*************************************************************************************************!*\
  !*** ./node_modules/raw-loader!./src/app/shared/modules/page-header/page-header.component.html ***!
  \*************************************************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<div class=\"row\">\n    <div class=\"col-xl-12\">\n        <h2 class=\"page-header\">\n            {{heading}}\n        </h2>\n        <ol class=\"breadcrumb\">\n            <li class=\"breadcrumb-item\">\n                <i class=\"fa fa-dashboard\"></i> <a href=\"Javascript:void(0)\" [routerLink]=\"['/dashboard']\">Dashboard</a>\n            </li>\n            <li class=\"breadcrumb-item active\"><i class=\"fa {{icon}}\"></i> {{heading}}</li>\n        </ol>\n    </div>\n</div>\n"

/***/ }),

/***/ "./node_modules/raw-loader/index.js!./src/app/shared/modules/stat/stat.component.html":
/*!***********************************************************************************!*\
  !*** ./node_modules/raw-loader!./src/app/shared/modules/stat/stat.component.html ***!
  \***********************************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<div class=\"card text-white bg-{{bgClass}}\">\n    <div class=\"card-header\">\n        <div class=\"row\">\n            <div class=\"col col-xs-3\">\n                <i class=\"fa {{icon}} fa-5x\"></i>\n            </div>\n            <div class=\"col col-xs-9 text-right\">\n                <div class=\"d-block huge\">{{count}}</div>\n                <div class=\"d-block\">{{label}}</div>\n            </div>\n        </div>\n    </div>\n    <div class=\"card-footer\">\n        <span class=\"float-left\">View Details {{data}}</span>\n        <a href=\"javascript:void(0)\" class=\"float-right card-inverse\">\n            <span ><i class=\"fa fa-arrow-circle-right\"></i></span>\n        </a>\n    </div>\n</div>\n"

/***/ }),

/***/ "./node_modules/raw-loader/index.js!./src/app/signup/signup.component.html":
/*!************************************************************************!*\
  !*** ./node_modules/raw-loader!./src/app/signup/signup.component.html ***!
  \************************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "\n<app-nav></app-nav>\n<div class=\"container-fluid\">\n        \n          \n       \n          \n\n    <div class=\"login-page body-image\">\n    <div  class=\"row justify-content-md-center\">\n        <div class=\"col-md-4\">\n            \n                <div class=\"pt-5\" style=\"text-align:center\">\n                        \n                        <h1 style=\"color: white;\">Online Exam Center</h1>\n                </div>\n           \n            <form [formGroup]=\"registerForm\" (ngSubmit)=\"register(registerForm)\">\n                <div class=\"form-content\">\n                        <div class=\"form-group\">\n                                <input type=\"text\" [ngClass]=\"{'is-invalid': registerForm.get('firstName').errors && registerForm.get('firstName').touched }\"  formControlName=\"firstName\" class=\"form-control input-underline input-lg\" id=\"\" placeholder=\"{{ 'First Name' | translate }}\">\n                                <div class=\"invalid-feedback\">Please  input a correct name </div>\n                            </div>\n                        <div class=\"form-group\">\n                                <input type=\"text\" [ngClass]=\"{'is-invalid': registerForm.get('lastName').errors && registerForm.get('lastName').touched }\"  formControlName=\"lastName\" class=\"form-control input-underline input-lg\" id=\"\" placeholder=\"{{ 'Last Name' | translate }}\">\n                                <div class=\"invalid-feedback\">Please  input the correct last Name </div>\n                            </div>\n                        <div class=\"form-group\">\n                                <input type=\"email\" [ngClass]=\"{'is-invalid': registerForm.get('email').errors && registerForm.get('email').touched }\"  formControlName=\"email\" class=\"form-control input-underline input-lg\" id=\"\" placeholder=\"{{ 'Email' | translate }}\">\n                                <div class=\"invalid-feedback\">Please choose an email </div>\n                            </div>\n                           \n                    <div class=\"form-group\">\n                        <input type=\"password\" [ngClass]=\"{'is-invalid': registerForm.get('password').errors && registerForm.get('password').touched }\"  formControlName=\"password\" class=\"form-control input-underline input-lg\" id=\"\" placeholder=\"{{ 'Password' | translate }}\">\n                        <div class=\"invalid-feedback\" *ngIf=\"{'is-invalid': registerForm.get('password').hasError('required') && registerForm.get('password').touched }\">Please choose a Correct Password</div>\n                        <div class=\"invalid-feedback\" *ngIf=\"{'is-invalid': registerForm.get('password').hasError('minLength') && registerForm.get('password').touched }\">Please choose a Minimum of 6 characters</div>\n                     \n                     \n                    </div>\n                    <div class=\"form-group\">\n                            <input type=\"password\" [ngClass]=\"{'is-invalid': registerForm.get('confirmPassword').errors && registerForm.get('confirmPassword').touched }\"  formControlName=\"confirmPassword\" class=\"form-control input-underline input-lg\" id=\"\" placeholder=\"{{ 'Confirm Password' | translate }}\">\n                            <div class=\"invalid-feedback\" *ngIf=\"registerForm.get('confirmPassword').hasError('required') && registerForm.get('confirmPassword').touched \">Please fill in the blanks</div>\n                            <div class=\"invalid-feedback\" *ngIf=\"registerForm.get('confirmPassword').hasError('mismatch') && registerForm.get('confirmPassword').touched \">Password must match</div>\n                    \n                        </div>\n                                  <div class=\"form-group\">\n                                        <input [ngClass]=\"{'is-invalid': registerForm.get('dateOfBirth').errors && registerForm.get('dateOfBirth').touched}\" class=\"form-control\"\n                                          placeholder=\"Date of Birth\" formControlName=\"dateOfBirth\" type=\"date\" >\n                                        <div class=\"invalid-feedback\" *ngIf=\"registerForm.get('dateOfBirth').touched && registerForm.get('dateOfBirth').hasError('required')\">Date of Birth is required</div>\n                                      </div>\n\n                   \n\n                  \n                </div>\n                <div style=\"text-align: center;\">\n                        <button [disabled]=\"!registerForm.valid\" class=\"btn btn-primary my-2 my-sm-0\" type=\"submit\">REGISTER </button>\n             \n                </div>\n               \n                \n            </form>\n        </div>\n    </div>\n</div>\n</div>"

/***/ }),

/***/ "./src/$$_lazy_route_resource lazy recursive":
/*!**********************************************************!*\
  !*** ./src/$$_lazy_route_resource lazy namespace object ***!
  \**********************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

function webpackEmptyAsyncContext(req) {
	// Here Promise.resolve().then() is used instead of new Promise() to prevent
	// uncaught exception popping up in devtools
	return Promise.resolve().then(function() {
		var e = new Error("Cannot find module '" + req + "'");
		e.code = 'MODULE_NOT_FOUND';
		throw e;
	});
}
webpackEmptyAsyncContext.keys = function() { return []; };
webpackEmptyAsyncContext.resolve = webpackEmptyAsyncContext;
module.exports = webpackEmptyAsyncContext;
webpackEmptyAsyncContext.id = "./src/$$_lazy_route_resource lazy recursive";

/***/ }),

/***/ "./src/app/_directives/role.directive.ts":
/*!***********************************************!*\
  !*** ./src/app/_directives/role.directive.ts ***!
  \***********************************************/
/*! exports provided: RoleDirective */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "RoleDirective", function() { return RoleDirective; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
/* harmony import */ var _services_Auth_service__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ../services/Auth.service */ "./src/app/services/Auth.service.ts");



let RoleDirective = class RoleDirective {
    constructor(viewContaierRef, templateRef, authService) {
        this.viewContaierRef = viewContaierRef;
        this.templateRef = templateRef;
        this.authService = authService;
        this.isVisible = false;
    }
    ngInit() {
        const userRoles = this.authService.decodedToken.role;
        if (!userRoles) {
            this.viewContaierRef.clear();
        }
        if (this.authService.roleMatch(this.appRole)) {
            if (!this.isVisible) {
                this.isVisible = true;
                this.viewContaierRef.createEmbeddedView(this.templateRef);
            }
            else {
                this.isVisible = false;
                this.viewContaierRef.clear();
            }
        }
    }
};
RoleDirective.ctorParameters = () => [
    { type: _angular_core__WEBPACK_IMPORTED_MODULE_1__["ViewContainerRef"] },
    { type: _angular_core__WEBPACK_IMPORTED_MODULE_1__["TemplateRef"] },
    { type: _services_Auth_service__WEBPACK_IMPORTED_MODULE_2__["AuthService"] }
];
tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Input"])(),
    tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:type", Array)
], RoleDirective.prototype, "appRole", void 0);
RoleDirective = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Directive"])({
        selector: '[appRole]'
    }),
    tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [_angular_core__WEBPACK_IMPORTED_MODULE_1__["ViewContainerRef"], _angular_core__WEBPACK_IMPORTED_MODULE_1__["TemplateRef"], _services_Auth_service__WEBPACK_IMPORTED_MODULE_2__["AuthService"]])
], RoleDirective);



/***/ }),

/***/ "./src/app/app-routing.module.ts":
/*!***************************************!*\
  !*** ./src/app/app-routing.module.ts ***!
  \***************************************/
/*! exports provided: AppRoutingModule */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "AppRoutingModule", function() { return AppRoutingModule; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm2015/router.js");
/* harmony import */ var _shared__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ./shared */ "./src/app/shared/index.ts");
/* harmony import */ var _login_login_component__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ./login/login.component */ "./src/app/login/login.component.ts");
/* harmony import */ var _home_home_component__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ./home/home.component */ "./src/app/home/home.component.ts");
/* harmony import */ var _signup_signup_component__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! ./signup/signup.component */ "./src/app/signup/signup.component.ts");







const routes = [
    { path: '', loadChildren: () => __webpack_require__.e(/*! import() | layout-layout-module */ "layout-layout-module").then(__webpack_require__.bind(null, /*! ./layout/layout.module */ "./src/app/layout/layout.module.ts")).then(m => m.LayoutModule), canActivate: [_shared__WEBPACK_IMPORTED_MODULE_3__["AuthGuard"]] },
    {
        path: 'login',
        component: _login_login_component__WEBPACK_IMPORTED_MODULE_4__["LoginComponent"]
    },
    {
        path: 'home',
        component: _home_home_component__WEBPACK_IMPORTED_MODULE_5__["HomeComponent"]
    },
    {
        path: 'signup',
        component: _signup_signup_component__WEBPACK_IMPORTED_MODULE_6__["SignupComponent"]
    },
    //   { path: 'login', loadChildren: () => import('./login/login.module').then(m => m.LoginModule) },
    //  { path: 'home', loadChildren: () => import('./home/home.module').then(m => m.HomeModule) },
    //  { path: 'signup', loadChildren: () => import('./signup/signup.module').then(m => m.SignupModule) },
    { path: 'error', loadChildren: () => __webpack_require__.e(/*! import() | server-error-server-error-module */ "server-error-server-error-module").then(__webpack_require__.bind(null, /*! ./server-error/server-error.module */ "./src/app/server-error/server-error.module.ts")).then(m => m.ServerErrorModule) },
    { path: 'access-denied', loadChildren: () => __webpack_require__.e(/*! import() | access-denied-access-denied-module */ "access-denied-access-denied-module").then(__webpack_require__.bind(null, /*! ./access-denied/access-denied.module */ "./src/app/access-denied/access-denied.module.ts")).then(m => m.AccessDeniedModule) },
    { path: 'not-found', loadChildren: () => __webpack_require__.e(/*! import() | not-found-not-found-module */ "not-found-not-found-module").then(__webpack_require__.bind(null, /*! ./not-found/not-found.module */ "./src/app/not-found/not-found.module.ts")).then(m => m.NotFoundModule) },
    { path: '**', redirectTo: 'dashboard' }
];
let AppRoutingModule = class AppRoutingModule {
};
AppRoutingModule = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["NgModule"])({
        imports: [_angular_router__WEBPACK_IMPORTED_MODULE_2__["RouterModule"].forRoot(routes)],
        exports: [_angular_router__WEBPACK_IMPORTED_MODULE_2__["RouterModule"]]
    })
], AppRoutingModule);



/***/ }),

/***/ "./src/app/app.component.scss":
/*!************************************!*\
  !*** ./src/app/app.component.scss ***!
  \************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = ".loader {\n  border: 16px solid lightgray;\n  border-top: 16px solid blue;\n  border-radius: 50%;\n  width: 120px;\n  height: 120px;\n  -webkit-animation: spin 2s linear infinite;\n          animation: spin 2s linear infinite;\n  top: 50%;\n  position: fixed;\n  left: 50%;\n  margin-top: -9em;\n  margin-left: -15em;\n}\n\n@-webkit-keyframes spin {\n  0% {\n    -webkit-transform: rotate(0deg);\n            transform: rotate(0deg);\n  }\n  100% {\n    -webkit-transform: rotate(360deg);\n            transform: rotate(360deg);\n  }\n}\n\n@keyframes spin {\n  0% {\n    -webkit-transform: rotate(0deg);\n            transform: rotate(0deg);\n  }\n  100% {\n    -webkit-transform: rotate(360deg);\n            transform: rotate(360deg);\n  }\n}\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbIi9Vc2Vycy9tYWMvUHJvamVjdHMvT25saW5lRXhhbS9PbmxpbmVFeGFtQXBwLVNQQS9zcmMvYXBwL2FwcC5jb21wb25lbnQuc2NzcyIsInNyYy9hcHAvYXBwLmNvbXBvbmVudC5zY3NzIl0sIm5hbWVzIjpbXSwibWFwcGluZ3MiOiJBQUNBO0VBQ0EsNEJBQUE7RUFDQSwyQkFBQTtFQUNBLGtCQUFBO0VBQ0EsWUFBQTtFQUNBLGFBQUE7RUFDQSwwQ0FBQTtVQUFBLGtDQUFBO0VBQ0EsUUFBQTtFQUNBLGVBQUE7RUFDQSxTQUFBO0VBQ0EsZ0JBQUE7RUFDQSxrQkFBQTtBQ0FBOztBRElBO0VBQ0E7SUFBRywrQkFBQTtZQUFBLHVCQUFBO0VDQUQ7RURDRjtJQUFLLGlDQUFBO1lBQUEseUJBQUE7RUNFSDtBQUNGOztBRExBO0VBQ0E7SUFBRywrQkFBQTtZQUFBLHVCQUFBO0VDQUQ7RURDRjtJQUFLLGlDQUFBO1lBQUEseUJBQUE7RUNFSDtBQUNGIiwiZmlsZSI6InNyYy9hcHAvYXBwLmNvbXBvbmVudC5zY3NzIiwic291cmNlc0NvbnRlbnQiOlsiXG4ubG9hZGVye1xuYm9yZGVyOjE2cHggc29saWQgbGlnaHRncmF5O1xuYm9yZGVyLXRvcDogMTZweCBzb2xpZCBibHVlO1xuYm9yZGVyLXJhZGl1czogNTAlO1xud2lkdGg6IDEyMHB4O1xuaGVpZ2h0OiAxMjBweDtcbmFuaW1hdGlvbjogc3BpbiAycyBsaW5lYXIgaW5maW5pdGU7XG50b3A6IDUwJTtcbnBvc2l0aW9uOiBmaXhlZDtcbmxlZnQ6IDUwJTtcbm1hcmdpbi10b3A6IC05ZW07XG5tYXJnaW4tbGVmdDogLTE1ZW07XG5cblxufVxuQGtleWZyYW1lcyBzcGlue1xuMCV7dHJhbnNmb3JtOiByb3RhdGUoMGRlZyk7fVxuMTAwJXt0cmFuc2Zvcm06IHJvdGF0ZSgzNjBkZWcpO31cbn0iLCIubG9hZGVyIHtcbiAgYm9yZGVyOiAxNnB4IHNvbGlkIGxpZ2h0Z3JheTtcbiAgYm9yZGVyLXRvcDogMTZweCBzb2xpZCBibHVlO1xuICBib3JkZXItcmFkaXVzOiA1MCU7XG4gIHdpZHRoOiAxMjBweDtcbiAgaGVpZ2h0OiAxMjBweDtcbiAgYW5pbWF0aW9uOiBzcGluIDJzIGxpbmVhciBpbmZpbml0ZTtcbiAgdG9wOiA1MCU7XG4gIHBvc2l0aW9uOiBmaXhlZDtcbiAgbGVmdDogNTAlO1xuICBtYXJnaW4tdG9wOiAtOWVtO1xuICBtYXJnaW4tbGVmdDogLTE1ZW07XG59XG5cbkBrZXlmcmFtZXMgc3BpbiB7XG4gIDAlIHtcbiAgICB0cmFuc2Zvcm06IHJvdGF0ZSgwZGVnKTtcbiAgfVxuICAxMDAlIHtcbiAgICB0cmFuc2Zvcm06IHJvdGF0ZSgzNjBkZWcpO1xuICB9XG59Il19 */"

/***/ }),

/***/ "./src/app/app.component.ts":
/*!**********************************!*\
  !*** ./src/app/app.component.ts ***!
  \**********************************/
/*! exports provided: AppComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "AppComponent", function() { return AppComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");


let AppComponent = class AppComponent {
    constructor() {
    }
    ngOnInit() {
    }
};
AppComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
        selector: 'app-root',
        template: __webpack_require__(/*! raw-loader!./app.component.html */ "./node_modules/raw-loader/index.js!./src/app/app.component.html"),
        styles: [__webpack_require__(/*! ./app.component.scss */ "./src/app/app.component.scss")]
    }),
    tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [])
], AppComponent);



/***/ }),

/***/ "./src/app/app.module.ts":
/*!*******************************!*\
  !*** ./src/app/app.module.ts ***!
  \*******************************/
/*! exports provided: AppModule */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "AppModule", function() { return AppModule; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_common__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/common */ "./node_modules/@angular/common/fesm2015/common.js");
/* harmony import */ var _angular_common_http__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/common/http */ "./node_modules/@angular/common/fesm2015/http.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
/* harmony import */ var _angular_platform_browser__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! @angular/platform-browser */ "./node_modules/@angular/platform-browser/fesm2015/platform-browser.js");
/* harmony import */ var _angular_platform_browser_animations__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! @angular/platform-browser/animations */ "./node_modules/@angular/platform-browser/fesm2015/animations.js");
/* harmony import */ var _shared_modules_language_translation_language_translation_module__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! ./shared/modules/language-translation/language-translation.module */ "./src/app/shared/modules/language-translation/language-translation.module.ts");
/* harmony import */ var _app_routing_module__WEBPACK_IMPORTED_MODULE_7__ = __webpack_require__(/*! ./app-routing.module */ "./src/app/app-routing.module.ts");
/* harmony import */ var _app_component__WEBPACK_IMPORTED_MODULE_8__ = __webpack_require__(/*! ./app.component */ "./src/app/app.component.ts");
/* harmony import */ var _shared__WEBPACK_IMPORTED_MODULE_9__ = __webpack_require__(/*! ./shared */ "./src/app/shared/index.ts");
/* harmony import */ var ngx_cookie_service__WEBPACK_IMPORTED_MODULE_10__ = __webpack_require__(/*! ngx-cookie-service */ "./node_modules/ngx-cookie-service/ngx-cookie-service.js");
/* harmony import */ var _services_AlertifyService__WEBPACK_IMPORTED_MODULE_11__ = __webpack_require__(/*! ./services/AlertifyService */ "./src/app/services/AlertifyService.ts");
/* harmony import */ var _services_error_Interceptor__WEBPACK_IMPORTED_MODULE_12__ = __webpack_require__(/*! ./services/error.Interceptor */ "./src/app/services/error.Interceptor.ts");
/* harmony import */ var _directives_role_directive__WEBPACK_IMPORTED_MODULE_13__ = __webpack_require__(/*! ./_directives/role.directive */ "./src/app/_directives/role.directive.ts");
/* harmony import */ var _login_login_component__WEBPACK_IMPORTED_MODULE_14__ = __webpack_require__(/*! ./login/login.component */ "./src/app/login/login.component.ts");
/* harmony import */ var _home_home_component__WEBPACK_IMPORTED_MODULE_15__ = __webpack_require__(/*! ./home/home.component */ "./src/app/home/home.component.ts");
/* harmony import */ var _angular_forms__WEBPACK_IMPORTED_MODULE_16__ = __webpack_require__(/*! @angular/forms */ "./node_modules/@angular/forms/fesm2015/forms.js");
/* harmony import */ var _signup_signup_component__WEBPACK_IMPORTED_MODULE_17__ = __webpack_require__(/*! ./signup/signup.component */ "./src/app/signup/signup.component.ts");
/* harmony import */ var _nav_nav_component__WEBPACK_IMPORTED_MODULE_18__ = __webpack_require__(/*! ./nav/nav.component */ "./src/app/nav/nav.component.ts");



















let AppModule = class AppModule {
};
AppModule = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_3__["NgModule"])({
        imports: [
            _angular_common__WEBPACK_IMPORTED_MODULE_1__["CommonModule"],
            _angular_platform_browser__WEBPACK_IMPORTED_MODULE_4__["BrowserModule"],
            _angular_platform_browser_animations__WEBPACK_IMPORTED_MODULE_5__["BrowserAnimationsModule"],
            _angular_common_http__WEBPACK_IMPORTED_MODULE_2__["HttpClientModule"],
            _shared_modules_language_translation_language_translation_module__WEBPACK_IMPORTED_MODULE_6__["LanguageTranslationModule"],
            _app_routing_module__WEBPACK_IMPORTED_MODULE_7__["AppRoutingModule"],
            _angular_forms__WEBPACK_IMPORTED_MODULE_16__["ReactiveFormsModule"],
            _angular_forms__WEBPACK_IMPORTED_MODULE_16__["FormsModule"]
        ],
        declarations: [
            _app_component__WEBPACK_IMPORTED_MODULE_8__["AppComponent"],
            _login_login_component__WEBPACK_IMPORTED_MODULE_14__["LoginComponent"],
            _home_home_component__WEBPACK_IMPORTED_MODULE_15__["HomeComponent"],
            _signup_signup_component__WEBPACK_IMPORTED_MODULE_17__["SignupComponent"],
            _nav_nav_component__WEBPACK_IMPORTED_MODULE_18__["NavComponent"]
        ],
        providers: [
            _shared__WEBPACK_IMPORTED_MODULE_9__["AuthGuard"],
            ngx_cookie_service__WEBPACK_IMPORTED_MODULE_10__["CookieService"],
            _services_AlertifyService__WEBPACK_IMPORTED_MODULE_11__["AlertifyService"],
            _services_error_Interceptor__WEBPACK_IMPORTED_MODULE_12__["ErrorInterceptorProvider"],
            _directives_role_directive__WEBPACK_IMPORTED_MODULE_13__["RoleDirective"]
        ],
        bootstrap: [
            _app_component__WEBPACK_IMPORTED_MODULE_8__["AppComponent"]
        ]
    })
], AppModule);



/***/ }),

/***/ "./src/app/home/home.component.scss":
/*!******************************************!*\
  !*** ./src/app/home/home.component.scss ***!
  \******************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "body {\n  font-family: \"Open Sans\", sans-serif;\n}\n\n.body-image {\n  background-image: url('tisa2.jpeg');\n  background-attachment: fixed;\n  height: 500px;\n}\n\n.texture-image {\n  background-image: url('texture.png');\n  background-attachment: relative;\n  height: 300px;\n}\n\n.hero-area {\n  font-size: 40px;\n  margin-bottom: 30px;\n  font-weight: 700;\n  color: white;\n}\n\n.collapse-content .fa.fa-heart:hover {\n  color: #f44336 !important;\n}\n\n.collapse-content .fa.fa-share-alt:hover {\n  color: #0d47a1 !important;\n}\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbIi9Vc2Vycy9tYWMvUHJvamVjdHMvT25saW5lRXhhbS9PbmxpbmVFeGFtQXBwLVNQQS9zcmMvYXBwL2hvbWUvaG9tZS5jb21wb25lbnQuc2NzcyIsInNyYy9hcHAvaG9tZS9ob21lLmNvbXBvbmVudC5zY3NzIl0sIm5hbWVzIjpbXSwibWFwcGluZ3MiOiJBQUNBO0VBQ0csb0NBQUE7QUNBSDs7QURHQTtFQUNJLG1DQUFBO0VBQ0EsNEJBQUE7RUFDQSxhQUFBO0FDQUo7O0FES0E7RUFDSSxvQ0FBQTtFQUNBLCtCQUFBO0VBQ0EsYUFBQTtBQ0ZKOztBRE1BO0VBQ0ksZUFBQTtFQUNBLG1CQUFBO0VBQ0EsZ0JBQUE7RUFDQSxZQUFBO0FDSEo7O0FEU0E7RUFDSSx5QkFBQTtBQ05KOztBRFFFO0VBQ0UseUJBQUE7QUNMSiIsImZpbGUiOiJzcmMvYXBwL2hvbWUvaG9tZS5jb21wb25lbnQuc2NzcyIsInNvdXJjZXNDb250ZW50IjpbIlxyXG5ib2R5e1xyXG4gICBmb250LWZhbWlseTogXCJPcGVuIFNhbnNcIiwgc2Fucy1zZXJpZjtcclxufVxyXG5cclxuLmJvZHktaW1hZ2V7XHJcbiAgICBiYWNrZ3JvdW5kLWltYWdlOiB1cmwoJy4uLy4uL2Fzc2V0cy90aXNhMi5qcGVnJyk7XHJcbiAgICBiYWNrZ3JvdW5kLWF0dGFjaG1lbnQ6IGZpeGVkO1xyXG4gICAgaGVpZ2h0OiA1MDBweDtcclxufVxyXG5cclxuXHJcblxyXG4udGV4dHVyZS1pbWFnZXtcclxuICAgIGJhY2tncm91bmQtaW1hZ2U6IHVybCgnLi4vLi4vYXNzZXRzL3RleHR1cmUucG5nJyk7XHJcbiAgICBiYWNrZ3JvdW5kLWF0dGFjaG1lbnQ6IHJlbGF0aXZlO1xyXG4gICAgaGVpZ2h0OiAzMDBweDtcclxufVxyXG5cclxuXHJcbi5oZXJvLWFyZWF7XHJcbiAgICBmb250LXNpemU6NDBweDtcclxuICAgIG1hcmdpbi1ib3R0b206MzBweDtcclxuICAgIGZvbnQtd2VpZ2h0OiA3MDA7XHJcbiAgICBjb2xvcjp3aGl0ZTtcclxuXHJcbn1cclxuXHJcblxyXG5cclxuLmNvbGxhcHNlLWNvbnRlbnQgLmZhLmZhLWhlYXJ0OmhvdmVyIHtcclxuICAgIGNvbG9yOiAjZjQ0MzM2ICFpbXBvcnRhbnQ7XHJcbiAgfVxyXG4gIC5jb2xsYXBzZS1jb250ZW50IC5mYS5mYS1zaGFyZS1hbHQ6aG92ZXIge1xyXG4gICAgY29sb3I6ICMwZDQ3YTEgIWltcG9ydGFudDtcclxuICB9XHJcbiAgIiwiYm9keSB7XG4gIGZvbnQtZmFtaWx5OiBcIk9wZW4gU2Fuc1wiLCBzYW5zLXNlcmlmO1xufVxuXG4uYm9keS1pbWFnZSB7XG4gIGJhY2tncm91bmQtaW1hZ2U6IHVybChcIi4uLy4uL2Fzc2V0cy90aXNhMi5qcGVnXCIpO1xuICBiYWNrZ3JvdW5kLWF0dGFjaG1lbnQ6IGZpeGVkO1xuICBoZWlnaHQ6IDUwMHB4O1xufVxuXG4udGV4dHVyZS1pbWFnZSB7XG4gIGJhY2tncm91bmQtaW1hZ2U6IHVybChcIi4uLy4uL2Fzc2V0cy90ZXh0dXJlLnBuZ1wiKTtcbiAgYmFja2dyb3VuZC1hdHRhY2htZW50OiByZWxhdGl2ZTtcbiAgaGVpZ2h0OiAzMDBweDtcbn1cblxuLmhlcm8tYXJlYSB7XG4gIGZvbnQtc2l6ZTogNDBweDtcbiAgbWFyZ2luLWJvdHRvbTogMzBweDtcbiAgZm9udC13ZWlnaHQ6IDcwMDtcbiAgY29sb3I6IHdoaXRlO1xufVxuXG4uY29sbGFwc2UtY29udGVudCAuZmEuZmEtaGVhcnQ6aG92ZXIge1xuICBjb2xvcjogI2Y0NDMzNiAhaW1wb3J0YW50O1xufVxuXG4uY29sbGFwc2UtY29udGVudCAuZmEuZmEtc2hhcmUtYWx0OmhvdmVyIHtcbiAgY29sb3I6ICMwZDQ3YTEgIWltcG9ydGFudDtcbn0iXX0= */"

/***/ }),

/***/ "./src/app/home/home.component.ts":
/*!****************************************!*\
  !*** ./src/app/home/home.component.ts ***!
  \****************************************/
/*! exports provided: HomeComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "HomeComponent", function() { return HomeComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");


let HomeComponent = class HomeComponent {
    constructor() { }
    ngOnInit() {
    }
};
HomeComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
        selector: 'app-home',
        template: __webpack_require__(/*! raw-loader!./home.component.html */ "./node_modules/raw-loader/index.js!./src/app/home/home.component.html"),
        styles: [__webpack_require__(/*! ./home.component.scss */ "./src/app/home/home.component.scss")]
    }),
    tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [])
], HomeComponent);



/***/ }),

/***/ "./src/app/login/login.component.scss":
/*!********************************************!*\
  !*** ./src/app/login/login.component.scss ***!
  \********************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = ".body-image {\n  background-image: url('tisa2.jpeg');\n  background-attachment: fixed;\n  height: 800px;\n}\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbIi9Vc2Vycy9tYWMvUHJvamVjdHMvT25saW5lRXhhbS9PbmxpbmVFeGFtQXBwLVNQQS9zcmMvYXBwL2xvZ2luL2xvZ2luLmNvbXBvbmVudC5zY3NzIiwic3JjL2FwcC9sb2dpbi9sb2dpbi5jb21wb25lbnQuc2NzcyJdLCJuYW1lcyI6W10sIm1hcHBpbmdzIjoiQUFHQTtFQUNJLG1DQUFBO0VBQ0EsNEJBQUE7RUFDQSxhQUFBO0FDRkoiLCJmaWxlIjoic3JjL2FwcC9sb2dpbi9sb2dpbi5jb21wb25lbnQuc2NzcyIsInNvdXJjZXNDb250ZW50IjpbIlxuXG5cbi5ib2R5LWltYWdle1xuICAgIGJhY2tncm91bmQtaW1hZ2U6IHVybCgnLi4vLi4vYXNzZXRzL3Rpc2EyLmpwZWcnKTtcbiAgICBiYWNrZ3JvdW5kLWF0dGFjaG1lbnQ6IGZpeGVkO1xuICAgIGhlaWdodDogODAwcHg7XG59IiwiLmJvZHktaW1hZ2Uge1xuICBiYWNrZ3JvdW5kLWltYWdlOiB1cmwoXCIuLi8uLi9hc3NldHMvdGlzYTIuanBlZ1wiKTtcbiAgYmFja2dyb3VuZC1hdHRhY2htZW50OiBmaXhlZDtcbiAgaGVpZ2h0OiA4MDBweDtcbn0iXX0= */"

/***/ }),

/***/ "./src/app/login/login.component.ts":
/*!******************************************!*\
  !*** ./src/app/login/login.component.ts ***!
  \******************************************/
/*! exports provided: LoginComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "LoginComponent", function() { return LoginComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm2015/router.js");
/* harmony import */ var _router_animations__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ../router.animations */ "./src/app/router.animations.ts");
/* harmony import */ var _services_Auth_service__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ../services/Auth.service */ "./src/app/services/Auth.service.ts");
/* harmony import */ var _angular_forms__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! @angular/forms */ "./node_modules/@angular/forms/fesm2015/forms.js");
/* harmony import */ var _services_AlertifyService__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! ../services/AlertifyService */ "./src/app/services/AlertifyService.ts");







let LoginComponent = class LoginComponent {
    constructor(authService, alertifyService, router) {
        this.authService = authService;
        this.alertifyService = alertifyService;
        this.router = router;
        this.model = {};
    }
    ngOnInit() {
        this.loginForm = new _angular_forms__WEBPACK_IMPORTED_MODULE_5__["FormGroup"]({
            username: new _angular_forms__WEBPACK_IMPORTED_MODULE_5__["FormControl"]('', _angular_forms__WEBPACK_IMPORTED_MODULE_5__["Validators"].required),
            password: new _angular_forms__WEBPACK_IMPORTED_MODULE_5__["FormControl"]('', _angular_forms__WEBPACK_IMPORTED_MODULE_5__["Validators"].required),
        });
    }
    login() {
        if (this.loginForm.valid) {
            this.model = Object.assign({}, this.loginForm.value);
        }
        this.authService.login(this.model).subscribe(value => value, (error) => {
            this.alertifyService.error(error);
        }, () => {
            this.router.navigate(['']);
        });
    }
    onLoggedin() {
        localStorage.setItem('isLoggedin', 'true');
    }
};
LoginComponent.ctorParameters = () => [
    { type: _services_Auth_service__WEBPACK_IMPORTED_MODULE_4__["AuthService"] },
    { type: _services_AlertifyService__WEBPACK_IMPORTED_MODULE_6__["AlertifyService"] },
    { type: _angular_router__WEBPACK_IMPORTED_MODULE_2__["Router"] }
];
LoginComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
        selector: 'app-login',
        template: __webpack_require__(/*! raw-loader!./login.component.html */ "./node_modules/raw-loader/index.js!./src/app/login/login.component.html"),
        animations: [Object(_router_animations__WEBPACK_IMPORTED_MODULE_3__["routerTransition"])()],
        styles: [__webpack_require__(/*! ./login.component.scss */ "./src/app/login/login.component.scss")]
    }),
    tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [_services_Auth_service__WEBPACK_IMPORTED_MODULE_4__["AuthService"],
        _services_AlertifyService__WEBPACK_IMPORTED_MODULE_6__["AlertifyService"], _angular_router__WEBPACK_IMPORTED_MODULE_2__["Router"]])
], LoginComponent);



/***/ }),

/***/ "./src/app/nav/nav.component.scss":
/*!****************************************!*\
  !*** ./src/app/nav/nav.component.scss ***!
  \****************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJzcmMvYXBwL25hdi9uYXYuY29tcG9uZW50LnNjc3MifQ== */"

/***/ }),

/***/ "./src/app/nav/nav.component.ts":
/*!**************************************!*\
  !*** ./src/app/nav/nav.component.ts ***!
  \**************************************/
/*! exports provided: NavComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "NavComponent", function() { return NavComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");


let NavComponent = class NavComponent {
    constructor() { }
    ngOnInit() {
    }
};
NavComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
        selector: 'app-nav',
        template: __webpack_require__(/*! raw-loader!./nav.component.html */ "./node_modules/raw-loader/index.js!./src/app/nav/nav.component.html"),
        styles: [__webpack_require__(/*! ./nav.component.scss */ "./src/app/nav/nav.component.scss")]
    }),
    tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [])
], NavComponent);



/***/ }),

/***/ "./src/app/router.animations.ts":
/*!**************************************!*\
  !*** ./src/app/router.animations.ts ***!
  \**************************************/
/*! exports provided: routerTransition, noTransition, slideToRight, slideToLeft, slideToBottom, slideToTop */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "routerTransition", function() { return routerTransition; });
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "noTransition", function() { return noTransition; });
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "slideToRight", function() { return slideToRight; });
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "slideToLeft", function() { return slideToLeft; });
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "slideToBottom", function() { return slideToBottom; });
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "slideToTop", function() { return slideToTop; });
/* harmony import */ var _angular_animations__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/animations */ "./node_modules/@angular/animations/fesm2015/animations.js");

function routerTransition() {
    return noTransition();
}
function noTransition() {
    return Object(_angular_animations__WEBPACK_IMPORTED_MODULE_0__["trigger"])('routerTransition', []);
}
function slideToRight() {
    return Object(_angular_animations__WEBPACK_IMPORTED_MODULE_0__["trigger"])('routerTransition', [
        Object(_angular_animations__WEBPACK_IMPORTED_MODULE_0__["state"])('void', Object(_angular_animations__WEBPACK_IMPORTED_MODULE_0__["style"])({})),
        Object(_angular_animations__WEBPACK_IMPORTED_MODULE_0__["state"])('*', Object(_angular_animations__WEBPACK_IMPORTED_MODULE_0__["style"])({})),
        Object(_angular_animations__WEBPACK_IMPORTED_MODULE_0__["transition"])(':enter', [
            Object(_angular_animations__WEBPACK_IMPORTED_MODULE_0__["style"])({ transform: 'translateX(-100%)' }),
            Object(_angular_animations__WEBPACK_IMPORTED_MODULE_0__["animate"])('0.5s ease-in-out', Object(_angular_animations__WEBPACK_IMPORTED_MODULE_0__["style"])({ transform: 'translateX(0%)' }))
        ]),
        Object(_angular_animations__WEBPACK_IMPORTED_MODULE_0__["transition"])(':leave', [
            Object(_angular_animations__WEBPACK_IMPORTED_MODULE_0__["style"])({ transform: 'translateX(0%)' }),
            Object(_angular_animations__WEBPACK_IMPORTED_MODULE_0__["animate"])('0.5s ease-in-out', Object(_angular_animations__WEBPACK_IMPORTED_MODULE_0__["style"])({ transform: 'translateX(100%)' }))
        ])
    ]);
}
function slideToLeft() {
    return Object(_angular_animations__WEBPACK_IMPORTED_MODULE_0__["trigger"])('routerTransition', [
        Object(_angular_animations__WEBPACK_IMPORTED_MODULE_0__["state"])('void', Object(_angular_animations__WEBPACK_IMPORTED_MODULE_0__["style"])({})),
        Object(_angular_animations__WEBPACK_IMPORTED_MODULE_0__["state"])('*', Object(_angular_animations__WEBPACK_IMPORTED_MODULE_0__["style"])({})),
        Object(_angular_animations__WEBPACK_IMPORTED_MODULE_0__["transition"])(':enter', [
            Object(_angular_animations__WEBPACK_IMPORTED_MODULE_0__["style"])({ transform: 'translateX(100%)' }),
            Object(_angular_animations__WEBPACK_IMPORTED_MODULE_0__["animate"])('0.5s ease-in-out', Object(_angular_animations__WEBPACK_IMPORTED_MODULE_0__["style"])({ transform: 'translateX(0%)' }))
        ]),
        Object(_angular_animations__WEBPACK_IMPORTED_MODULE_0__["transition"])(':leave', [
            Object(_angular_animations__WEBPACK_IMPORTED_MODULE_0__["style"])({ transform: 'translateX(0%)' }),
            Object(_angular_animations__WEBPACK_IMPORTED_MODULE_0__["animate"])('0.5s ease-in-out', Object(_angular_animations__WEBPACK_IMPORTED_MODULE_0__["style"])({ transform: 'translateX(-100%)' }))
        ])
    ]);
}
function slideToBottom() {
    return Object(_angular_animations__WEBPACK_IMPORTED_MODULE_0__["trigger"])('routerTransition', [
        Object(_angular_animations__WEBPACK_IMPORTED_MODULE_0__["state"])('void', Object(_angular_animations__WEBPACK_IMPORTED_MODULE_0__["style"])({})),
        Object(_angular_animations__WEBPACK_IMPORTED_MODULE_0__["state"])('*', Object(_angular_animations__WEBPACK_IMPORTED_MODULE_0__["style"])({})),
        Object(_angular_animations__WEBPACK_IMPORTED_MODULE_0__["transition"])(':enter', [
            Object(_angular_animations__WEBPACK_IMPORTED_MODULE_0__["style"])({ transform: 'translateY(-100%)' }),
            Object(_angular_animations__WEBPACK_IMPORTED_MODULE_0__["animate"])('0.5s ease-in-out', Object(_angular_animations__WEBPACK_IMPORTED_MODULE_0__["style"])({ transform: 'translateY(0%)' }))
        ]),
        Object(_angular_animations__WEBPACK_IMPORTED_MODULE_0__["transition"])(':leave', [
            Object(_angular_animations__WEBPACK_IMPORTED_MODULE_0__["style"])({ transform: 'translateY(0%)' }),
            Object(_angular_animations__WEBPACK_IMPORTED_MODULE_0__["animate"])('0.5s ease-in-out', Object(_angular_animations__WEBPACK_IMPORTED_MODULE_0__["style"])({ transform: 'translateY(100%)' }))
        ])
    ]);
}
function slideToTop() {
    return Object(_angular_animations__WEBPACK_IMPORTED_MODULE_0__["trigger"])('routerTransition', [
        Object(_angular_animations__WEBPACK_IMPORTED_MODULE_0__["state"])('void', Object(_angular_animations__WEBPACK_IMPORTED_MODULE_0__["style"])({})),
        Object(_angular_animations__WEBPACK_IMPORTED_MODULE_0__["state"])('*', Object(_angular_animations__WEBPACK_IMPORTED_MODULE_0__["style"])({})),
        Object(_angular_animations__WEBPACK_IMPORTED_MODULE_0__["transition"])(':enter', [
            Object(_angular_animations__WEBPACK_IMPORTED_MODULE_0__["style"])({ transform: 'translateY(100%)' }),
            Object(_angular_animations__WEBPACK_IMPORTED_MODULE_0__["animate"])('0.5s ease-in-out', Object(_angular_animations__WEBPACK_IMPORTED_MODULE_0__["style"])({ transform: 'translateY(0%)' }))
        ]),
        Object(_angular_animations__WEBPACK_IMPORTED_MODULE_0__["transition"])(':leave', [
            Object(_angular_animations__WEBPACK_IMPORTED_MODULE_0__["style"])({ transform: 'translateY(0%)' }),
            Object(_angular_animations__WEBPACK_IMPORTED_MODULE_0__["animate"])('0.5s ease-in-out', Object(_angular_animations__WEBPACK_IMPORTED_MODULE_0__["style"])({ transform: 'translateY(-100%)' }))
        ])
    ]);
}


/***/ }),

/***/ "./src/app/services/AlertifyService.ts":
/*!*********************************************!*\
  !*** ./src/app/services/AlertifyService.ts ***!
  \*********************************************/
/*! exports provided: AlertifyService */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "AlertifyService", function() { return AlertifyService; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");


let AlertifyService = class AlertifyService {
    constructor() { }
    confirm(message, okCallback) {
        alertify.confirm(message, function (e) {
            if (e) {
                okCallback();
            }
            else { }
        });
    }
    success(message) {
        alertify.success(message);
    }
    error(message) {
        alertify.error(message);
    }
    warning(message) {
        alertify.warning(message);
    }
};
AlertifyService = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Injectable"])({
        providedIn: 'root'
    }),
    tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [])
], AlertifyService);



/***/ }),

/***/ "./src/app/services/Auth.service.ts":
/*!******************************************!*\
  !*** ./src/app/services/Auth.service.ts ***!
  \******************************************/
/*! exports provided: AuthService */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "AuthService", function() { return AuthService; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
/* harmony import */ var _angular_common_http__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/common/http */ "./node_modules/@angular/common/fesm2015/http.js");
/* harmony import */ var rxjs_operators__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! rxjs/operators */ "./node_modules/rxjs/_esm2015/operators/index.js");
/* harmony import */ var rxjs__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! rxjs */ "./node_modules/rxjs/_esm2015/index.js");
/* harmony import */ var _auth0_angular_jwt__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! @auth0/angular-jwt */ "./node_modules/@auth0/angular-jwt/index.js");






let AuthService = class AuthService {
    constructor(http) {
        this.http = http;
        this.pic = '../../assets/web/images/user.png';
        this.trials = new rxjs__WEBPACK_IMPORTED_MODULE_4__["BehaviorSubject"]('0');
        this.currentTrials = this.trials.asObservable();
        this.jwtHelper = new _auth0_angular_jwt__WEBPACK_IMPORTED_MODULE_5__["JwtHelperService"]();
        // URL = 'http://localhost:5000/api/';
        this.prodUrl = 'http://adeola-001-site1.atempurl.com/api/';
    }
    canUpdateTrials(trials) {
        this.trials.next(trials); // the behaviour subject has a next attr which signifies the next value
    }
    login(model) {
        return this.http.post(this.prodUrl + 'account/login', model)
            .pipe(Object(rxjs_operators__WEBPACK_IMPORTED_MODULE_3__["map"])((response) => {
            this.result = response;
            if (this.result) {
                localStorage.setItem('token', this.result.token);
                this.decodedToken = this.jwtHelper.decodeToken(this.result.token); // decoding token
                localStorage.setItem('userId', this.decodedToken.nameid);
                localStorage.setItem('userName', this.decodedToken.unique_name);
                localStorage.setItem('givenName', this.decodedToken.given_name);
                localStorage.setItem('trials', this.decodedToken.primarysid);
                this.canUpdateTrials(localStorage.getItem('trials'));
                this.decodedTokenName = this.decodedToken.unique_name;
            }
        }));
    }
    register(model) {
        return this.http.post(this.prodUrl + 'account/register', model);
    }
    getProgress() {
        const tokenId = localStorage.getItem('userId');
        return this.http.get(this.prodUrl + 'user/' + tokenId);
    }
    loggedIn() {
        const token = localStorage.getItem('token');
        const tokens = this.jwtHelper.isTokenExpired(token);
        if (tokens === false) {
            return true;
        }
        return false;
    }
    Submit(question) {
        const tokenId = localStorage.getItem('userId');
        return this.http.post(this.prodUrl + 'question/' + tokenId + '/submitTest', question).pipe(Object(rxjs_operators__WEBPACK_IMPORTED_MODULE_3__["map"])((response) => {
            this.result = response;
            localStorage.setItem('result', this.result);
        }));
    }
    GetProgress(categoryId) {
        const tokenId = localStorage.getItem('userId');
        return this.http.get(this.prodUrl + 'user/' + tokenId + '/' + categoryId.category);
    }
    roleMatch(allowedRoles) {
        let isMatch = false;
        const userRoles = this.decodedToken.role;
        allowedRoles.forEach(element => {
            if (userRoles.includes(element)) {
                isMatch = true;
            }
        });
        return isMatch;
    }
};
AuthService.ctorParameters = () => [
    { type: _angular_common_http__WEBPACK_IMPORTED_MODULE_2__["HttpClient"] }
];
AuthService = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Injectable"])({
        providedIn: 'root'
    }),
    tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [_angular_common_http__WEBPACK_IMPORTED_MODULE_2__["HttpClient"]])
], AuthService);



/***/ }),

/***/ "./src/app/services/error.Interceptor.ts":
/*!***********************************************!*\
  !*** ./src/app/services/error.Interceptor.ts ***!
  \***********************************************/
/*! exports provided: ErrorInterceptor, ErrorInterceptorProvider */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "ErrorInterceptor", function() { return ErrorInterceptor; });
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "ErrorInterceptorProvider", function() { return ErrorInterceptorProvider; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
/* harmony import */ var _angular_common_http__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/common/http */ "./node_modules/@angular/common/fesm2015/http.js");
/* harmony import */ var rxjs__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! rxjs */ "./node_modules/rxjs/_esm2015/index.js");
/* harmony import */ var rxjs_operators__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! rxjs/operators */ "./node_modules/rxjs/_esm2015/operators/index.js");





let ErrorInterceptor = class ErrorInterceptor {
    intercept(req, next) {
        return next.handle(req).pipe(Object(rxjs_operators__WEBPACK_IMPORTED_MODULE_4__["catchError"])(error => {
            if (error instanceof _angular_common_http__WEBPACK_IMPORTED_MODULE_2__["HttpErrorResponse"]) {
                const applicationError = error.headers.get('Application-Error');
                {
                    if (applicationError) {
                        console.error(applicationError);
                        return Object(rxjs__WEBPACK_IMPORTED_MODULE_3__["throwError"])(applicationError);
                    }
                }
                const serverError = error.error;
                let modelStateError = '';
                if (serverError && typeof serverError === 'object') {
                    for (const key in serverError) {
                        if (serverError[key]) {
                            modelStateError += serverError[key] + '\n';
                        }
                    }
                }
                return Object(rxjs__WEBPACK_IMPORTED_MODULE_3__["throwError"])(modelStateError || serverError || 'ServerError');
            }
        }));
    }
};
ErrorInterceptor = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Injectable"])()
], ErrorInterceptor);

const ErrorInterceptorProvider = {
    provide: _angular_common_http__WEBPACK_IMPORTED_MODULE_2__["HTTP_INTERCEPTORS"],
    useClass: ErrorInterceptor,
    multi: true,
};


/***/ }),

/***/ "./src/app/shared/guard/auth.guard.ts":
/*!********************************************!*\
  !*** ./src/app/shared/guard/auth.guard.ts ***!
  \********************************************/
/*! exports provided: AuthGuard */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "AuthGuard", function() { return AuthGuard; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm2015/router.js");
/* harmony import */ var src_app_services_Auth_service__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! src/app/services/Auth.service */ "./src/app/services/Auth.service.ts");
/* harmony import */ var src_app_services_AlertifyService__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! src/app/services/AlertifyService */ "./src/app/services/AlertifyService.ts");





let AuthGuard = class AuthGuard {
    constructor(authService, router, alertify) {
        this.authService = authService;
        this.router = router;
        this.alertify = alertify;
    }
    canActivate() {
        if (this.authService.loggedIn()) {
            return true;
        }
        this.router.navigate(['/home']);
    }
};
AuthGuard.ctorParameters = () => [
    { type: src_app_services_Auth_service__WEBPACK_IMPORTED_MODULE_3__["AuthService"] },
    { type: _angular_router__WEBPACK_IMPORTED_MODULE_2__["Router"] },
    { type: src_app_services_AlertifyService__WEBPACK_IMPORTED_MODULE_4__["AlertifyService"] }
];
AuthGuard = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Injectable"])(),
    tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [src_app_services_Auth_service__WEBPACK_IMPORTED_MODULE_3__["AuthService"],
        _angular_router__WEBPACK_IMPORTED_MODULE_2__["Router"], src_app_services_AlertifyService__WEBPACK_IMPORTED_MODULE_4__["AlertifyService"]])
], AuthGuard);



/***/ }),

/***/ "./src/app/shared/guard/index.ts":
/*!***************************************!*\
  !*** ./src/app/shared/guard/index.ts ***!
  \***************************************/
/*! exports provided: AuthGuard */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var _auth_guard__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ./auth.guard */ "./src/app/shared/guard/auth.guard.ts");
/* harmony reexport (safe) */ __webpack_require__.d(__webpack_exports__, "AuthGuard", function() { return _auth_guard__WEBPACK_IMPORTED_MODULE_0__["AuthGuard"]; });




/***/ }),

/***/ "./src/app/shared/index.ts":
/*!*********************************!*\
  !*** ./src/app/shared/index.ts ***!
  \*********************************/
/*! exports provided: SharedPipesModule, PageHeaderModule, StatModule, AuthGuard */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var _modules__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ./modules */ "./src/app/shared/modules/index.ts");
/* harmony reexport (safe) */ __webpack_require__.d(__webpack_exports__, "PageHeaderModule", function() { return _modules__WEBPACK_IMPORTED_MODULE_0__["PageHeaderModule"]; });

/* harmony reexport (safe) */ __webpack_require__.d(__webpack_exports__, "StatModule", function() { return _modules__WEBPACK_IMPORTED_MODULE_0__["StatModule"]; });

/* harmony import */ var _pipes_shared_pipes_module__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ./pipes/shared-pipes.module */ "./src/app/shared/pipes/shared-pipes.module.ts");
/* harmony reexport (safe) */ __webpack_require__.d(__webpack_exports__, "SharedPipesModule", function() { return _pipes_shared_pipes_module__WEBPACK_IMPORTED_MODULE_1__["SharedPipesModule"]; });

/* harmony import */ var _guard__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ./guard */ "./src/app/shared/guard/index.ts");
/* harmony reexport (safe) */ __webpack_require__.d(__webpack_exports__, "AuthGuard", function() { return _guard__WEBPACK_IMPORTED_MODULE_2__["AuthGuard"]; });






/***/ }),

/***/ "./src/app/shared/modules/index.ts":
/*!*****************************************!*\
  !*** ./src/app/shared/modules/index.ts ***!
  \*****************************************/
/*! exports provided: PageHeaderModule, StatModule */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var _page_header_page_header_module__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ./page-header/page-header.module */ "./src/app/shared/modules/page-header/page-header.module.ts");
/* harmony reexport (safe) */ __webpack_require__.d(__webpack_exports__, "PageHeaderModule", function() { return _page_header_page_header_module__WEBPACK_IMPORTED_MODULE_0__["PageHeaderModule"]; });

/* harmony import */ var _stat_stat_module__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ./stat/stat.module */ "./src/app/shared/modules/stat/stat.module.ts");
/* harmony reexport (safe) */ __webpack_require__.d(__webpack_exports__, "StatModule", function() { return _stat_stat_module__WEBPACK_IMPORTED_MODULE_1__["StatModule"]; });





/***/ }),

/***/ "./src/app/shared/modules/language-translation/language-translation.module.ts":
/*!************************************************************************************!*\
  !*** ./src/app/shared/modules/language-translation/language-translation.module.ts ***!
  \************************************************************************************/
/*! exports provided: HttpLoaderFactory, LanguageTranslationModule */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "HttpLoaderFactory", function() { return HttpLoaderFactory; });
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "LanguageTranslationModule", function() { return LanguageTranslationModule; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
/* harmony import */ var _angular_common_http__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/common/http */ "./node_modules/@angular/common/fesm2015/http.js");
/* harmony import */ var _ngx_translate_core__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @ngx-translate/core */ "./node_modules/@ngx-translate/core/fesm2015/ngx-translate-core.js");
/* harmony import */ var _ngx_translate_http_loader__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! @ngx-translate/http-loader */ "./node_modules/@ngx-translate/http-loader/fesm2015/ngx-translate-http-loader.js");

/**
 * This module is used to language translations.
 * The translations are saved in a json file in /src/app/assets/i18n directory
 * Docs: https://www.codeandweb.com/babeledit/tutorials/how-to-translate-your-angular7-app-with-ngx-translate
 */


// import ngx-translate and the http loader


// ngx-translate - required for AOT compilation
function HttpLoaderFactory(http) {
    return new _ngx_translate_http_loader__WEBPACK_IMPORTED_MODULE_4__["TranslateHttpLoader"](http);
}
let LanguageTranslationModule = class LanguageTranslationModule {
    constructor(translate) {
        this.translate = translate;
        // Gets Default language from browser if available, otherwise set English ad default
        this.translate.addLangs(['en', 'fr', 'ur', 'es', 'it', 'fa', 'de', 'zh-CHS']);
        this.translate.setDefaultLang('en');
        const browserLang = this.translate.getBrowserLang();
        this.translate.use(browserLang.match(/en|fr|ur|es|it|fa|de|zh-CHS/) ? browserLang : 'en');
    }
};
LanguageTranslationModule.ctorParameters = () => [
    { type: _ngx_translate_core__WEBPACK_IMPORTED_MODULE_3__["TranslateService"] }
];
LanguageTranslationModule = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["NgModule"])({
        declarations: [],
        imports: [
            _ngx_translate_core__WEBPACK_IMPORTED_MODULE_3__["TranslateModule"].forRoot({
                loader: {
                    provide: _ngx_translate_core__WEBPACK_IMPORTED_MODULE_3__["TranslateLoader"],
                    useFactory: HttpLoaderFactory,
                    deps: [_angular_common_http__WEBPACK_IMPORTED_MODULE_2__["HttpClient"]]
                }
            })
        ],
        exports: [
            _ngx_translate_core__WEBPACK_IMPORTED_MODULE_3__["TranslateModule"]
        ],
    }),
    tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [_ngx_translate_core__WEBPACK_IMPORTED_MODULE_3__["TranslateService"]])
], LanguageTranslationModule);



/***/ }),

/***/ "./src/app/shared/modules/page-header/page-header.component.scss":
/*!***********************************************************************!*\
  !*** ./src/app/shared/modules/page-header/page-header.component.scss ***!
  \***********************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJzcmMvYXBwL3NoYXJlZC9tb2R1bGVzL3BhZ2UtaGVhZGVyL3BhZ2UtaGVhZGVyLmNvbXBvbmVudC5zY3NzIn0= */"

/***/ }),

/***/ "./src/app/shared/modules/page-header/page-header.component.ts":
/*!*********************************************************************!*\
  !*** ./src/app/shared/modules/page-header/page-header.component.ts ***!
  \*********************************************************************/
/*! exports provided: PageHeaderComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "PageHeaderComponent", function() { return PageHeaderComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");


let PageHeaderComponent = class PageHeaderComponent {
    constructor() { }
    ngOnInit() { }
};
tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Input"])(),
    tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:type", String)
], PageHeaderComponent.prototype, "heading", void 0);
tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Input"])(),
    tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:type", String)
], PageHeaderComponent.prototype, "icon", void 0);
PageHeaderComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
        selector: 'app-page-header',
        template: __webpack_require__(/*! raw-loader!./page-header.component.html */ "./node_modules/raw-loader/index.js!./src/app/shared/modules/page-header/page-header.component.html"),
        styles: [__webpack_require__(/*! ./page-header.component.scss */ "./src/app/shared/modules/page-header/page-header.component.scss")]
    }),
    tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [])
], PageHeaderComponent);



/***/ }),

/***/ "./src/app/shared/modules/page-header/page-header.module.ts":
/*!******************************************************************!*\
  !*** ./src/app/shared/modules/page-header/page-header.module.ts ***!
  \******************************************************************/
/*! exports provided: PageHeaderModule */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "PageHeaderModule", function() { return PageHeaderModule; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
/* harmony import */ var _angular_common__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/common */ "./node_modules/@angular/common/fesm2015/common.js");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm2015/router.js");
/* harmony import */ var _page_header_component__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ./page-header.component */ "./src/app/shared/modules/page-header/page-header.component.ts");





let PageHeaderModule = class PageHeaderModule {
};
PageHeaderModule = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["NgModule"])({
        imports: [_angular_common__WEBPACK_IMPORTED_MODULE_2__["CommonModule"], _angular_router__WEBPACK_IMPORTED_MODULE_3__["RouterModule"]],
        declarations: [_page_header_component__WEBPACK_IMPORTED_MODULE_4__["PageHeaderComponent"]],
        exports: [_page_header_component__WEBPACK_IMPORTED_MODULE_4__["PageHeaderComponent"]]
    })
], PageHeaderModule);



/***/ }),

/***/ "./src/app/shared/modules/stat/stat.component.scss":
/*!*********************************************************!*\
  !*** ./src/app/shared/modules/stat/stat.component.scss ***!
  \*********************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJzcmMvYXBwL3NoYXJlZC9tb2R1bGVzL3N0YXQvc3RhdC5jb21wb25lbnQuc2NzcyJ9 */"

/***/ }),

/***/ "./src/app/shared/modules/stat/stat.component.ts":
/*!*******************************************************!*\
  !*** ./src/app/shared/modules/stat/stat.component.ts ***!
  \*******************************************************/
/*! exports provided: StatComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "StatComponent", function() { return StatComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");


let StatComponent = class StatComponent {
    constructor() {
        this.event = new _angular_core__WEBPACK_IMPORTED_MODULE_1__["EventEmitter"]();
    }
    ngOnInit() { }
};
tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Input"])(),
    tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:type", String)
], StatComponent.prototype, "bgClass", void 0);
tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Input"])(),
    tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:type", String)
], StatComponent.prototype, "icon", void 0);
tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Input"])(),
    tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:type", Number)
], StatComponent.prototype, "count", void 0);
tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Input"])(),
    tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:type", String)
], StatComponent.prototype, "label", void 0);
tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Input"])(),
    tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:type", Number)
], StatComponent.prototype, "data", void 0);
tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Output"])(),
    tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:type", _angular_core__WEBPACK_IMPORTED_MODULE_1__["EventEmitter"])
], StatComponent.prototype, "event", void 0);
StatComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
        selector: 'app-stat',
        template: __webpack_require__(/*! raw-loader!./stat.component.html */ "./node_modules/raw-loader/index.js!./src/app/shared/modules/stat/stat.component.html"),
        styles: [__webpack_require__(/*! ./stat.component.scss */ "./src/app/shared/modules/stat/stat.component.scss")]
    }),
    tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [])
], StatComponent);



/***/ }),

/***/ "./src/app/shared/modules/stat/stat.module.ts":
/*!****************************************************!*\
  !*** ./src/app/shared/modules/stat/stat.module.ts ***!
  \****************************************************/
/*! exports provided: StatModule */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "StatModule", function() { return StatModule; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
/* harmony import */ var _angular_common__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/common */ "./node_modules/@angular/common/fesm2015/common.js");
/* harmony import */ var _stat_component__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ./stat.component */ "./src/app/shared/modules/stat/stat.component.ts");




let StatModule = class StatModule {
};
StatModule = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["NgModule"])({
        imports: [_angular_common__WEBPACK_IMPORTED_MODULE_2__["CommonModule"]],
        declarations: [_stat_component__WEBPACK_IMPORTED_MODULE_3__["StatComponent"]],
        exports: [_stat_component__WEBPACK_IMPORTED_MODULE_3__["StatComponent"]]
    })
], StatModule);



/***/ }),

/***/ "./src/app/shared/pipes/shared-pipes.module.ts":
/*!*****************************************************!*\
  !*** ./src/app/shared/pipes/shared-pipes.module.ts ***!
  \*****************************************************/
/*! exports provided: SharedPipesModule */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "SharedPipesModule", function() { return SharedPipesModule; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
/* harmony import */ var _angular_common__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/common */ "./node_modules/@angular/common/fesm2015/common.js");



let SharedPipesModule = class SharedPipesModule {
};
SharedPipesModule = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["NgModule"])({
        imports: [
            _angular_common__WEBPACK_IMPORTED_MODULE_2__["CommonModule"]
        ],
        declarations: []
    })
], SharedPipesModule);



/***/ }),

/***/ "./src/app/signup/signup.component.scss":
/*!**********************************************!*\
  !*** ./src/app/signup/signup.component.scss ***!
  \**********************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = ".body-image {\n  background-image: url('tisa2.jpeg');\n  background-attachment: fixed;\n  height: 800px;\n}\n\n.loader {\n  border: 16px solid lightgray;\n  border-top: 16px solid blue;\n  border-radius: 50%;\n  width: 120px;\n  height: 120px;\n  -webkit-animation: spin 2s linear infinite;\n          animation: spin 2s linear infinite;\n  top: 50%;\n  position: fixed;\n  left: 50%;\n  margin-top: -9em;\n  margin-left: -15em;\n}\n\n@-webkit-keyframes spin {\n  0% {\n    -webkit-transform: rotate(0deg);\n            transform: rotate(0deg);\n  }\n  100% {\n    -webkit-transform: rotate(360deg);\n            transform: rotate(360deg);\n  }\n}\n\n@keyframes spin {\n  0% {\n    -webkit-transform: rotate(0deg);\n            transform: rotate(0deg);\n  }\n  100% {\n    -webkit-transform: rotate(360deg);\n            transform: rotate(360deg);\n  }\n}\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbIi9Vc2Vycy9tYWMvUHJvamVjdHMvT25saW5lRXhhbS9PbmxpbmVFeGFtQXBwLVNQQS9zcmMvYXBwL3NpZ251cC9zaWdudXAuY29tcG9uZW50LnNjc3MiLCJzcmMvYXBwL3NpZ251cC9zaWdudXAuY29tcG9uZW50LnNjc3MiXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IkFBSUE7RUFDSSxtQ0FBQTtFQUNBLDRCQUFBO0VBQ0EsYUFBQTtBQ0hKOztBRE1BO0VBQ0ksNEJBQUE7RUFDQSwyQkFBQTtFQUNBLGtCQUFBO0VBQ0EsWUFBQTtFQUNBLGFBQUE7RUFDQSwwQ0FBQTtVQUFBLGtDQUFBO0VBQ0EsUUFBQTtFQUNBLGVBQUE7RUFDQSxTQUFBO0VBQ0EsZ0JBQUE7RUFDQSxrQkFBQTtBQ0hKOztBRE9JO0VBQ0E7SUFBRywrQkFBQTtZQUFBLHVCQUFBO0VDSEw7RURJRTtJQUFLLGlDQUFBO1lBQUEseUJBQUE7RUNEUDtBQUNGOztBREZJO0VBQ0E7SUFBRywrQkFBQTtZQUFBLHVCQUFBO0VDSEw7RURJRTtJQUFLLGlDQUFBO1lBQUEseUJBQUE7RUNEUDtBQUNGIiwiZmlsZSI6InNyYy9hcHAvc2lnbnVwL3NpZ251cC5jb21wb25lbnQuc2NzcyIsInNvdXJjZXNDb250ZW50IjpbIlxuXG5cblxuLmJvZHktaW1hZ2V7XG4gICAgYmFja2dyb3VuZC1pbWFnZTogdXJsKCcuLi8uLi9hc3NldHMvdGlzYTIuanBlZycpO1xuICAgIGJhY2tncm91bmQtYXR0YWNobWVudDogZml4ZWQ7XG4gICAgaGVpZ2h0OiA4MDBweDtcbn1cblxuLmxvYWRlcntcbiAgICBib3JkZXI6MTZweCBzb2xpZCBsaWdodGdyYXk7XG4gICAgYm9yZGVyLXRvcDogMTZweCBzb2xpZCBibHVlO1xuICAgIGJvcmRlci1yYWRpdXM6IDUwJTtcbiAgICB3aWR0aDogMTIwcHg7XG4gICAgaGVpZ2h0OiAxMjBweDtcbiAgICBhbmltYXRpb246IHNwaW4gMnMgbGluZWFyIGluZmluaXRlO1xuICAgIHRvcDogNTAlO1xuICAgIHBvc2l0aW9uOiBmaXhlZDtcbiAgICBsZWZ0OiA1MCU7XG4gICAgbWFyZ2luLXRvcDogLTllbTtcbiAgICBtYXJnaW4tbGVmdDogLTE1ZW07XG4gICAgXG4gICAgXG4gICAgfVxuICAgIEBrZXlmcmFtZXMgc3BpbntcbiAgICAwJXt0cmFuc2Zvcm06IHJvdGF0ZSgwZGVnKTt9XG4gICAgMTAwJXt0cmFuc2Zvcm06IHJvdGF0ZSgzNjBkZWcpO31cbiAgICB9IiwiLmJvZHktaW1hZ2Uge1xuICBiYWNrZ3JvdW5kLWltYWdlOiB1cmwoXCIuLi8uLi9hc3NldHMvdGlzYTIuanBlZ1wiKTtcbiAgYmFja2dyb3VuZC1hdHRhY2htZW50OiBmaXhlZDtcbiAgaGVpZ2h0OiA4MDBweDtcbn1cblxuLmxvYWRlciB7XG4gIGJvcmRlcjogMTZweCBzb2xpZCBsaWdodGdyYXk7XG4gIGJvcmRlci10b3A6IDE2cHggc29saWQgYmx1ZTtcbiAgYm9yZGVyLXJhZGl1czogNTAlO1xuICB3aWR0aDogMTIwcHg7XG4gIGhlaWdodDogMTIwcHg7XG4gIGFuaW1hdGlvbjogc3BpbiAycyBsaW5lYXIgaW5maW5pdGU7XG4gIHRvcDogNTAlO1xuICBwb3NpdGlvbjogZml4ZWQ7XG4gIGxlZnQ6IDUwJTtcbiAgbWFyZ2luLXRvcDogLTllbTtcbiAgbWFyZ2luLWxlZnQ6IC0xNWVtO1xufVxuXG5Aa2V5ZnJhbWVzIHNwaW4ge1xuICAwJSB7XG4gICAgdHJhbnNmb3JtOiByb3RhdGUoMGRlZyk7XG4gIH1cbiAgMTAwJSB7XG4gICAgdHJhbnNmb3JtOiByb3RhdGUoMzYwZGVnKTtcbiAgfVxufSJdfQ== */"

/***/ }),

/***/ "./src/app/signup/signup.component.ts":
/*!********************************************!*\
  !*** ./src/app/signup/signup.component.ts ***!
  \********************************************/
/*! exports provided: SignupComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "SignupComponent", function() { return SignupComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
/* harmony import */ var _angular_forms__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/forms */ "./node_modules/@angular/forms/fesm2015/forms.js");
/* harmony import */ var _router_animations__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ../router.animations */ "./src/app/router.animations.ts");
/* harmony import */ var _services_Auth_service__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ../services/Auth.service */ "./src/app/services/Auth.service.ts");
/* harmony import */ var _services_AlertifyService__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ../services/AlertifyService */ "./src/app/services/AlertifyService.ts");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm2015/router.js");







let SignupComponent = class SignupComponent {
    constructor(authService, alertifyService, router) {
        this.authService = authService;
        this.alertifyService = alertifyService;
        this.router = router;
        this.loader = false;
        this.model = {};
        this.loader = true;
    }
    ngOnInit() {
        this.registerForm = new _angular_forms__WEBPACK_IMPORTED_MODULE_2__["FormGroup"]({
            firstName: new _angular_forms__WEBPACK_IMPORTED_MODULE_2__["FormControl"]('', _angular_forms__WEBPACK_IMPORTED_MODULE_2__["Validators"].required),
            lastName: new _angular_forms__WEBPACK_IMPORTED_MODULE_2__["FormControl"]('', _angular_forms__WEBPACK_IMPORTED_MODULE_2__["Validators"].required),
            email: new _angular_forms__WEBPACK_IMPORTED_MODULE_2__["FormControl"]('', _angular_forms__WEBPACK_IMPORTED_MODULE_2__["Validators"].required),
            password: new _angular_forms__WEBPACK_IMPORTED_MODULE_2__["FormControl"]('', [_angular_forms__WEBPACK_IMPORTED_MODULE_2__["Validators"].required, _angular_forms__WEBPACK_IMPORTED_MODULE_2__["Validators"].minLength(4), _angular_forms__WEBPACK_IMPORTED_MODULE_2__["Validators"].maxLength(8)]),
            confirmPassword: new _angular_forms__WEBPACK_IMPORTED_MODULE_2__["FormControl"]('', _angular_forms__WEBPACK_IMPORTED_MODULE_2__["Validators"].required),
            dateOfBirth: new _angular_forms__WEBPACK_IMPORTED_MODULE_2__["FormControl"]('', _angular_forms__WEBPACK_IMPORTED_MODULE_2__["Validators"].required)
        }, this.passwordMatchValidator);
    }
    passwordMatchValidator(g) {
        return g.get('password').value === g.get('confirmPassword').value ? null : { mismatch: true };
    }
    register() {
        if (this.registerForm.valid) {
            this.model = Object.assign({}, this.registerForm.value);
        }
        this.authService.register(this.model).subscribe((response) => {
            this.alertifyService.success(response.success);
        }, (error) => {
            this.alertifyService.error(error);
        }, () => {
            this.model.userName = this.model.email;
            this.authService.login(this.model).subscribe((response) => {
                this.router.navigate(['']); // redirect users to the memeber page when they login
            });
        });
    }
};
SignupComponent.ctorParameters = () => [
    { type: _services_Auth_service__WEBPACK_IMPORTED_MODULE_4__["AuthService"] },
    { type: _services_AlertifyService__WEBPACK_IMPORTED_MODULE_5__["AlertifyService"] },
    { type: _angular_router__WEBPACK_IMPORTED_MODULE_6__["Router"] }
];
SignupComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
        selector: 'app-signup',
        template: __webpack_require__(/*! raw-loader!./signup.component.html */ "./node_modules/raw-loader/index.js!./src/app/signup/signup.component.html"),
        animations: [Object(_router_animations__WEBPACK_IMPORTED_MODULE_3__["routerTransition"])()],
        styles: [__webpack_require__(/*! ./signup.component.scss */ "./src/app/signup/signup.component.scss")]
    }),
    tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [_services_Auth_service__WEBPACK_IMPORTED_MODULE_4__["AuthService"],
        _services_AlertifyService__WEBPACK_IMPORTED_MODULE_5__["AlertifyService"], _angular_router__WEBPACK_IMPORTED_MODULE_6__["Router"]])
], SignupComponent);



/***/ }),

/***/ "./src/environments/environment.ts":
/*!*****************************************!*\
  !*** ./src/environments/environment.ts ***!
  \*****************************************/
/*! exports provided: environment */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "environment", function() { return environment; });
// This file can be replaced during build by using the `fileReplacements` array.
// `ng build --prod` replaces `environment.ts` with `environment.prod.ts`.
// The list of file replacements can be found in `angular.json`.
const environment = {
    production: false
};
/*
 * For easier debugging in development mode, you can import the following file
 * to ignore zone related error stack frames such as `zone.run`, `zoneDelegate.invokeTask`.
 *
 * This import should be commented out in production mode because it will have a negative impact
 * on performance if an error is thrown.
 */
// import 'zone.js/dist/zone-error';  // Included with Angular CLI.


/***/ }),

/***/ "./src/main.ts":
/*!*********************!*\
  !*** ./src/main.ts ***!
  \*********************/
/*! no exports provided */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
/* harmony import */ var _angular_platform_browser_dynamic__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/platform-browser-dynamic */ "./node_modules/@angular/platform-browser-dynamic/fesm2015/platform-browser-dynamic.js");
/* harmony import */ var _app_app_module__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ./app/app.module */ "./src/app/app.module.ts");
/* harmony import */ var _environments_environment__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ./environments/environment */ "./src/environments/environment.ts");




if (_environments_environment__WEBPACK_IMPORTED_MODULE_3__["environment"].production) {
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_0__["enableProdMode"])();
}
Object(_angular_platform_browser_dynamic__WEBPACK_IMPORTED_MODULE_1__["platformBrowserDynamic"])().bootstrapModule(_app_app_module__WEBPACK_IMPORTED_MODULE_2__["AppModule"])
    .catch(err => console.error(err));


/***/ }),

/***/ 0:
/*!***************************!*\
  !*** multi ./src/main.ts ***!
  \***************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

module.exports = __webpack_require__(/*! /Users/mac/Projects/OnlineExam/OnlineExamApp-SPA/src/main.ts */"./src/main.ts");


/***/ })

},[[0,"runtime","vendor"]]]);
//# sourceMappingURL=main-es2015.js.map