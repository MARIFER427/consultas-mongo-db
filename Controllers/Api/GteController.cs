using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
[ApiController]
[Route("api/gte")]
public class GteController : Controller {
 [HttpGet("listar-banios")]
     public IActionResult ListarBanio(int banios){

        MongoClient client = new  MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Gte(x => x.Banios, banios);

        var lista = collection.Find(filtro).ToList();
        return Ok(lista);
    }

  [HttpGet("listar-fechapublicacion")]
     public IActionResult ListarFechaPublicacion(string fechapublicacion){

        MongoClient client = new  MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Gte(x => x.FechaPublicacion, fechapublicacion);

        var lista = collection.Find(filtro).ToList();
        return Ok(lista);
    }
    [HttpGet("listar-pisos")]
     public IActionResult ListarPisos(int pisos){

        MongoClient client = new  MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Gte(x => x.Pisos, pisos);

        var lista = collection.Find(filtro).ToList();
        return Ok(lista);
    }
     [HttpGet("listar-terreno")]
     public IActionResult ListarMetrosTerreno(int metrosterreno){

        MongoClient client = new  MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Gte(x => x.MetrosTerreno, metrosterreno);

        var lista = collection.Find(filtro).ToList();
        return Ok(lista);
    }
     [HttpGet("listar-costo")]
     public IActionResult ListarCosto(int costo){

        MongoClient client = new  MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Gte(x => x.Costo, costo);

        var lista = collection.Find(filtro).ToList();
        return Ok(lista);
    }
}