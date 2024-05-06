using System.ComponentModel;

namespace AspNet.TODO.Models
{
    public class Todo
    {
        public int ID { get; set; }

        [DisplayName("Naziv zadatka")]
        public string Naziv {  get; set; }  
        public DateOnly Rok { get; set; }   

    }

}
