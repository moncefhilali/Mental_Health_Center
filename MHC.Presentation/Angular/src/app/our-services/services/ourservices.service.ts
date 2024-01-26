import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { OurService } from '../interfaces/ourService.interface';

@Injectable({
  providedIn: 'root',
})
export class OurservicesService {
  readonly ROOT_URL = 'https://localhost:7216/api/OurServices';

  OurServices: any;

  constructor(private http: HttpClient) {}

  getOurServices() {
    const headers = new HttpHeaders({ 'x-version': '2' });
    return this.http.get<OurService[]>(this.ROOT_URL, { headers });
  }
}
