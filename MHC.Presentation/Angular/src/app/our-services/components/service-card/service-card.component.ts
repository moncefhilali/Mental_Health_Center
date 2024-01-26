import { Component, Input } from '@angular/core';
import { OurService } from '../../interfaces/ourService.interface';
import { Category } from '../../interfaces/category.interface';

@Component({
  selector: 'app-service-card',
  templateUrl: './service-card.component.html',
  styleUrls: ['./service-card.component.css'],
})
export class ServiceCardComponent {
  value: number = 4;
  @Input() ourservices: OurService[] = [];
  @Input() categories: Category[] = [];
}
