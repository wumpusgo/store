using System.Collections.Generic;
using cSharpStoreBackend.Models;

namespace cSharpStoreBackend.Controllers.repository{
	
	public interface IProductRepository{
		
		IEnumerable<Product> GetAll();
        	/* Product GetById(int ProductID); */
        	/* void Insert(Product product); */
        	/* void Update(Product product); */
        	/* void Delete(int ProducID); */
        	/* void Save(); */
	}
}
