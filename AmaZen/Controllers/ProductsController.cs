using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AmaZen.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class ProductsController : ControllerBase
  {
    [HttpGet]
    [Authorize]
    public ActionResult<List<string>> Get()
    {
      try
      {
        return Ok(new List<string>(){
                  "hello",
                  "world"
                });
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
  }


}