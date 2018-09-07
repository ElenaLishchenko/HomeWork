using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoClassLibrary.Interfaces;

namespace ToDoClassLibrary
{
	/// <summary>
	/// Репозиторий, содержащий методы для CRUD-операций с задачами
	/// </summary>
	class TaskRepository: IRepository
	{
		private IUserTaskList userTaskList;

		public TaskRepository(IUserTaskList userTaskList)
		{
			this.userTaskList = userTaskList;
		}

		public async Task<bool> Create(UserTask task)
		{
			var taskList = await userTaskList.GetTaskList();
			if (!taskList.Contains(task))
			{
				taskList.Add(task);
				return true;
			}

			return false;
		}

		public async Task<UserTask> Read(int id)
		{
			var taskList = await userTaskList.GetTaskList();
			return taskList.Find(x => x.Id == id);
		}

		public async Task<List<UserTask>> ReadAll()
		{
			return await userTaskList.GetTaskList(); 
		}

		public async Task<bool> Update(UserTask task)
		{
			var taskList = await userTaskList.GetTaskList();
			var taskIndex = taskList.FindIndex(x => x.Id == task.Id);
			if (taskIndex>=0)
			{
				taskList[taskIndex] = task;
				return true;
			}

			return false;
		}

		public async Task<bool> Delete(int id)
		{
			var taskList = await userTaskList.GetTaskList();
			var taskIndex = taskList.FindIndex(x => x.Id == id);
			if (taskIndex >= 0)
			{
				taskList.RemoveAt(taskIndex);
				return true;
			}

			return false;
		}
	}
}
