import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { ClinicsPageComponent } from './clinics/clinics-page.component';
import { HomePageComponent } from './home/home-page.component';
import { TreatmentsPageComponent } from './treatments/treatments-page.component';
import { OurServicesPageComponent } from './our-services/our-services-page.component';
import { AppComponent } from './app.component';

const routes: Routes = [
  { path: 'home', component: HomePageComponent },
  { path: 'clinics', component: ClinicsPageComponent },
  { path: 'treatments', component: TreatmentsPageComponent },
  { path: 'our-services', component: OurServicesPageComponent },
  { path: '', redirectTo: '/home', pathMatch: 'full' },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
