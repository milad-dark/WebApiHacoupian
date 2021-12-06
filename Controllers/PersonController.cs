using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using WepApiHacoupian.Interfaces;
using WepApiHacoupian.ViewModel;

namespace WepApiHacoupian.Controllers
{
    [EnableCors("myPolicy"), Route("api/[controller]/[action]")]
    [ApiController]
    //[Authorize]
    public class PersonController : ControllerBase
    {
        private readonly IPerson _person;
        private readonly IPersonRole _personRole;

        public PersonController(IPerson person, IPersonRole personRole)
        {
            _person = person;
            _personRole = personRole;
        }

        [HttpGet]
        public async Task<ActionResult> GetAllPerson()
        {
            return Ok(await _person.SelectAllPerson(500, 0));
        }

        [HttpGet]
        public async Task<ActionResult> GetPerson([FromBody] PersonViewModel personCode)
        {
            if (ModelState.IsValid)
            {
                return (personCode.PersonCode != 0) ? Ok(await _person.SelectPersonByCode(personCode.PersonCode)) : NotFound("کاربر مورد نظر یافت نشد");
            }
            return BadRequest("داده ارسالی اشتباه است");
        }

        [HttpGet]
        public async Task<ActionResult> GetPersonWithSex([FromBody] PersonViewModel.PersonWithSex person)
        {
            if (ModelState.IsValid)
            {
                var people = await _person.SelectBySex(person.sex, person.take);
                return people.Any() ? Ok(await Task.FromResult(people)) : NotFound("کاربر مورد نظر یافت نشد");
            }
            return BadRequest("داده ارسالی اشتباه است");
        }

        [HttpGet]
        public async Task<ActionResult> GetPersonWithMarriageDate([FromBody] PersonViewModel.PersonWithMarriageDate person)
        {
            if (ModelState.IsValid)
            {
                var people = await _person.SelectByMarriage(person.date, person.take);
                return people.Any() ? Ok(await Task.FromResult(people)) : NotFound("کاربر مورد نظر یافت نشد");
            }
            return BadRequest("داده ارسالی اشتباه است");
        }

        [HttpGet]
        public async Task<ActionResult> GetPersonWithCity([FromBody] PersonViewModel.PersonWithCity person)
        {
            if (ModelState.IsValid)
            {
                var people = await _person.SelectByCity(person.city, person.take);
                return people.Any() ? Ok(await Task.FromResult(people)) : NotFound("کاربر مورد نظر یافت نشد");
            }
            return BadRequest("داده ارسالی اشتباه است");
        }

        [HttpGet]
        public async Task<ActionResult> GetPersonLogin([FromBody] PersonViewModel.PersonWithEmail person)
        {
            if (ModelState.IsValid)
            {
                if (person.Email != string.Empty && person.Password != string.Empty)
                {
                    var people = await _person.GetPerson(person.Email, person.Password);
                    if (people != null)
                    {
                        var roles = await _personRole.GetPersonRole(people.Id);
                        var roleList = (roles.Select(item => new PersonViewModel.PersonRoleLogin { Id = (int)item.Id, Role = item.Name })).ToList();

                        return roles.Any() ? Ok(await Task.FromResult(roleList)) : NotFound("کاربر مورد نظر یافت نشد");
                    }
                    return NotFound("کاربر مورد نظر یافت نشد");
                }
            }
            return BadRequest("داده ارسالی اشتباه است");
        }
    }
}