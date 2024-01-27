import { Component } from '@angular/core';
import { Clinic } from './interfaces/clinic.interface';
import { ClinicsService } from './services/clinics.service';

@Component({
  selector: 'app-clinics-page',
  templateUrl: './clinics-page.component.html',
  styleUrls: ['./clinics-page.component.css'],
})
export class ClinicsPageComponent {
  allClinics: Clinic[] = [];
  constructor(private clinicService: ClinicsService) {}

  ngOnInit() {
    this.clinicService.getClinics().subscribe((response) => {
      this.allClinics = response;
      console.log(response);
    });
  }
}
