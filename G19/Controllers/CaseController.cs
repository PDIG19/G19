using Microsoft.AspNetCore.Mvc;


namespace G19.Controllers;

[ApiController]
[Route("[controller]")]
public class  CaseController: ControllerBase
{
    private readonly ILogger<UserController> _logger;
    private G19Context _G19Context;
    private IConfiguration _config;
    public CaseController(ILogger<UserController> logger, G19Context g19Context, IConfiguration config)
    {
        _logger = logger;
        _G19Context = g19Context;
        _config = config;
    }

[HttpGet]
[Route("/Cases")]
public ActionResult ReadAll()
{
var all = _G19Context.Cases;
return Ok(all);
}

[HttpGet]
[Route("/Case/{id}")]
public async Task<ActionResult> Read(long id)
{
var Case = await _G19Context.Cases.FindAsync(id);
return Ok(Case);
}

[HttpPost]
[Route("/Case")]
public async Task<ActionResult> Create(Case Case)
{
var manufacturer = await _G19Context.Manufacturers.FindAsync(Case.Manufacturer.ManufacturerId);
if(manufacturer == null){
    return BadRequest();
}
manufacturer.Cases.Add(Case);
_G19Context.SaveChanges();
return Ok();
}

[HttpPut]
[Route("/Case")]
public async Task<ActionResult> Update(Case Case)
{
var find = await _G19Context.Cases.FindAsync(Case.CaseId);
if(find == null)
{
    return BadRequest();
}
find.Name = Case.Name;
find.Updated = DateTime.UtcNow;
find.Description = Case.Description;
find.Price = Case.Price;
_G19Context.SaveChanges();
return Ok(find);
}

[HttpDelete]
[Route("/Case/{id}")]
public async Task<ActionResult> Delete(long id)
{
var find = await _G19Context.Cases.FindAsync(id);
if (find == null)
{
    return BadRequest();
}
var deletus = _G19Context.Cases.Remove(find);
_G19Context.SaveChanges();
return Ok(deletus.Entity);
}
}