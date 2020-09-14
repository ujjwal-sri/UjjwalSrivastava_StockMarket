import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
@Component({
  selector: 'app-admin-land-page',
  templateUrl: './admin-land-page.component.html',
  styleUrls: ['./admin-land-page.component.css']
})
export class AdminLandPageComponent implements OnInit {

  constructor(private router: Router) { }

  ngOnInit(): void {
  }
  ManageCompany() {
    this.router.navigateByUrl('AdminManageCompany');
  }
  AdminLand(){
    this.router.navigateByUrl('AdminLogin');
  }
}
