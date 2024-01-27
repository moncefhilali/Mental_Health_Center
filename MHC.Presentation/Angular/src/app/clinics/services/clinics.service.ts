import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Clinic } from '../interfaces/clinic.interface';

@Injectable({
  providedIn: 'root',
})
export class ClinicsService {
  readonly ROOT_URL = 'https://localhost:7216/api/Clinics';

  Categories: any;

  constructor(private http: HttpClient) {}

  getClinics() {
    const headers = new HttpHeaders({ 'x-version': '2' });
    return this.http.get<Clinic[]>(this.ROOT_URL, { headers });
  }
}
