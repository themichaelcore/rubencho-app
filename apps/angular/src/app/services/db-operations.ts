import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { BasePedido } from '../models/interfaces';

@Injectable({
  providedIn: 'root',
})

export class DbOperations {

  private apiUrl = 'http://localhost:5243/api';
  private headers = new HttpHeaders({
    'Content-Type': 'application/json',
    'Access-Control-Allow-Origin': '*',
    'Access-Control-Allow-Methods': 'GET, POST, OPTIONS, PUT, DELETE',
    'Allow': 'GET, POST, OPTIONS, PUT, DELETE',
    'Access-Control-Allow-Headers': 'X-API-KEY, Origin, X-Requested-With, Content-Type, Accept'
    // 'Authorization': `Bearer ${token}` // Descomenta si necesitas enviar un token
  });


  constructor(private http: HttpClient) { }

  crearPedido(datos: BasePedido): Observable<any> {
    return this.http.post<any>(this.apiUrl+'/pedido', datos, { headers: this.headers });
  }

  getProductos(): Observable<any> {
    return this.http.get<any>(this.apiUrl+'/producto', { headers: this.headers });
  }
  
  getAcompanamientos(): Observable<any> {
    return this.http.get<any>(this.apiUrl+'/acompanamiento', { headers: this.headers });
  }

}
