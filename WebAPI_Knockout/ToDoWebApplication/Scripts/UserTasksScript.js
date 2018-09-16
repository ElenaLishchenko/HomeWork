'use strict';
//ВьюМодель, содержащая observableArray, который будет заполняться UserTask,
//полученными с сервера
class AppViewModel {

	constructor() {
		this.tasks = ko.observableArray();
	}

//Метод, получающий коллекцию UserTask.
//Полученные данные форматируются и добавляются к массиву tasks
	GetAllTasks() {
		var self = this;
		$.ajax({
			url: '/api/values',
			type: 'GET',
			dataType: 'json',
			success: function (data) {
				for (var i = 0; i < data.length; i++) {
					data[i].CreatedWhen = FormatDate(data[i].CreatedWhen);
					var dataToString = DataToString(data[i]);
					self.tasks.push(dataToString);
				}
			},
			error: function (x, y, z) {
				alert(x + '\n' + y + '\n' + z);
			}
		});
	}

}

//Функция, форматирующая дату. Использует библиотеку Moment.js
var DataToString = function (data) {
	var compiled = _.template('Задача:<%= data.Title %> Создана <%= data.CreatedWhen %>');
	return compiled({'data': data })
}

//Функция, объединяющая Title и дату в одну строку. Использует библиотеку lodash
var FormatDate = function (date) {
	moment.locale('ru');
	var newDate = moment(date).add(9,'days');
	return newDate.format('Do MMMM YYYY');
};

//Создание нового экземпляра ВьюМодели для Binding
ko.applyBindings(new AppViewModel());
