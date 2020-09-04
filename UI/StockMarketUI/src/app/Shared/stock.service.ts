import { Injectable } from '@angular/core';
import { HttpClient } from "@angular/common/http";
import { Observable } from "rxjs";
import { Company } from '../Models/company';
@Injectable({
  providedIn: 'root'
})
export class StockService {

  path:string="http://localhost:53527/api/Admin/"
  constructor(private http:HttpClient) { }
  public GetAllCompany():Observable<Company[]>{
    return this.http.get<Company[]>(this.path+"GetAllCompany");
  }
}