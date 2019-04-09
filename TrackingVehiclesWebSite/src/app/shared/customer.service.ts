import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { HttpHeaders } from '@angular/common/http';
import { Customer } from './customer.model';
import { Observable } from 'rxjs';
import { interval } from 'rxjs';
import 'rxjs/Rx';
 

@Injectable({
  providedIn: 'root'
})
export class CustomerService {
  private url = 'http://localhost:56776/AllCustomersDetails';

  constructor(private http: HttpClient) { }

 
  getAllCustomerVehicleDetail(): Observable<Customer[]> {
    console.log('start get');
    return Observable.interval(5000).flatMap(() => {
      return this.http.get<Customer[]>(this.url);
    });}

}
