using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoClassLibrary.Interfaces
{
	interface IRepository
	{
		Task<bool> Create(UserTask task);
		Task<UserTask> Read(int id);
		Task<List<UserTask>> ReadAll();
		Task<bool> Update(UserTask task);
		Task<bool> Delete(int id);
	}
}
