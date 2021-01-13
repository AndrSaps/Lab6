using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DL;
using DL.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using mvcLayer.Models;

namespace mvcLayer.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var repository = new Repository<User>();

            ViewBag.Users = repository.GetAll();
            return View();
        }

        [HttpGet]
        public IActionResult Details(int Id)
        {
            var repository = new Repository<User>();

            ViewBag.User = repository.GetAll().Include(_ => _.Messages).ThenInclude(_ => _.Message)
                .Include(_ => _.Rights).ThenInclude(_ => _.Right).First(_ => _.Id == Id);

            return View();
        }



        [HttpGet]
        public IActionResult EditMessage(int Id)
        {
            var repository = new Repository<Message>();

            Message message = repository.GetById(Id);

            return View(message);
        }


        [HttpGet]
        public IActionResult DeleteMessage(int Id)
        {
            var repository = new Repository<Message>();

            Message message = repository.GetById(Id);

            repository.Remove(message);

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult EditMessage(Message message)
        {
            var repository = new Repository<Message>();

            repository.Update(message);

            return RedirectToAction("Index");

        }

        [HttpGet]
        public IActionResult CreateMessage(int Id)
        {
            ViewBag.Id = Id;

            return View();
        }


        [HttpPost("{id}")]
        public IActionResult CreateMessage(Message message, int UserId)
        {
            var repository = new Repository<Message>();
            message.Id = 0;

            repository.Create(message);

            message.Users = new List<UserMessage>();

            message.Users.Add(new UserMessage()
            {
                ID_MESSAGE = message.Id,
                ID_USER = UserId
            });

            repository.Update(message);


            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditRight(int Id)
        {
            var repository = new Repository<Right>();

            var right = repository.GetById(Id);

            return View(right);
        }

        [HttpPost]
        public IActionResult EditRight(Right message)
        {
            var repository = new Repository<Right>();

            repository.Update(message);

            return RedirectToAction("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
