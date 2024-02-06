using Microsoft.AspNetCore.Mvc;

namespace lr3.Models
{
    public class MenuItem
    {
        // является ли страницей или методом контроллера
        public bool IsPage { get; set; } = false;
        // имя области
        public string Area { get; set; } = "";
        // имя действия контроллера
        public string Action { get; set; } = "";
        // имя контроллера
        public string Controller { get; set; } = "";
        // имя страницы
        public string Page { get; set; } = "";
        // класс CSS для текущего пункта меню
        public string Active { get; set; } = "";
        // текст надписи
        public string Text { get; set; } = "";

        //private List<MenuItem> items = new List<MenuItem>
        //{
        //    new MenuItem{  Controller="Home", Action="Index", Text="lr2"},
        //    new MenuItem{  Controller="Product", Action="Index", Text="Каталог" },
        //    new MenuItem{  IsPage=true, Area="Admin", Page="/Index", Text="Администрирование"}
        //};

    }
}
