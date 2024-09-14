using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
	public interface IOrderRepo<T>
	{
		T AddOrder(T c);

		T RemoveOrder(T c);

		T UpdateOrder(T c);

		T GetOrderById(int id);

		List<T> GetAllOrder();
	}
}
