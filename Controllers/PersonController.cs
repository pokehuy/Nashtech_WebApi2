using Microsoft.AspNetCore.Mvc;
using webapi2.Services;
using webapi2.Models;

namespace webapi2.Controllers;

[ApiController]
[Route("[controller]")]
public class PersonController : ControllerBase
{
    private readonly ILogger<PersonController> _logger;
    private IPersonService _ipersonservice;

    public PersonController(ILogger<PersonController> logger, IPersonService ipersonservice)
    {
        _logger = logger;
        _ipersonservice = ipersonservice;
    }

    [HttpGet]
    public List<PersonModel> GetAll(){
        return _ipersonservice.GetAll();
    }

    [HttpPost]
    public void Add(PersonModel person){
        _ipersonservice.Add(person);
    }

    [HttpPut]
    public void Update(Guid id, PersonModel person){
        _ipersonservice.Update(id, person);
    }

    [HttpDelete]
    public void Delete(Guid id){
        _ipersonservice.Delete(id);
    }

    [HttpGet("filterlist")]
    public List<PersonModel> Get(string fn, string ln, string gd, string bp){
        return _ipersonservice.Get(fn,ln,gd,bp);
    }

    // [HttpGet("namefilter/{firstname}&{lastname}")]
    // public List<PersonModel> GetName(string firstname, string lastname){
    //     return _ipersonservice.GetName(firstname, lastname);
    // }

    // [HttpGet("genderfilter/{gender}")]
    // public List<PersonModel> GetGender(string gender){
    //     return _ipersonservice.GetGender(gender);
    // }

    // [HttpGet("birthplacefilter/{birthplace}")]
    // public List<PersonModel> GetBirthPlace(string birthplace){
    //     return _ipersonservice.GetBirthPlace(birthplace);
    // }
}
