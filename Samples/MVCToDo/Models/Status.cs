using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace MVCToDo.Models
{
	public class Status
	{
		public int StatusID { get; set; }
		public string Title { get; set; }
		public virtual List<Status> Statuses { get; set; }
	}
}
