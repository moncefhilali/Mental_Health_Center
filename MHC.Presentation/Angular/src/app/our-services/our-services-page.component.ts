import { Component } from '@angular/core';
import { OurService } from './interfaces/ourService.interface';
import { OurservicesService } from './services/ourservices.service';
import { CategoriesService } from './services/categories.service';
import { Category } from './interfaces/category.interface';

@Component({
  selector: 'app-our-services-page',
  templateUrl: './our-services-page.component.html',
  styleUrls: ['./our-services-page.component.css'],
})
export class OurServicesPageComponent {
  allServices: OurService[] = [];
  allCategories: Category[] = [];
  constructor(
    private ourerviceService: OurservicesService,
    private categoryService: CategoriesService
  ) {}

  ngOnInit() {
    this.ourerviceService.getOurServices().subscribe((response) => {
      this.allServices = response;
    });

    this.categoryService.getOurServices().subscribe((response) => {
      this.allCategories = response;
    });
  }
}
