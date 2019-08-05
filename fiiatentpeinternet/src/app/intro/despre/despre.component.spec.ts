import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { DespreComponent } from './despre.component';

describe('DespreComponent', () => {
  let component: DespreComponent;
  let fixture: ComponentFixture<DespreComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ DespreComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(DespreComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
