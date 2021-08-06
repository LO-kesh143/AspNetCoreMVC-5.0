using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LKGGroup.Bookstore.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using LKGGroup.Bookstore.Reopsitory;
using LKGGroup.Bookstore.Service;

namespace LKGGroup.Bookstore.Controllers
{
    public class HomeController : Controller
    {
        private readonly NewBookAlertConfig _newBookAlertconfiguration;
        private readonly NewBookAlertConfig _newThirdParyBookAlertconfiguration;
        private readonly IMessageRepository _messageRepository;
        private readonly IUserService _userService;
        //private readonly IEmailService _emailService;

        public HomeController(IOptionsSnapshot<NewBookAlertConfig> newBookAlertconfiguration, 
            IMessageRepository messageRepository,
            IUserService userService)
         //   IEmailService emailService)
        {
            _newBookAlertconfiguration = newBookAlertconfiguration.Get("InternalBooks");
            _newThirdParyBookAlertconfiguration = newBookAlertconfiguration.Get("ThirdPartyBooks");
            _messageRepository = messageRepository;
            _userService = userService;
          //  _emailService = emailService;
        }

        [Route("")]
        public ViewResult Index()
        {
            return View();
        }
        /* UserEmailOptions options = new UserEmailOptions()
         {
             ToEmails = new List<string>() { "test@gmail.com" }
         };

         await _emailService.SendTestEmail(options); */

        //var userId = _userService.GetUserId();
        //var isLoggedIn = _userService.IsAuthenticated();

        //var newBookAlert = new NewBookAlertConfig();
        //_newBookAlertconfiguration.Bind("NewBookAlert", newBookAlert);

        //bool isDisplay = _newBookAlertconfiguration.DisplayNewBookAlert;
        //string display = _newBookAlertconfiguration.BookName;
        //bool isDisplay1 = _newThirdParyBookAlertconfiguration.DisplayNewBookAlert;
        //string display1 = _newThirdParyBookAlertconfiguration.BookName;

        // var value = _messageRepository.GetName();

        //var newBook = _configuration.GetSection("NewBookAlert");

        //var result = newBook.GetValue<bool>("DisplayNewBookAlert");
        //var bookName = newBook.GetValue<string>("BookName");

        //var result1 = _configuration["DisplayNewBookAlert"];
        //var result = _configuration["AppName"];
        //var key1 = _configuration["infoObj:key1"];
        //var key2 = _configuration["infoObj:key2"];
        //var key3 = _configuration["infoObj:key3:key3obj1"];




        [Route("about-us")]
        public ViewResult AboutUs()
        {
            return View();
        }

        [Route("contact-us")]
        public ViewResult ContactUs()
        {
            return View();
        }
    }
}
