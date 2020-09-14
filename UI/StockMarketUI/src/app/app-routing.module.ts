import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { StockmarketViewComponent } from './stockmarket-view/stockmarket-view.component';
import { ManageCompanyPageComponent } from './Admin/manage-company-page/manage-company-page.component';
import { AdminLoginPageComponent } from './Admin/admin-login-page/admin-login-page.component';
import { AdminLandPageComponent } from './Admin/admin-land-page/admin-land-page.component';
import { UserLoginPageComponent } from './User/user-login-page/user-login-page.component';
import { UserLandPageComponent } from './User/user-land-page/user-land-page.component';
const routes: Routes = [
  {path:'',redirectTo:'home',pathMatch:'full'},
  {path:'home',component:StockmarketViewComponent},
  {path:'AdminLogin',component:AdminLoginPageComponent},
  {path:'AdminManageCompany',component:ManageCompanyPageComponent},
  {path:'AdminLandPage',component:AdminLandPageComponent},
  {path:'UserLogin',component:UserLoginPageComponent},
  {path:'UserLandPage',component:UserLandPageComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
