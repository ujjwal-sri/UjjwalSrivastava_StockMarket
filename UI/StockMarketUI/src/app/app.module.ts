import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http'
import { AppRoutingModule } from './app-routing.module';
import { FormsModule } from '@angular/forms';
import { AppComponent } from './app.component';
import { StockmarketViewComponent } from './stockmarket-view/stockmarket-view.component';
import { StockService } from './Shared/stock.service';
import { AdminLoginPageComponent } from './Admin/admin-login-page/admin-login-page.component';
import { ManageCompanyPageComponent } from './Admin/manage-company-page/manage-company-page.component';
import { AdminLandPageComponent } from './Admin/admin-land-page/admin-land-page.component';
import { UserLoginPageComponent } from './User/user-login-page/user-login-page.component';
import { UserLandPageComponent } from './User/user-land-page/user-land-page.component'; 

@NgModule({
  declarations: [
    AppComponent,
    StockmarketViewComponent,
    AdminLoginPageComponent,
    ManageCompanyPageComponent,
    AdminLandPageComponent,
    UserLoginPageComponent,
    UserLandPageComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule
  ],
  providers: [StockService],
  bootstrap: [AppComponent]
})
export class AppModule { }
