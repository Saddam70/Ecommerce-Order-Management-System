using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
	public interface IProductRepo<T>
	{
		T AddProduct(T product);

		T RemoveProduct(T product);

		T UpdateProduct(T product);

		T GetProductById(int id);

		List<T> GetAllProducts();
	}
}
