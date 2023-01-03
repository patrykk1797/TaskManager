using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TaskMenager.Models
{
    public class TaskModel
    {
        public int TaskID { get; set; }
       [DisplayName("Nazwa")]
        public string Name { get; set; }
        [DisplayName("Opis")]
        public string Description { get; set; }
        public bool Done { get; set; }
    }
}
