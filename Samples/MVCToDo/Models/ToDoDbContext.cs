using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCToDo.Models
{
	public class ToDoDbContext : DbContext
	{
		public DbSet<ToDo> ToDos { get; set; }

		public DbSet<Status> Statuses { get; set; }
	}
}