using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using DesignerUnityOfWork.Data.Repositories;
using DesignerUnityOfWork.Interfaces.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DesignerUnityOfWork.Controllers
{
    public class MovieController : Controller
    {
        private readonly UnitOfWork _unitOfWork;

        public MovieController(IUnityOfWork unityOfWork)
        {
            this._unitOfWork = unityOfWork as UnitOfWork;
        }

        public IActionResult Index()
        {
            dynamic model = new ExpandoObject();
            model.Movies = this._unitOfWork.MovieRepository.GetTopMovieInYear(2016, 5);
            return View("MoviesDetailViews", model);
        }
    }
}