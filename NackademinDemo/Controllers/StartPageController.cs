using EPiServer;
using EPiServer.Data.Dynamic;
using EPiServer.ServiceLocation;
using NackademinDemo.Abstractions;
using NackademinDemo.Models;
using NackademinDemo.Models.Pages;
using NackademinDemo.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace NackademinDemo.Controllers
{
    public class StartPageController : PageControllerBase<StartPage>
    {
        private IContentRepository _contentRepository = ServiceLocator.Current.GetInstance<IContentRepository>();
        private IDdsService _ddsService = ServiceLocator.Current.GetInstance<IDdsService>();

        public ActionResult Index(StartPage currentPage)
        {
            var createMovies = _ddsService.CreateMovies();

            //dds
            _ddsService.CreateStore(createMovies);

            _ddsService.GetMovies();

            //DeleteMovies();

            //var newMovies = GetMovies();

            var model = new StartPageViewModel(currentPage)
            {
                Food = _contentRepository.GetChildren<FoodPage>(currentPage.ContentLink).ToList()
            };

            return View(model);
        }

    }
}