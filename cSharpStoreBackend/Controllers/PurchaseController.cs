using System.Collections.Generic;
using cSharpStoreBackend.Controllers.repository;
using cSharpStoreBackend.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Text.Json;

namespace cSharpStoreBackend.Controllers
{

    [ApiController]
	[Route("purchase")]
	public class PurchaseController : ControllerBase{

		private IProductRepository productRepository; 

		public PurchaseController(){
			productRepository = new ProductRepository();
		}

		[HttpGet("ji")]
		public IEnumerable<Product> GetAll(){
			Console.WriteLine(productRepository.GetAll());
			return productRepository.GetAll();
		}
		
		[HttpPost("send")]
		public void reciboCosas(Purchase algo){
			Console.WriteLine(algo.IdPurchase);
		}
		
		[HttpPost("send2")]
		public void reciboCosas2(JsonElement algo){
			/* var dict = System.Text.Json.JsonSerializer.Deserialize<Dictionary<string, string>>(algo); */
			Console.WriteLine(algo.GetProperty("asd").GetString());
		}
	}
}
