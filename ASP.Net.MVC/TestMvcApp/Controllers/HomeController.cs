//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
using System;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TestMvcApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        //public IActionResult Index()
        //{
        //    return View();
        //}

        [ActionName("Welcome3")]
        public IActionResult Index()
        {
            return new HtmlResult("<h2>Hello METANIT.COM!</h2>");
        }

        [ActionName("Welcome4")]
        public JsonResult GetName()
        {
            return Json("Tom");
        }

        //public string Index()
        //{
        //    return "Hello METANIT.COM";
        //}

        //[HttpGet]
        //public string Index() => "Hello METANIT.COM";
        //public string Index(string name, int age) => $"Your name: {name}, age: {age}"; //если не передать пераметры, то будут использованы параметры по умолчанию.
        //public string Index(string name = "Bob", int age = 33) => $"Your name: {name}, age: {age}"; //в этой строке параметры по умолчанию заданы
        //public string Hello() => "Hello ASP.NET";

        //[HttpGet]
        //public async Task Index()
        //{
        //    string content =
        //        @"<form method='post'>
        //            <label>Name:</label><br />
        //            <input name='name' /><br />
        //            <label>Age:</label><br />
        //            <input type='number' name='age' /><br />
        //            <input type='submit' value='Send' />
        //        </form>";
        //    Response.ContentType = "text/html;charset=utf-8";
        //    await Response.WriteAsync(content);
        //}
        //[HttpPost]
        //public string Index(string name, int age) => $"{name}: {age}";




        [ActionName("Welcome")]
        public string Hello()
        {
            return "Hello ASP.NET";
        }

        [ActionName("Welcome2")]
        public async Task Index2()
        {
            Response.ContentType = "text/html;charset=utf-8";
            System.Text.StringBuilder tableBuilder = new("<h2>Request headers</h2><table>");
            foreach (var header in Request.Headers)
            {
                tableBuilder.Append($"<tr><td>{header.Key}</td><td>{header.Value}</td></tr>");
            }
            tableBuilder.Append("</table>");
            await Response.WriteAsync(tableBuilder.ToString());
        }
    }
}

