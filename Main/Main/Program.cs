using System;

internal class Program
{
    static void Main(string[] args)
    {
        Task task = new Task()
        {
            Title = "Сделать pull request",
            Description = "Но сначала отформатировать код",
            Status = TaskStatus.Testing
        };
        Console.WriteLine($"Статус задачи <{task.Title}> - {task.Status}");
        task.ChangeStatus(TaskStatus.Completed);
        Console.WriteLine($"Статус задачи <{task.Title}> - {task.Status}");
    }
}
