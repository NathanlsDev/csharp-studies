using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Context;
using Entities;
using Microsoft.AspNetCore.Mvc;


namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContactController : Controller
    {
        private readonly PhoneBookContext _context;

        public ContactController(PhoneBookContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Create(Contact contact)
        {
            _context.Add(contact);
            _context.SaveChanges();
            return CreatedAtAction(nameof(Read), new { id = contact.Id }, contact);
        }

        [HttpGet("{id}")]
        public IActionResult Read(int id)
        {
            var contact = _context.Contacts.Find(id);
            if (contact == null) return NotFound();
            return Ok(contact);
        }

        [HttpGet("ContactByName")]
        public IActionResult ReadByName(string name)
        {
            var contacts = _context.Contacts.Where(table => table.Name.Contains(name));
            return Ok(contacts);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Contact contact)
        {
            var DBContact = _context.Contacts.Find(id);
            if(DBContact == null) return NotFound();
            DBContact.Name = contact.Name;
            DBContact.Phone = contact.Phone;
            DBContact.IsActive = contact.IsActive;

            _context.Contacts.Update(DBContact);
            _context.SaveChanges();
            return Ok(DBContact);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var DBContact = _context.Contacts.Find(id);
            if(DBContact == null) return NotFound();

            _context.Contacts.Remove(DBContact);
            _context.SaveChanges();
            return NoContent();
        }
    }
}