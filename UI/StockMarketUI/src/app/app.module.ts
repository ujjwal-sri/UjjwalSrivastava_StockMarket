import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http'
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { StockmarketViewComponent } from './stockmarket-view/stockmarket-view.component';
import { StockService } from './Shared/stock.service'; 

@NgModule({
  declarations: [
    AppComponent,
    StockmarketViewComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule
  ],
  providers: [StockService],
  bootstrap: [AppComponent]
})
export class AppModule { }
