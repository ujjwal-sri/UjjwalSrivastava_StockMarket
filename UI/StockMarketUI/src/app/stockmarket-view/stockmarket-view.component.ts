import { Component, OnInit } from '@angular/core';
import { StockService } from '../Shared/stock.service';
import { Company } from '../Models/company';

@Component({
  selector: 'app-stockmarket-view',
  templateUrl: './stockmarket-view.component.html',
  styleUrls: ['./stockmarket-view.component.css']
})
export class StockmarketViewComponent implements OnInit {
list:Company[];
  constructor(private service:StockService) {
    this.service.GetAllCompany().subscribe(i=>{
      this.list=i;
      console.log(this.list)
    })
   }

  ngOnInit(): void {
  }

}
