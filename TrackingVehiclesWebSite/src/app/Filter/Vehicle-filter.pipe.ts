import { Pipe, PipeTransform } from '@angular/core';
import { Vehicle } from '../Interfaces/Vehicle';


@Pipe({
  name: 'VehiclegrdFilter'
})
export class VehicleFilterPipe implements PipeTransform {
    
    transform(customVehcile: Vehicle[], VehiclesearchTerm: string): Vehicle[] {
        if (!customVehcile || !VehiclesearchTerm) {
          return customVehcile;
      }
      
      debugger;
      return customVehcile.filter(Vehicle =>
      Vehicle.Status.toString().toLowerCase().indexOf(VehiclesearchTerm.toLowerCase()) !== -1);  

}}