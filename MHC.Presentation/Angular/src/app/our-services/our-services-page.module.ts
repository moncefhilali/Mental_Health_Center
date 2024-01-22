import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { OurServicesPageComponent } from './our-services-page.component';
import { RatingModule } from 'primeng/rating';
import { FormsModule } from '@angular/forms';
import { ServiceCardComponent } from './components/service-card/service-card.component';
import { HeaderComponent } from '../shared/header/header.component';

@NgModule({
  declarations: [
    OurServicesPageComponent,
    ServiceCardComponent,
    HeaderComponent,
  ],
  imports: [CommonModule, FormsModule, RatingModule],
})
export class OurServicesPageModule {}
