import { Component, OnInit } from '@angular/core';
import { ProductService } from '../product.service';

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.css']
})
export class ProductComponent implements OnInit {

  products: any;

    constructor(private productService: ProductService) { }


  ngOnInit(): void {
    this.load();
  }


  load() {
    this.productService.getPurchasedProdcts().subscribe(
      result => {
        this.products = result
        console.log(this.products[0].bill)
      },
      error => {
        console.log(error)
      },
      () => {
        // 'onCompleted' callback.
        // No errors, route to new page here
      }
    );
  }

  sendData(){
    let json 
    this.productService.getJsonData().subscribe(
      result => {
        json = result
        console.log(json)
        this.productService.saveCliente(json).subscribe()
      },
      error => {
        console.log(error)
      },
      () => {
        // 'onCompleted' callback.
        // No errors, route to new page here
      }
    );
    //this.productService.saveCliente();
  }

}
