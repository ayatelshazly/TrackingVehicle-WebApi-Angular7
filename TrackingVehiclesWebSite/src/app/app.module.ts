import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms'
import { ReactiveFormsModule } from '@angular/forms';  
import { HttpClientModule, HttpClient } from '@angular/common/http'; 
import { AppComponent } from './app.component';
import { CustomersComponent } from './Customers/customers.component';
import { NgAlertModule } from '@theo4u/ng-alert';
import { CustomerComponent } from './Customers/customer/customer.component';
import { CustomerService } from './shared/customer.service';
import { CustomerFilterPipe } from './Filter/Customer-filter.pipe';
import { VehicleFilterPipe } from './Filter/Vehicle-filter.pipe';

@NgModule({
  declarations: [
    AppComponent,
    CustomersComponent,
    CustomerComponent  ,
    CustomerFilterPipe,
    VehicleFilterPipe
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    FormsModule,   
    NgAlertModule
  ],
  providers: [HttpClientModule,CustomerService],
  bootstrap: [AppComponent]
})
export class AppModule { }


    