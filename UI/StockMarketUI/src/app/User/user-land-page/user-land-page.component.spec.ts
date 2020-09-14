import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { UserLandPageComponent } from './user-land-page.component';

describe('UserLandPageComponent', () => {
  let component: UserLandPageComponent;
  let fixture: ComponentFixture<UserLandPageComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ UserLandPageComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(UserLandPageComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
