import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ManageCompanyPageComponent } from './manage-company-page.component';

describe('ManageCompanyPageComponent', () => {
  let component: ManageCompanyPageComponent;
  let fixture: ComponentFixture<ManageCompanyPageComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ManageCompanyPageComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ManageCompanyPageComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
