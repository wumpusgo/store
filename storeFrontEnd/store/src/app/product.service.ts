import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';

@Injectable()
export class ProductService {

  constructor(private http: HttpClient) { }

  httpOptions = {
    headers: new HttpHeaders({
      'Content-Type': 'application/json'
    })
  }

  jsonURL = 'assets/data.json'
  urlPurchasedPorducts: string = "http://localhost:9090/purchase/load"
  urlSaveRequest: string = "http://localhost:9090/purchase/save"

  saveCliente(purchases: any) {
    return this.http.post(this.urlSaveRequest, purchases, this.httpOptions);
  }

  getJsonData() {
    return this.http.get(this.jsonURL, this.httpOptions);
  }

  getPurchasedProdcts() {
    return this.http.get(this.urlPurchasedPorducts, this.httpOptions);
  }
}
