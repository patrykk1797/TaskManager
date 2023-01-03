using TaskMenager.Models;

namespace TaskMenager.Repositories
{
    public interface ITaskRepository
    {
        TaskModel Get(int taskID);
        IQueryable<TaskModel> GetAllActive();
        void Add (TaskModel task);
        void Update (int taskID, Task task);
        void Delete (int taskID);

    }
}
