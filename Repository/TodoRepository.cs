using AspNet.TODO.Models;
using static System.Reflection.Metadata.BlobBuilder;


namespace AspNet.TODO.Repository


{
    public class TodoRepository
    {
        public static List<Todo> TodoList;


        public TodoRepository()
        {

            if (TodoList == null)
            {

                TodoList = new List<Todo>();


                CreateTodoListData();

            }


        }




        public List<Todo> GetTodoListData()
        {
            
            return TodoList;
        }





        public void CreateTodoListData()
        {

            Todo z1 = new Todo()
            {
                ID = 1,
                Naziv="Planiraj godišnji odmor",
                Rok=new DateOnly(2024,6,1)
               
            };

            TodoList.Add(z1);



            Todo z2 = new Todo()
            {
                ID = 2,
                Naziv = "Obavi kupnju",
                Rok = new DateOnly(2024, 5, 10)

            };

            TodoList.Add(z2);



            Todo z3 = new Todo()
            {
                ID = 3,
                Naziv = "Odlazak kod zubara",
                Rok = new DateOnly(2024, 5, 20)

            };

            TodoList.Add(z3);




            Todo z4 = new Todo()
            {
                ID = 4,
                Naziv = "Auto - veliki servis",
                Rok = new DateOnly(2024, 6, 15)

            };

            TodoList.Add(z4);



            Todo z5 = new Todo()
            {
                ID = 5,
                Naziv = "Dječja predstava",
                Rok = new DateOnly(2024, 6, 13)

            };

            TodoList.Add(z5);





        }






    }



}
