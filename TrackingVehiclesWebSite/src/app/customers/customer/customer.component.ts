import { Component, OnInit } from '@angular/core';
import { CustomerService } from 'src/app/shared/customer.service';
import { NgForm } from '@angular/forms';
import { Observable } from 'rxjs/Observable';
import { Customer } from 'src/app/shared/customer.model';
import 'rxjs/Rx';



@Component({
  selector: 'app-customer',
  templateUrl: './customer.component.html',
  styleUrls: ['./customer.component.css']
})


export class CustomerComponent implements OnInit {
  public custSearchText: string;
  interv = setInterval(() => { }, 1000);
  allCustomers: Customer[];
  constructor(private customerService: CustomerService) { }


  // ngOnInit() {
  //   this.allCustomers = this.customerService.getAllCustomerVehicleDetail();
  //   //console.log(this.allCustomers)
  //   this.interval = setInterval(() => {
  //     this.checkUpdate();

  // }, 10000);
  // }


  ngOnInit() {

    this.customerService.getAllCustomerVehicleDetail()
      .subscribe(data => this.allCustomers = data,
        err => console.log(err));
    this.interv = setInterval(() => {

    }, 1000);
  }
  ngOnDestroy() {
    if (this.interv) {
      clearInterval(this.interv);
      console.log("ngOnDestroy");
    }

   
  }

  checkUpdate() {
    this.customerService.getAllCustomerVehicleDetail()
      .subscribe(res => {
        console.log(res, "Response here");

      },
        err => {
          console.log(err);
        })


  }


}
