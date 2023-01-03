using TaskMenager.Models;

namespace TaskMenager.Repositories
{
    public class TaskRepository : ITaskRepository
    {

        public TaskModel Get(int taskID)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TaskModel> GetAllActive()
        {
            throw new NotImplementedException();
        }
        public void Add(TaskModel task)
        {
            throw new NotImplementedException();
        }

        public void Update(int taskID, Task task)
        {
            throw new NotImplementedException();
        }
        public void Delete(int taskID)
        {
            throw new NotImplementedException();
        }



     
    }
}
