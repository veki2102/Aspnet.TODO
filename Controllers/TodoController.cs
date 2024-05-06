using AspNet.TODO.Repository;
using Microsoft.AspNetCore.Mvc;

namespace AspNet.TODO.Controllers
{
    public class TodoController : Controller
    {

        private TodoRepository _tasks;


        
        // GET: TodoController
        public ActionResult Index()
        {
            _tasks = new TodoRepository();

            //dolazimo do svih taskova
            var tasks = _tasks.GetTodoListData();

            //prosljedujemo u View taj popis taskova
            return View(tasks);
        }


    }


}
