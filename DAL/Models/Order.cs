using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
	public class Order
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Column("OrderId")]
		public int OrderId { get; set; }

		[Column("OrderDate")]
		[DataType(DataType.DateTime)]
		public DateTime OrderDate { get; set; }

		[Column("ProductId")]
		[Required]
		public int ProductId { get; set; }
		[Column("CustomerId")]
		[Required]
		public int CustomerId { get; set; }
	}
}
