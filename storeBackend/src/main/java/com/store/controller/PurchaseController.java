package com.store.controller;

import java.util.List;

import com.store.model.Bill;
import com.store.model.Purchase;
import com.store.service.BillService;
import com.store.service.CategoryService;
import com.store.service.ProductService;
import com.store.service.PurchaseService;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.CrossOrigin;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController
@CrossOrigin(origins = "http://localhost:4200")
@RequestMapping(path = "/purchase")

public class PurchaseController{

	@Autowired
	private PurchaseService  purchaseService;

	@Autowired
	private BillService  billseService;

	@Autowired
	private ProductService  productseService;

	@Autowired
	private CategoryService  categoryService;

	@PostMapping("save")
	public ResponseEntity<String> save(@RequestBody List<Purchase> purchases){
		for(Purchase purchase : purchases){
			for(Bill x : purchase.getBill()){
		    		categoryService.save(x.getProduct().getIdCategory());
				productseService.save(x.getProduct());
				billseService.save(x);		
			}
		purchaseService.savePurchase(purchase);
		}

		return new ResponseEntity<String>("", HttpStatus.OK); 
	}

	@GetMapping("load")
	public ResponseEntity<List<Purchase>>  getAll(){
		return new ResponseEntity<List<Purchase>>(purchaseService.getAll() , HttpStatus.OK); 
	}
}
