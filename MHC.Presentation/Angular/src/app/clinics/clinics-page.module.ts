import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ClinicsPageComponent } from './clinics-page.component';
import { ClinicComponent } from './components/clinic/clinic.component';
import { HeaderComponent } from '../shared/header/header.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { RatingModule } from 'primeng/rating';
import { DataViewModule } from 'primeng/dataview';
import { TagModule } from 'primeng/tag';

@NgModule({
  declarations: [ClinicsPageComponent, ClinicComponent],
  imports: [
    CommonModule,
    HeaderComponent,
    FormsModule,
    ReactiveFormsModule,
    RatingModule,
    DataViewModule,
    TagModule,
  ],
})
export class ClinicsPageModule {}
