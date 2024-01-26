import { Component, OnInit } from '@angular/core';
import { TreatmentsService } from './services/treatments.service';
import { Treatment } from './interfaces/treatment.interface';

@Component({
  selector: 'app-treatments-page',
  templateUrl: './treatments-page.component.html',
  styleUrls: ['./treatments-page.component.css'],
})
export class TreatmentsPageComponent {
  allTreatments: Treatment[] = [];
  constructor(private treatmentsService: TreatmentsService) {}

  ngOnInit() {
    this.treatmentsService.getTreatments().subscribe((response) => {
      this.allTreatments = response;
      console.log(response);
    });
  }
}
