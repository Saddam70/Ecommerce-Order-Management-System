using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
	public interface IOrderItemRepo<T>
	{
		T AddOrderItem(T c);

		T RemoveItem(T c);

		T UpdateItem(T c);

		T GetItemById(int id);

		List<T> GetAllItem();
	}
}
