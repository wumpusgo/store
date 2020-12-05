package com.store.service;

import java.util.List;

import com.store.model.Bill;
import com.store.repository.BillRepository;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

@Service
public class BillService {

	@Autowired
	private BillRepository BillRepository;

	public List<Bill> getAllProducts(){
		return BillRepository.findAll();
	}

	public void save(Bill bill){
		System.out.println(bill.getIdBill());
		BillRepository.save(bill);
	}
}
