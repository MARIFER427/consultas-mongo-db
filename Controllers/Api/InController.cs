using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
[ApiController]
[Route("api/in")]
public class InController : Controller {
 [HttpGet("listar-agencias")]
     public IActionResult ListarAgencias(string  agencia, string agente ){

        MongoClient client = new  MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtroAgencia = Builders<Inmueble>.Filter.Eq(x => x.Agencia, agencia);
        var filtroAgente = Builders<Inmueble>.Filter.Eq(x => x.NombreAgente, agente);

       var filtroCompuesto = Builders<Inmueble>.Filter.And(filtroAgencia, filtroAgente);
        var lista = collection.Find(filtroCompuesto).ToList();
        return Ok(lista);
    }
    [HttpGet("listar-banios")]
     public IActionResult ListarBanios(int banios){

        MongoClient client = new  MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Eq(x => x.Banios, banios);
        var lista = collection.Find(filtro).ToList();
        return Ok(lista);
    }
    [HttpGet("listar-pisos")]
     public IActionResult ListarPisos(int pisos,string agencia, string agente){

        MongoClient client = new  MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtroPisos = Builders<Inmueble>.Filter.Gte(x => x.Pisos, pisos);
        var filtroAgencia = Builders<Inmueble>.Filter.Eq(x => x.Agencia,agencia);
        var filtroAgente = Builders<Inmueble>.Filter.Eq(x => x.NombreAgente, agente);
       var filtroCompuesto = Builders<Inmueble>.Filter.And( filtroPisos, filtroAgencia, filtroAgente);
       var lista = collection.Find(filtroCompuesto).ToList();
        return Ok(lista);
    }
    [HttpGet("listar-metros")]
     public IActionResult ListarMetros(int metros,string agencia, string agente){

        MongoClient client = new  MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtroMetros = Builders<Inmueble>.Filter.Gte(x => x.MetrosConstruccion, metros);
        var filtroAgencia = Builders<Inmueble>.Filter.Eq(x => x.Agencia,agencia);
        var filtroAgente = Builders<Inmueble>.Filter.Eq(x => x.NombreAgente, agente);
       var filtroCompuesto = Builders<Inmueble>.Filter.And( filtroMetros, filtroAgencia, filtroAgente);
       var lista = collection.Find(filtroCompuesto).ToList();
        return Ok(lista);
    }
    [HttpGet("listar-agencia")]
     public IActionResult ListarAgencia(string  agencia, string agente ){

        MongoClient client = new  MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtroAgencia = Builders<Inmueble>.Filter.Eq(x => x.Agencia, agencia);
        var filtroAgente = Builders<Inmueble>.Filter.Eq(x => x.NombreAgente, agente);

       var filtroCompuesto = Builders<Inmueble>.Filter.And(filtroAgencia, filtroAgente);
        var lista = collection.Find(filtroCompuesto).ToList();
        return Ok(lista);
    }
}
