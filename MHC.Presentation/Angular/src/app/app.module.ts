import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HeaderComponent } from './components/header/header.component';
import { NavbarComponent } from './components/navbar/navbar.component';
import { IntroductionComponent } from './components/introduction/introduction.component';
import { TreatmentComponent } from './components/treatment/treatment.component';
import { ServiceCardComponent } from './components/service-card/service-card.component';
import { FormsModule } from '@angular/forms';
import { RatingModule } from 'primeng/rating';
import { ClinicComponent } from './components/clinic/clinic.component';
import { DataViewModule } from 'primeng/dataview';
import { PaginatorModule } from 'primeng/paginator';

@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
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
  bootstrap: [AppComponent],
})
export class AppModule {}
