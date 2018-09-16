using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoClassLibrary.Interfaces
{
	interface IUserTaskList
	{
		Task<List<UserTask>> GetTaskList();
	}
}
