import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Treatment } from '../interfaces/treatment.interface';

@Injectable({
  providedIn: 'root',
})
export class TreatmentsService {
  readonly ROOT_URL = 'https://localhost:7216/api/Treatments';

  treatments: any;

  constructor(private http: HttpClient) {}

  getTreatments() {
    const headers = new HttpHeaders({ 'x-version': '2' });
    return this.http.get<Treatment[]>(this.ROOT_URL, { headers });
  }
}
