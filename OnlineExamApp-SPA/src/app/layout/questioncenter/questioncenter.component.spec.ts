/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { QuestioncenterComponent } from './questioncenter.component';

describe('QuestioncenterComponent', () => {
  let component: QuestioncenterComponent;
  let fixture: ComponentFixture<QuestioncenterComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ QuestioncenterComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(QuestioncenterComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
