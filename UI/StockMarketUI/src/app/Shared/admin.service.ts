import { Injectable } from '@angular/core';
import { HttpClient } from "@angular/common/http";
import { Observable } from "rxjs";
import { Company } from '../Models/company';

@Injectable({
  providedIn: 'root'
})
export class AdminService {
  path:string="http://localhost:53527/api/Admin/"
  constructor(private http:HttpClient) { }
  public GetAllCompany():Observable<Company[]>{
    return this.http.get<Company[]>(this.path+"GetAllCompany");
  }
  public Get(companyCode:string):Observable<Company>{
    return this.http.get<Company>(this.path+'GetCompany/'+companyCode);
  }
  public Add(item:Company):Observable<any>{
    return this.http.post<any>(this.path+'AddCompany',item);
  }
  public Update(item:Company):Observable<any>{
    return this.http.put<any>(this.path+'UpdateCompany',item);
  }
  public Delete(companyCode:string):Observable<any>{
    return this.http.delete<Company>(this.path+'Delete/'+companyCode);
  }
}
