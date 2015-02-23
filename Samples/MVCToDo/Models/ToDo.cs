using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.DynamicData;

namespace MVCToDo.Models
{
	[TableName("ToDos")]
	public class ToDo
	{
		[Display(Name = "ID")]
		public int ToDoID { get; set; }
		public String Title { get; set; }
		public int StatusID { get; set; }
		public virtual Status Status { get; set; }
	}
}