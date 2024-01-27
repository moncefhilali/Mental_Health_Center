import { Component, Input } from '@angular/core';
import { Clinic } from '../../interfaces/clinic.interface';

@Component({
  selector: 'app-clinic',
  templateUrl: './clinic.component.html',
  styleUrls: ['./clinic.component.css'],
})
export class ClinicComponent {
  @Input() clinics: Clinic[] = [];

  getSeverity(clinic: Clinic): string | undefined {
    switch (clinic.status) {
      case 'Open':
        return 'success';

      case 'Closes Soon':
        return 'warning';

      case 'Closed':
        return 'danger';

      default:
        return '';
    }
  }
}
