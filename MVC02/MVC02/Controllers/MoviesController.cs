using Microsoft.AspNetCore.Mvc;
using MVC02.Models;
using System.Globalization;

namespace MVC02.Controllers
{
    public class MoviesController : Controller
    {
        // Action => Public, Non Static Method Inside Controller

        // To Execute Any Action => BaseUrl + ControllerName + ActionName


        public string Index ( int id)
        {
            return  $"Hello, {id}";
        }

        public IActionResult GetMovie(int? id,string name)
        {
            //ContentResult result = new ContentResult();
            //result.Content = $"Movie:{name} <br> ID: {id} ";
            //result.ContentType = "text/html" ;
            //result.StatusCode= 200 ;

            //return Content($"Movie:{name} <br> ID: {id} ", "text/html") ;

            //if (id is not null)
            //    return $"Movie: **** ,ID: {id}";
            //else
            //    return "No Movie";

            if (id == 0)
                return new BadRequestResult();
            else if (id < 10)
                return NotFound();
            else
                return Content($"Movie: {name} ,ID: {id}");

        }

        public IActionResult TestRedirectionAction(){
        return Redirect("https://www.google.com"); 
        }

        public IActionResult TestRedirectionActionToGetMovie(Movie movie)
        {
            return RedirectToAction("GetMovie", new {id=30,name="Inception"});
        }

        public IActionResult TestModelBinding([FromRoute]int id, string name)
        {
            return Content($"Movie: {name} ,ID: {id}");
        }

    }

}
