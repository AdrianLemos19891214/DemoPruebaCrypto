import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ICotizacion } from './modelos/cotizacion.interface';
import { environment } from 'environments/environment';

@Injectable({
  providedIn: 'root'
})
export class CryptoService {

  private url = environment.cryptoApi;

  constructor(private http: HttpClient) { }

  getCryptoData(importe: number): Promise<ICotizacion[]|undefined> {

    return this.http.get<ICotizacion[]>(this.url+"?importeUsd="+importe).toPromise();
  }
}
