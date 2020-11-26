using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LabTesttTwo.Data;
using LabTesttTwo.Models;
using Microsoft.AspNetCore.Mvc;

namespace LabTesttTwo.Controllers
{
    public class StudentController : Controller
    {
        private readonly IncomeTaxDbContext _context;
    
        public StudentController(IncomeTaxDbContext _context)
        {
            this._context = _context;
        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult StudentRejestision()
        {
            return View();
        }

        [HttpPost]
        public IActionResult StudentRejestision(StudentRegistrationViewModel model)
        {

            if (ModelState.IsValid)
            {
                StudentRegistration student = new StudentRegistration
                {
                    name = model.name,
                    clsName = model.clsName,
                    roll = model.roll,
                    dept = model.dept,
                    father = model.father,
                    mother = model.mother,
                    mobile = model.mobile,
                    email = model.email,
                    present = model.present,
                    parmanent = model.parmanent,
                    cretedAt = DateTime.Now
                };

                _context.StudentRegistrations.Add(student);
                _context.SaveChanges();

            }
            else
            {
                return View(model);
            }


            return View();
        }

        public IActionResult StudentReg()
        {
            return View();
        }

        [HttpPost]
        public IActionResult StudentReg(StudentRegViewModel model)
        {
            StudentReg student = new StudentReg
            {
                name = model.name,
                cls = model.cls,
                dept = model.dept,
                roll = model.roll,
                father = model.father,
                mother = model.mother,
                mobile = model.mobile,
                email = model.email,
                present = model.present,
                parmanent = model.parmanent
            };

            _context.StudentRegs.Add(student);
            _context.SaveChanges();
            return View();
        }
        //contolar end
    }

}