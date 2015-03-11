using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoSample.Models
{
	public class ToDoItem
	{
		public int ToDoItemID { get; set; }

		[Required()]
		public string Title { get; set; }
		
		[Required()]
		public string Status { get; set; }
	}
}
