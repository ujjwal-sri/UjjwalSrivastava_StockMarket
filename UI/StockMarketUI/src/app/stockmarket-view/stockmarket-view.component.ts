import { Component, OnInit } from '@angular/core';
import { StockService } from '../Shared/stock.service';
import { Company } from '../Models/company';

import { Router } from '@angular/router';

@Component({
  selector: 'app-stockmarket-view',
  templateUrl: './stockmarket-view.component.html',
  styleUrls: ['./stockmarket-view.component.css']
})
export class StockmarketViewComponent implements OnInit {
  constructor(private router:Router) { }

  ngOnInit(): void {
  }
  ToUser() {
    this.router.navigateByUrl('UserLogin');
  }
  ToAdmin() {
    this.router.navigateByUrl('AdminLogin');
  }
}
