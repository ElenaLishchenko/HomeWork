using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Ajax.Utilities;
using ToDoClassLibrary.Interfaces;

namespace ToDoClassLibrary
{
	/// <summary>
	/// Сервис, обуспечивает доступ и обработку данных о задачах.
	/// </summary>
	class TaskService:IService
	{
		private IRepository taskRepository;

		public TaskService(IRepository taskRepository)
		{
			this.taskRepository = taskRepository;
		}
		 
		public async Task<int> GetTaskCount()
		{
			var taskList = await taskRepository.ReadAll();
			return taskList.Count;
		}

		public async Task<bool> AddTask(string title)
		{
			if (!title.IsNullOrWhiteSpace())
			{
				return await taskRepository.Create(new UserTask
				{
					createdWhen = DateTime.Today,
					title = title
				});
			}

			return false;
		}

		public async Task<List<UserTask>> GetAllTask()
		{
			return await taskRepository.ReadAll();
		}
	}
}
