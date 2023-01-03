using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskMenager.Models;

namespace TaskMenager.Controllers
{
    public class TaskController : Controller
    {
        private static IList<TaskModel> tasks = new List<TaskModel>()
        {

           new TaskModel(){TaskID = 1, Name= "Wizyta u lekarza", Description = "Godzina 17:00", Done = false },
           new TaskModel(){TaskID = 2, Name= "Zrobić obiad", Description = "Pierogi", Done = false },
        };
        // GET: Task
        public ActionResult Index()
        {
            return View(tasks.Where(x=>!x.Done));
        }

        // GET: Task/Details/5
        public ActionResult Details(int id)
        {
            return View(tasks.FirstOrDefault(x=>x.TaskID==id));
        }

        // GET: Task/Create
        public ActionResult Create()
        {
            return View(new TaskModel());
        }

        // POST: Task/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TaskModel taskModel)
        {
            taskModel.TaskID = tasks.Count + 1;  
            tasks.Add(taskModel);
                return RedirectToAction(nameof(Index));
           
        }

        // GET: Task/Edit/5
        public ActionResult Edit(int id)
        {
            return View(tasks.FirstOrDefault(x => x.TaskID == id));
        }

        // POST: Task/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, TaskModel taskModel)
        {
                TaskModel task = tasks.FirstOrDefault(x => x.TaskID == id);
            task.Name = taskModel.Name;
            task.Description = taskModel.Description;

            return RedirectToAction(nameof(Index));
            
           
        }

        // GET: Task/Delete/5
        public ActionResult Delete(int id)
        {
            return View(tasks.FirstOrDefault(x=>x.TaskID==id));
        }

        // POST: Task/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, TaskModel taskModel)
        {
           TaskModel task = tasks.FirstOrDefault(x => x.TaskID == id);
            tasks.Remove(task);
            return RedirectToAction(nameof(Index));
            }
        //GET: Task/Done/5
        public ActionResult Done(int id)
        {
            TaskModel task = tasks.FirstOrDefault(x => x.TaskID == id);
            task.Done = true;

            return RedirectToAction(nameof(Index));
        }
        
    }
}
