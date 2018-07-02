using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutoMapper;
using Vidle.Dtos;
using Vidle.Models;

namespace Vidle.Controllers.Api
{
    public class CustomersController : ApiController
    {
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        // GET api/customers
        public IEnumerable<CustomerDto> GetCustomers()
        {
             return _context.Customers.ToList().Select(Mapper.Map<Customer, CustomerDto>);
        }

        // GET api/customers/1
        public IHttpActionResult GetCustomer(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customer == null)
            {
                return NotFound();
            }

            // As we are returing 1 single customer object here we use: Mapper


            return Ok(Mapper.Map<Customer, CustomerDto>(customer));
        }

        // POST api/customers
        [HttpPost]
        public IHttpActionResult CreateCustomer(CustomerDto customerDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var customer = Mapper.Map<CustomerDto, Customer>(customerDto);

            _context.Customers.Add(customer);
            _context.SaveChanges();

            // as This custoemr object has an id so add this to the Dto and return to the Client

            customerDto.Id = customer.Id;


            return Created(new Uri(Request.RequestUri + "/" + customer.Id), customerDto);
        }

        // PUT api/customers/1
        [HttpPut]
        public void UpdateCustomer(int id, CustomerDto customerDto)
        {
            if (!ModelState.IsValid)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }

            var customerInDb = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customerInDb == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            // passing here as second argument becuase the object is exist
            // becuase the object is loaded in the context which will track changes

            Mapper.Map(customerDto, customerInDb);

            _context.SaveChanges();
        }

        //DELETE api/customers/1
        [HttpDelete]
        public void DeleteCustomer(int id)
        {
            var customerInDb = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customerInDb == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            _context.Customers.Remove(customerInDb);
            _context.SaveChanges();
        }
    }
}
