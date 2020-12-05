package com.store.service;

import java.util.List;

import com.store.model.Category;
import com.store.repository.CategoryRepository;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

@Service
public class CategoryService {

	@Autowired
	private CategoryRepository categoryRepository;

	public List<Category> getAllProducts(){
		return categoryRepository.findAll();
	}
	
	public void save(Category category){
		categoryRepository.save(category);
	}

}
