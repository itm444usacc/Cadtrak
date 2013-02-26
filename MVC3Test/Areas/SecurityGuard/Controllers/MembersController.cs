using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dapper;
using MVC3Test.Areas.SecurityGuard.Models;
using MVC3Test.Areas.ViewModels;
using MySql.Data.MySqlClient;

namespace MVC3Test.Areas.SecurityGuard.Controllers
{
    public class MembersController : Controller
    {
        public MySqlConnection Connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);

        public MySqlCommand Cmd;


        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            var viewModel = new MembersViewModel();

            return View("Create", viewModel);
        }
        [HttpPost]
        public ActionResult Create(MembersViewModel viewModel)
        {

            const string sqlconn = @" INSERT INTO Memmbers (FirstName, MiddleName, LastName, Nickname, Username,
                                                      Admin, Expired, Active, AcceptedTerms, Created, Status, userId)
                                                  VALUES (@FirstName, @MiddleName, @LastName, @Nickname, @Username,
                                                      @Admin, @Expired, @Active, @AcceptedTerms, @Created, @Status, @userId)
                                                  WHERE Id = @Id";

            Cmd = new MySqlCommand(sqlconn, Connection);

            Connection.Open();

            //var result = Connection.Execute(sqlconn, new {  });

            Connection.Close();

            return View("Create");
        }

        public ActionResult Edit()
        {
            return View("Edit");
        }

    }
}
