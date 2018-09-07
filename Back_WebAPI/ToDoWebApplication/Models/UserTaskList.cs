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
				new UserTask {Id = 1, createdWhen = DateTime.Today, title = "Task1"},
				new UserTask {Id = 2, createdWhen = DateTime.Today, title = "Task2"},
				new UserTask {Id = 3, createdWhen = DateTime.Today, title = "Task3"},
				new UserTask {Id = 4, createdWhen = DateTime.Today, title = "Task4"},
				new UserTask {Id = 5, createdWhen = DateTime.Today, title = "Task5"},
				new UserTask {Id = 6, createdWhen = DateTime.Today, title = "Task6"},
				new UserTask {Id = 7, createdWhen = DateTime.Today, title = "Task7"},
				new UserTask {Id = 8, createdWhen = DateTime.Today, title = "Task8"},
				new UserTask {Id = 9, createdWhen = DateTime.Today, title = "Task9"},
				new UserTask {Id = 10, createdWhen = DateTime.Today, title = "Task10"}
			};

		
		public Task<List<UserTask>> GetTaskList()
		{
			return Task.FromResult(taskList);
		}
	}
}
