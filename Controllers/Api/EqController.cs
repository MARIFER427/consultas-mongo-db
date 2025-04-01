using Microsoft.AspNetCore.Mvc;
[ApiController]
[Route("api/eq")]
public class EqController : Controller {
    [HttpGet("listar-agencias")]
    public IActionResult ListarAgencias(){
        return Ok();
    }
}