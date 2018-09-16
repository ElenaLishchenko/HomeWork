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
		private readonly IRepository _taskRepository;

		public TaskService(IRepository taskRepository)
		{
			this._taskRepository = taskRepository;
		}
		 
		public async Task<int> GetTaskCount()
		{
			var taskList = await _taskRepository.ReadAll();
			return taskList.Count;
		}

		public async Task<bool> AddTask(string title)
		{
			if (!title.IsNullOrWhiteSpace())
			{
				return await _taskRepository.Create(new UserTask
				{
					CreatedWhen = DateTime.Today,
					Title = title
				});
			}

			return false;
		}

		public async Task<List<UserTask>> GetAllTask()
		{
			return await _taskRepository.ReadAll();
		}

		public async Task<bool> UpdateTask(UserTask task)
		{
			return await _taskRepository.Update(task);
		}

		public async Task<bool> DeleteTask(int id)
		{
			return await _taskRepository.Delete(id);
		}
	}
}
