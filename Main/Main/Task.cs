public class Task
{
    public string Title;
    public string Description;
    public TaskStatus Status;

    public void ChangeStatus(TaskStatus newStatus)
    {
        Status = newStatus;
    }
}