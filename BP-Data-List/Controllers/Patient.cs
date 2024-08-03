using Microsoft.AspNetCore.Mvc;
using TPAssignment_1.Models;

namespace TPAssignment_1.Controllers
{
    public class Patient : Controller
    {
        private bpContext context { get; set; }

        public Patient(bpContext ctx)
        {
            context = ctx;
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            ViewBag.Position = context.Position.OrderBy(g => g.Name).ToList();
            return View("Edit", new BP());
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            ViewBag.Position = context.Position.OrderBy(g => g.Name).ToList();

            var patient = context.BloodPressures.Find(id);

            return View(patient);
        }

        [HttpPost]
        public IActionResult Edit(BP bp)
        {
            if (ModelState.IsValid)
            {
                if (bp.Id == 0)
                    context.BloodPressures.Add(bp);
                else
                    context.BloodPressures.Update(bp);
                context.SaveChanges();
                return RedirectToAction("AllBP", "Patients");
            }
            else
            {
                ViewBag.Action =
                    (bp.Id == 0) ? "Add" : "Edit";
                ViewBag.Position = context.Position.OrderBy(g => g.Name).ToList();
                return View(bp);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var patient = context.BloodPressures.Find(id);
            return View(patient);
        }

        [HttpPost]
        public IActionResult Delete(BP bp)
        {
            context.BloodPressures.Remove(bp);
            context.SaveChanges();
            return RedirectToAction("AllBP", "Patients");
        }
    }
}
