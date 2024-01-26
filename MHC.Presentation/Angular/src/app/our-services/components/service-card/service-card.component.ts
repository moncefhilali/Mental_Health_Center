import { Component, Input } from '@angular/core';
import { OurService } from '../../interfaces/ourService.interface';

@Component({
  selector: 'app-service-card',
  templateUrl: './service-card.component.html',
  styleUrls: ['./service-card.component.css'],
})
export class ServiceCardComponent {
  value: number = 4;
  @Input() ourservices: OurService[] = [];
}
