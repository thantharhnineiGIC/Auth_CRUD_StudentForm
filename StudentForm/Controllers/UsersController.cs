using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using StudentForm.Areas.Identity.Data;
using StudentForm.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace StudentForm.Controllers
{
    public class UsersController : Controller
    {
        private readonly AuthDbContext _db;

        public UsersController(AuthDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            string connectionString = "Data Source=DESKTOP-TQS1JN3\\SQLEXPRESS;Initial Catalog=StudentDb;Integrated Security=True";
            string query = "SELECT * FROM AspNetUsers";

            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                    {
                        dataAdapter.Fill(dataTable);
                    }
                }
            }

            string jsonData = Newtonsoft.Json.JsonConvert.SerializeObject(dataTable);
            HttpContext.Session.SetString("DataTableKey", jsonData);
            return View(dataTable);
        }

        public IActionResult SessionTest()
        {
            string jsonData = HttpContext.Session.GetString("DataTableKey");

            DataTable dataTable = new DataTable();
            if (!string.IsNullOrEmpty(jsonData))
            {
                dataTable = Newtonsoft.Json.JsonConvert.DeserializeObject<DataTable>(jsonData);
            }
            return View(dataTable);
        }
    }
}
