import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Category } from '../interfaces/category.interface';

@Injectable({
  providedIn: 'root',
})
export class CategoriesService {
  readonly ROOT_URL = 'https://localhost:7216/api/Categories';

  Categories: any;

  constructor(private http: HttpClient) {}

  getOurServices() {
    const headers = new HttpHeaders({ 'x-version': '2' });
    return this.http.get<Category[]>(this.ROOT_URL, { headers });
  }
}
