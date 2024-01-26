import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { TreatmentsPageComponent } from './treatments-page.component';
import { TreatmentComponent } from './components/treatment/treatment.component';
import { IntroductionComponent } from './components/introduction/introduction.component';
import { HeaderComponent } from '../shared/header/header.component';
import { HttpClientModule } from '@angular/common/http';

@NgModule({
  declarations: [
    TreatmentsPageComponent,
    IntroductionComponent,
    TreatmentComponent,
  ],
  imports: [CommonModule, HeaderComponent, HttpClientModule],
})
export class TreatmentsPageModule {}
