import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { TreatmentsPageComponent } from './treatments-page.component';
import { TreatmentComponent } from './components/treatment/treatment.component';

@NgModule({
  declarations: [TreatmentsPageComponent, TreatmentComponent],
  imports: [CommonModule],
})
export class TreatmentsPageModule {}
