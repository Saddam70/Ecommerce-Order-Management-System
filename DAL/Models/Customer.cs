using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
	public class Customer
	{
		[Key]
		public int CustomerId { get; set; }

		[Required, StringLength(50)]
		public string FullName { get; set; }

		

		[Required, EmailAddress]
		public string Email { get; set; }

		public string PhoneNumber { get; set; }
		public string Address { get; set; }
		

	}
}
