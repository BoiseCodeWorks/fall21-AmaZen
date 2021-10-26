using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace AmaZen.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class ProductsController : ControllerBase
  {
    [HttpGet]
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