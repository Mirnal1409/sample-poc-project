import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class CurrencyService {

  private apiUrl = 'https://localhost:44381';

  constructor(private http: HttpClient) { }

  getProducts(): Observable<any[]> {
    return this.http.get<any[]>(`${this.apiUrl}/products/getallproducts`);
  }

  getCountries(): Observable<any[]> {
    return this.http.get<any[]>(`${this.apiUrl}/countries/getallcountries`);
  }

  getExchangeRate(fromCurrency: string, toCurrency: string): Observable<any> {
    return this.http.get<any>(`${this.apiUrl}/CurrencyConverter/GetExchangeRate?fromCurrency=${fromCurrency}&toCurrency=${toCurrency}`);
  }
}
