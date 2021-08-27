namespace BasicWebApp.Web.Areas.Administration.Controllers
{
    using BasicWebApp.Web.ViewModels.Administration.Dashboard;

    using Microsoft.AspNetCore.Mvc;

    public class DashboardController : AdministrationController
    {


        public DashboardController()
        {

        }

        public IActionResult Index()
        {
            return this.View();
        }
    }
}
