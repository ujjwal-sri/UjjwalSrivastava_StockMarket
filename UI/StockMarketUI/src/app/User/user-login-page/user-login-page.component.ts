import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
@Component({
  selector: 'app-user-login-page',
  templateUrl: './user-login-page.component.html',
  styleUrls: ['./user-login-page.component.css']
})
export class UserLoginPageComponent implements OnInit {
  uname: string;
  password: string;
  constructor(private router:Router) { }

  ngOnInit(): void {
  }
  Validate() {
    if (this.uname == "User1" && this.password == "password") {
      this.router.navigateByUrl('UserLandPage');
    }
    else {
      alert('Invalid Credentials');
    }
  }
}
