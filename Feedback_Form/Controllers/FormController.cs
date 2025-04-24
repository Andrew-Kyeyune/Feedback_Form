using Feedback_Form.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Feedback_Form.Controllers
{
    public class FormController : Controller
    {
        private static List<Feedback> Feedbacks = new List<Feedback>
        {
            new Feedback {Customer_ID = 1001, Name = "Andrew", Email_Id = "ctdigital18@gmail.com", Mobile_No = "256772591881" }
        };

        public IActionResult Index()
        {
            return View(Feedbacks); // Corrected reference
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Feedback feedback)
        {
            if (ModelState.IsValid)
            {
                feedback.Customer_ID = Feedbacks.Max(b => b.Customer_ID) + 1; //Sample Id generation
                Feedbacks.Add(feedback);
                return RedirectToAction(nameof(Index));
            }
            return View(Feedbacks);

        }
    }
}
