import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ClinicsPageComponent } from './clinics-page.component';
import { ClinicComponent } from './components/clinic/clinic.component';
import { FormsModule } from '@angular/forms';
import { RatingModule } from 'primeng/rating';
import { HeaderComponent } from '../shared/header/header.component';

@NgModule({
  declarations: [ClinicsPageComponent, ClinicComponent],
  imports: [CommonModule, HeaderComponent, FormsModule, RatingModule],
})
export class ClinicsPageModule {}
