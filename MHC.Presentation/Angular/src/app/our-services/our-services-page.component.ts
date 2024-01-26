import { Component } from '@angular/core';
import { OurService } from './interfaces/ourService.interface';
import { OurservicesService } from './services/ourservices.service';

@Component({
  selector: 'app-our-services-page',
  templateUrl: './our-services-page.component.html',
  styleUrls: ['./our-services-page.component.css'],
})
export class OurServicesPageComponent {
  allServices: OurService[] = [];
  primaryServices: OurService[] = [];
  specialtyService: OurService[] = [];
  constructor(private ourerviceService: OurservicesService) {}

  ngOnInit() {
    this.ourerviceService.getOurServices().subscribe((response) => {
      this.allServices = response;
      this.primaryServices = response.filter(
        (s) => s.category.name === 'Primary Care'
      );
      this.specialtyService = response.filter(
        (s) => s.category.name === 'Specialty Care'
      );
      this.primaryServices.push(this.specialtyService[2]);
    });
  }
}
