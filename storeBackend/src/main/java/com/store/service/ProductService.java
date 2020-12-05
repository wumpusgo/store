package com.store.service;

import java.util.List;

import com.store.model.Product;
import com.store.repository.ProductRepository;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

@Service
public class ProductService {

	@Autowired
	private ProductRepository productRepository;

	public List<Product> getAllProducts(){
		return productRepository.findAll();
	}

	public void save(Product product){
		 productRepository.save(product);
	}
}
