import { Component, OnInit } from '@angular/core';
import { Task } from '../task';
import { TaskService } from '../task.service';

@Component({
  selector: 'app-tasks',
  templateUrl: './tasks.component.html',
  styleUrls: ['./tasks.component.css']
})
export class TasksComponent implements OnInit {
  task: Task;
  tasks: Task[];

  constructor(private taskService: TaskService) { }

  getTasks(): void {
    this.taskService.getTasks()
      .subscribe(value => this.tasks = value);
  }

  ngOnInit() { 
    
  }

}
