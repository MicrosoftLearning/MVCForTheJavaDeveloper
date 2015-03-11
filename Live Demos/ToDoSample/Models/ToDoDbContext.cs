using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoSample.Models
{
	public class ToDoDbContext : DbContext
	{
		public DbSet<ToDoItem> ToDoItems { get; set; }
	}
}
