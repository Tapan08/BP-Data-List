using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TPAssignment_1.Models;

namespace TPAssignment_1.Controllers
{
    public class Patients : Controller
    {
        private bpContext context { get; set; }

        public Patients(bpContext ctx)
        {
            context = ctx;
        }


        public IActionResult AllBP()
        {
            var patients = context.BloodPressures.Include(b => b.Position).OrderBy(b => b.systolic).ToList();
            return View(patients);
        }

    }
}
