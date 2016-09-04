

using PoC.Easy.Dto.Users.Queries;
using PoC.Easy.Model;
using PoC.Easy.Model.Interfaces;
using System.Web.Mvc;

namespace PoC.Easy.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IQueryHandler<AllUsersQuery, MegaWorkContext> _allUsersQueryHandler;
        public HomeController(IQueryHandler<AllUsersQuery, MegaWorkContext> allUsersQueryHandler)
        {
            _allUsersQueryHandler = allUsersQueryHandler;
        }
        // GET: Home
        public ActionResult Index(AllUsersQuery query)
        {
            var model = _allUsersQueryHandler.Execute(query);

            //В данном случае не важен движок рендеринга вью
            //Модель мы собираем извне и передаем в слой рендеринга.
            return View(model);
        }
    }
}