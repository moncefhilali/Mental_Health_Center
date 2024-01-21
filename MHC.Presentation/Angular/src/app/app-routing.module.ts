import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { ClinicsPageComponent } from './clinics/clinics-page.component';
import { HomePageComponent } from './home/home-page.component';
import { TreatmentsPageComponent } from './treatments/treatments-page.component';
import { OurServicesPageComponent } from './our-services/our-services-page.component';

const routes: Routes = [
  { path: 'clinics', component: ClinicsPageComponent },
  { path: 'home', component: HomePageComponent },
  { path: 'our-services', component: OurServicesPageComponent },
  { path: 'treatments', component: TreatmentsPageComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
