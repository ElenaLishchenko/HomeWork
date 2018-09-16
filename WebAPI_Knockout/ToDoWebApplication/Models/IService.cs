using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoClassLibrary.Interfaces
{
	public interface IService
	{
		Task<int> GetTaskCount();
		Task<bool> AddTask(string Title);
		Task<List<UserTask>> GetAllTask();

	}
}
