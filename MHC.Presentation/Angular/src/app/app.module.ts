import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { FormsModule } from '@angular/forms';
import { RatingModule } from 'primeng/rating';
import { DataViewModule } from 'primeng/dataview';
import { AppComponent } from './app.component';
import { NavbarComponent } from './shared/navbar/navbar.component';
import { TreatmentsPageModule } from './treatments/treatments-page.module';
import { OurServicesPageModule } from './our-services/our-services-page.module';
import { MyStandaloneComponentComponent } from './shared/my-standalone-component/my-standalone-component.component';
import { ClinicsPageModule } from './clinics/clinics-page.module';

@NgModule({
  declarations: [AppComponent, NavbarComponent],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    RatingModule,
    DataViewModule,
    TreatmentsPageModule,
    OurServicesPageModule,
    ClinicsPageModule,
  ],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule {}
