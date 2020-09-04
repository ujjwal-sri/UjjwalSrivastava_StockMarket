import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { StockmarketViewComponent } from './stockmarket-view.component';

describe('StockmarketViewComponent', () => {
  let component: StockmarketViewComponent;
  let fixture: ComponentFixture<StockmarketViewComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ StockmarketViewComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(StockmarketViewComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
