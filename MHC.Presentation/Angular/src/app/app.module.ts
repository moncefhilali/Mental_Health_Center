import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { NavbarComponent } from './shared/navbar/navbar.component';
import { IntroductionComponent } from './treatments/components/introduction/introduction.component';
import { TreatmentComponent } from './treatments/components/treatment/treatment.component';
import { ServiceCardComponent } from './our-services/components/service-card/service-card.component';
import { FormsModule } from '@angular/forms';
import { RatingModule } from 'primeng/rating';
import { ClinicComponent } from './clinics/components/clinic/clinic.component';
import { DataViewModule } from 'primeng/dataview';

@NgModule({
  declarations: [
    NavbarComponent,
    IntroductionComponent,
    TreatmentComponent,
    ServiceCardComponent,
    ClinicComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    RatingModule,
    DataViewModule,
  ],
  providers: [],
  bootstrap: [],
})
export class AppModule {}
