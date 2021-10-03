using Api.DAL;
using Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class EmployerController : ControllerBase
    {
        private readonly AppDbContext _context;

        public EmployerController(AppDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public ActionResult GetEmployer()
        {
            var employer = _context.Employer.ToList();
            if (employer is null)
                return NotFound();
            return Ok(employer);
        }
        [HttpGet]
        [Route("{id}")]
        public ActionResult GetEmployeeById(int id)
        {
            var employer = _context.Employer.FirstOrDefault(m => m.Id == id);
            if (employer is null)
                return NotFound();
            return Ok(employer);
        }

        [HttpPost]
        public ActionResult Create([FromBody] Employer employer)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            _context.Employer.Add(employer);
            _context.SaveChanges();
            return Ok(employer);
        }



        [HttpPut]
        [Route("{id}")]
        public ActionResult Edit(int id, [FromBody] Employer employer)
        {
            var employerDb = _context.Employer.FirstOrDefault(m => m.Id == id);

            if (employerDb is null)
                return NotFound();
            employer.Id = employerDb.Id;
            employer.FullName = employerDb.FullName;
            employer.Address = employerDb.Address;
            employer.Age = employerDb.Age;
            employer.BookID = employerDb.BookID;
            employer.BookName = employerDb.BookName;
            employer.BookPrice = employerDb.BookPrice;
            _context.SaveChanges();
            return Ok(employer);
        }


    }
  
    }

