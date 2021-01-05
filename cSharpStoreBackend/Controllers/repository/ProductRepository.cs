using System.Collections.Generic;
using System.Linq;
using cSharpStoreBackend.Models;

namespace cSharpStoreBackend.Controllers.repository{

	public class ProductRepository : IProductRepository{
		
		private readonly postgresContext context;

		public ProductRepository(){
			context = new postgresContext(); 
		}
	
		public ProductRepository(postgresContext contexto){
			context = contexto; 
		}
		
		IEnumerable<Product> IProductRepository.GetAll(){
			return context.Products.ToList();
		}
	}
}
