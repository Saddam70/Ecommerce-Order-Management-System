using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
	public interface ICustomerRepo<T>
	{
		//T RegisterCustomer(T customer);

		//T UpdateCustomerProfile(T customer);

		//T DeleteCustomer(T customer);

		//T ValidateCustomer(T customer);
		T AddCustomer(T c);

		T RemoveCustomer(T c);

		T UpdateCustomer(T c);

		T GetCustomerById(int id);

		List<T> GetAllCustomer();
		//Task<IEnumerable<Customer>> GetAllCustomersAsync();
		//Task<Customer> GetCustomerByIdAsync(int customerId);
		//Task AddCustomerAsync(Customer customer);
		//Task UpdateCustomerAsync(Customer customer);
		//Task DeleteCustomerAsync(int customerId);

	}
}
