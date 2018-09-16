using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoClassLibrary.Interfaces;

namespace ToDoClassLibrary
{
	/// <summary>
	/// Класс UserTaskList. Содержит метод, возвращающий Task с коллекцией задач
	/// </summary>
	class UserTaskList : IUserTaskList
	{
		private static readonly List<UserTask> taskList = new List<UserTask>
			{
				new UserTask {Id = 1, CreatedWhen = DateTime.Today, Title = "Task1"},
				new UserTask {Id = 2, CreatedWhen = DateTime.Today, Title = "Task2"},
				new UserTask {Id = 3, CreatedWhen = DateTime.Today, Title = "Task3"},
				new UserTask {Id = 4, CreatedWhen = DateTime.Today, Title = "Task4"},
				new UserTask {Id = 5, CreatedWhen = DateTime.Today, Title = "Task5"},
				new UserTask {Id = 6, CreatedWhen = DateTime.Today, Title = "Task6"},
				new UserTask {Id = 7, CreatedWhen = DateTime.Today, Title = "Task7"},
				new UserTask {Id = 8, CreatedWhen = DateTime.Today, Title = "Task8"},
				new UserTask {Id = 9, CreatedWhen = DateTime.Today, Title = "Task9"},
				new UserTask {Id = 10, CreatedWhen = DateTime.Today, Title = "Task10"}
			};

		
		public Task<List<UserTask>> GetTaskList()
		{
			return Task.FromResult(taskList);
		}
	}
}
