using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using ToDoClassLibrary;
using ToDoClassLibrary.Interfaces;

namespace ToDoWebApplication.Controllers
{
	/// <summary>
	/// Контроллер, обеспечивает доступ и обработку данных с использованием сервиса TaskService
	/// </summary>
	public class ValuesController : ApiController
	{
		private IService taskService;

		public ValuesController(IService taskService)
		{
			this.taskService = taskService;
		}

		// GET api/<controller>
		public Task<List<UserTask>> GetAllTasks()
		{
			return taskService.GetAllTask();
		}

		// GET api/<controller>/5
		public Task<int> GetCount(int id)
		{
			return taskService.GetTaskCount();
		}

		// POST api/<controller>
		public void Post([FromBody]string value)
		{
		}

		// PUT api/<controller>/5
		public void Put(int id, [FromBody]string value)
		{
		}

		// DELETE api/<controller>/5
		public void Delete(int id)
		{
		}
	}
}
