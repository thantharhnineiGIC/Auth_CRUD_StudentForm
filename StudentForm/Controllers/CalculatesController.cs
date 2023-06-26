using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentForm.Data;
using StudentForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentForm.Controllers
{
    public class CalculatesController : Controller
    {
        private readonly CalculateDbContext _context;

        public CalculatesController(CalculateDbContext context)
        {
            _context = context;
        }
        // GET: Calculates
        public async Task<IActionResult> Index()
        {
            if (TempData.ContainsKey("SuccessMessage"))
            {
                string successMessage = TempData["SuccessMessage"].ToString();
                ViewData["SuccessMessage"] = successMessage;
            }
            return View(await _context.Calculate.ToListAsync());
        }

        [HttpPost]
        public IActionResult Create(int firstNum, int secondNum)
        {
            if (ModelState.IsValid)
            {
                var result = firstNum + secondNum;

                var calculate = new Calculate
                {
                    FirstNum = firstNum,
                    SecondNum = secondNum,
                    Result = result
                };

                _context.Calculate.Add(calculate);
                _context.SaveChanges();

                TempData["SuccessMessage"] = "Data Created successfully!";
                return RedirectToAction("Index");
            }

            // If the form data is not valid, return the view
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, int firstNum, int secondNum)
        {
            var calculate = await _context.Calculate.FindAsync(id);
            if (calculate == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                calculate.FirstNum = firstNum;
                calculate.SecondNum = secondNum;
                calculate.Result = firstNum + secondNum; // Calculate the result

                _context.Update(calculate);
                await _context.SaveChangesAsync();

                TempData["SuccessMessage"] = "Data updated successfully!";
                return RedirectToAction("Index");
            }

            // If the form data is not valid, return the view with the existing model
            return RedirectToAction("Index");
        }





    }
}
