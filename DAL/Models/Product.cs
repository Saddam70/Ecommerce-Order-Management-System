using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
	public class Product
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Column("ProductId")]
		public int ProductId { get; set; }

		[StringLength(maximumLength: 50)]
		[Required]
		[Column("ProductName")]
		public string? ProductName { get; set; }

		[StringLength(maximumLength: 50)]
		[Required]
		[Column("Category")]
		public string? Category { get; set; }


		[Required]
		[Column("ListPrice")]
		public double ListPrice { get; set; }
	}
}
