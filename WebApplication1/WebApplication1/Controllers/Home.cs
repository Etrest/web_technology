using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class Home : Controller
    {

        public string Text { get; set; }
        public IActionResult Index()
        {
            Text = "Лабораторная работа 2";
            return View();
        }
        public class ListDemo
        {
            public int ListItemValue { get; set; }
            public string ListItemText { get; set; }
        }

        internal List<ListDemo> _listDemo;

        public Home()
        {
            _listDemo = new List<ListDemo>
                {
                new ListDemo{ ListItemValue=1, ListItemText="Item 1"},
                new ListDemo{ ListItemValue=2, ListItemText="Item 2"},
                new ListDemo{ ListItemValue=3, ListItemText="Item 3"}
                };
        }




    }
}
