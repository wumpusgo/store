package com.store.service;

import java.util.List;

import com.store.model.Purchase;
import com.store.repository.PurchaseRepository;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

@Service
public class PurchaseService{

	@Autowired
	private PurchaseRepository purchaseRepository;

	public Purchase savePurchase(Purchase purchase){
	       return purchaseRepository.save(purchase);
	}

	public List<Purchase> getAll(){
		return purchaseRepository.findAll();
	}
	
}
