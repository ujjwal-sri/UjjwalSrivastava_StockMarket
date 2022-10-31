import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
@Component({
  selector: 'app-admin-login-page',
  templateUrl: './admin-login-page.component.html',
  styleUrls: ['./admin-login-page.component.css']
})
export class AdminLoginPageComponent implements OnInit {
  uname: string;
  password: string;
  constructor(private router:Router) { }

  ngOnInit(): void {
    console.log("admin login page");
  }
  Validate() {
    if (this.uname == "Admin1" && this.password == "password") {
      this.router.navigateByUrl('AdminLandPage');
    }
    else {
      alert('Invalid Credentials');
    }
  }
}
