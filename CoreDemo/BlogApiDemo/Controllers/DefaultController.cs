using BlogApiDemo.DataAccessLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BlogApiDemo.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class DefaultController : ControllerBase
	{
		[HttpGet]
		public IActionResult EmployeeList()
		{
			using (var c = new Context())
			{
				var values = c.Employees.ToList();
				return Ok(values);
			}
		}

		[HttpPost]
		public IActionResult EmployeeAdd(Employee p)
		{
			using (var c = new Context())
			{
				c.Employees.Add(p);
				c.SaveChanges();
				return Ok();
			}
		}

		[HttpGet("{id}")]
		public IActionResult EmployeeGet(int id)
		{
			using (var c = new Context())
			{
				var value = c.Employees.Find(id);
				if (value == null)
					return NotFound();

				return Ok(value);
			}
		}


		[HttpDelete("{id}")]
		public IActionResult EmployeeDelete(int id)
		{
			using (var c = new Context())
			{
				var value = c.Employees.FirstOrDefault(x => x.Id == id);

				if (value == null)
					return NotFound();

				c.Remove(value);
				c.SaveChanges();
				return Ok();
			}
		}

		[HttpPut]
		public IActionResult EmployeeUpdate(Employee e)
		{
			using (var c = new Context())
			{
				var value = c.Employees.FirstOrDefault(x => x.Id == e.Id);

				if (value == null)
					return NotFound();

				value.Name = e.Name;
				c.Update(value);
				c.SaveChanges();
				return Ok();
			}
		}
	}
}
