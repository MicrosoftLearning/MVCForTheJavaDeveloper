using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCToDo.Models
{
	public class ToDoDbContextInitializer : DropCreateDatabaseAlways<ToDoDbContext>
	{
		protected override void Seed(ToDoDbContext context)
		{
			context.ToDos.Add(new ToDo() {
				Title = "Sample One",
				Status = context.Statuses.Add(new Status() {Title = "Not Started"})
			});

			context.ToDos.Add(new ToDo() {
				Title = "Sample Two",
				Status = context.Statuses.Add(new Status() { Title = "In Progress" })
			});

			context.ToDos.Add(new ToDo() {
				Title = "Sample Three",
				Status = context.Statuses.Add(new Status() { Title = "Completed" })
			});
		}
	}
}