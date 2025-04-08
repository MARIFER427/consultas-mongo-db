using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
[ApiController]
[Route("api/Lte")]
public class NeController : Controller {
     [HttpGet("listar-terreno")]
     public IActionResult ListarTerreno(int metrosconstruccion){

        MongoClient client = new  MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");
       
       var filtro = Builders<Inmueble>.Filter.Eq(x => x.MetrosConstruccion, metrosconstruccion);

        var lista = collection.Find(filtro).ToList();
        return Ok(lista);
    }
    [HttpGet("listar-banio")]
     public IActionResult ListarBanios(int banios){

        MongoClient client = new  MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Eq(x => x.Banios, banios);

        var lista = collection.Find(filtro).ToList();
        return Ok(lista);
    }
    [HttpGet("listar-costo")]
     public IActionResult ListarCosto(int costo){

        MongoClient client = new  MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Eq(x => x.Costo, costo);

        var lista = collection.Find(filtro).ToList();
        return Ok(lista);
    }
    [HttpGet("listar-pisos")]
     public IActionResult ListarPisos(int pisos){

        MongoClient client = new  MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Eq(x => x.Pisos, pisos);

        var lista = collection.Find(filtro).ToList();
        return Ok(lista);
    }
     [HttpGet("listar-terrenos")]
     public IActionResult ListarTerrenos(int MetrosTerreno){

        MongoClient client = new  MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Eq(x => x.MetrosConstruccion, MetrosTerreno);

        var lista = collection.Find(filtro).ToList();
        return Ok(lista);
    }
}