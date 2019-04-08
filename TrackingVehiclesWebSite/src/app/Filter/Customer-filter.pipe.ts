import { Pipe, PipeTransform } from '@angular/core';
import { Customer } from '../Interfaces/Customer';
@Pipe({
  name: 'CustomergrdFilter'
})
export class CustomerFilterPipe implements PipeTransform {

    transform(Customer: Customer[], CustomersearchTerm: string): Customer[] {
      if (!Customer || !CustomersearchTerm) {
        return Customer;
    }
    debugger
    return Customer.filter(Customer =>
      Customer.CustomerName.toLowerCase().indexOf(CustomersearchTerm.toLowerCase()) !== -1);
    


}}