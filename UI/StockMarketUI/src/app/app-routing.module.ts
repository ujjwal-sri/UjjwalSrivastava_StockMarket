import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { StockmarketViewComponent } from './stockmarket-view/stockmarket-view.component';

const routes: Routes = [
  {path:'view',component:StockmarketViewComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
