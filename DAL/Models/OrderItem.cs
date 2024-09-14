using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
	public class OrderItem
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int OrderItemId { get; set; }

		[Required]
		[Column("OrderId")]
		public int OrderId { get; set; }

		[Required]
		[Column("ProductId")]
		public int ProductId { get; set; }

		[Required]
		[Column("Quantity")]
		public double Quantity { get; set; }

		[Required]
		[Column("SalesPrice")]
		public double SalesPrice { get; set; }

		[Required]
		[Column("TotalAmount")]
		public double TotalAmount { get; set; }
	}
}
