using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
[ApiController]
[Route("api/lt")]
public class ltController : Controller {
 [HttpGet("listar-piso")]
     public IActionResult ListarPisos(int pisos, string operacion ){

        MongoClient client = new  MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtroPisos = Builders<Inmueble>.Filter.Eq(x => x.Pisos, pisos);
        var filtroOperacion = Builders<Inmueble>.Filter.Eq(x => x.Operacion, operacion);

       var filtroCompuesto = Builders<Inmueble>.Filter.And(filtroPisos, filtroOperacion);
        var lista = collection.Find(filtroCompuesto).ToList();
        return Ok(lista);
    }
    }