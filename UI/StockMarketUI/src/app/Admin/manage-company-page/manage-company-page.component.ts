import { Component, OnInit } from '@angular/core';
import { AdminService } from '../../Shared/admin.service';
import { Company } from '../../Models/company';

import { Router } from '@angular/router';

@Component({
  selector: 'app-manage-company-page',
  templateUrl: './manage-company-page.component.html',
  styleUrls: ['./manage-company-page.component.css']
})
export class ManageCompanyPageComponent implements OnInit {
  list:Company[];
  companyCode:string;
  companyName:string;
  turnOver:number;
  ceo:string;
  boardOfDirectors:string;
  listInStockExchanges:string;
  sector:string;
  companyWriteup:string;
  stockCode:string;
  stockPrices:number;
  obj:Company;
  errmsg:string;
    constructor(private service:AdminService) {
      this.service.GetAllCompany().subscribe(i=>{
        this.list=i;
        console.log(this.list)
      })
     }
  
    ngOnInit(): void {
    }
    Search()
    {
      this.service.Get(this.companyCode).subscribe(item=>{
        this.obj=item;
        console.log(this.obj);
        if(this.obj!=null)
        {
          this.companyCode=this.obj.companyCode;
          this.companyName=this.obj.companyName;
          this.turnOver=this.obj.turnOver;
          this.ceo=this.obj.ceo;
          this.errmsg=null;
        }
        else 
        {
          this.errmsg = "No result found";
          this.companyName=null;
          this.turnOver=null;
          this.ceo=null;
        }
      })
      
    }
    Add()
    {
      this.obj = new Company();
      this.obj.companyCode=this.companyCode;
      this.obj.companyName=this.companyName;
      this.obj.turnOver=this.turnOver;
      this.obj.ceo=this.ceo;
      this.obj.boardOfDirectors=null;
      this.obj.companyWriteup=null;
      this.obj.listInStockExchanges=null;
      this.obj.sector=null;
      this.obj.stockCode=null;
      this.obj.stockPrices=null;
      this.service.Add(this.obj).subscribe(i=>{
        console.log(i)
      })
    }
    Update()
    {
      this.obj = new Company();
      this.obj.companyCode=this.companyCode;
      this.obj.companyName=this.companyName;
      this.obj.turnOver=this.turnOver;
      this.obj.ceo=this.ceo;
      this.obj.boardOfDirectors=null;
      this.obj.companyWriteup=null;
      this.obj.listInStockExchanges=null;
      this.obj.sector=null;
      this.obj.stockCode=null;
      this.obj.stockPrices=null;
      this.service.Update(this.obj).subscribe(i=>{
        console.log(i)
      })
    }
    Delete()
    {
      this.service.Delete(this.companyCode).subscribe(res=>{
        console.log(res)
      })
    }
  }