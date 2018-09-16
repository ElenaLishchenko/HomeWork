using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using ToDoClassLibrary;
using ToDoClassLibrary.Interfaces;
using ToDoWebApplication.Controllers;

namespace ToDoWebApplication.Tests.Controllers
{
	[TestClass]
	public class ValuesControllerTest
	{
		private static Mock<IService> _service;
		private static ValuesController _controller;
		private static readonly List<UserTask> _taskList = new List<UserTask>
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

		[TestInitialize]
		public void Initialize()
		{
			_service = new Mock<IService>(MockBehavior.Strict);
			_controller =  new ValuesController(_service.Object);
		}

		[TestMethod]
		public void Get()
		{
			//Arrange
			_service.Setup(x => x.GetAllTask().Result).Returns(_taskList);

			// Act
			List<UserTask> result = _controller.GetAllTasks().Result;

			// Assert
			Assert.IsNotNull(result);
			Assert.AreEqual(10, result.Count());
			Assert.AreEqual(_taskList, result);
		}

		[TestMethod]
		public void GetCountTest()
		{
			// Arrange
			_service.Setup(x => x.GetTaskCount().Result).Returns(10);

			// Act
			int result = _controller.GetCount(5).Result;

			// Assert
			Assert.AreEqual(10, result);
		}

	}
}
