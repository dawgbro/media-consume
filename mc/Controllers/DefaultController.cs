using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mc.Models;

namespace mc.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        [AcceptVerbs("POST")]
        [ActionName("Index")]

        public string Index(Movie movie)
        {


            return movie.MovieName;
        }
    }
}