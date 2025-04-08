using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
[ApiController]
[Route("api/Ne")]
public class lteController : Controller {
     [HttpGet("listar-agente")]
     public IActionResult ListarAgente(string nombreagente){

        MongoClient client = new  MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");
       
       var filtro = Builders<Inmueble>.Filter.Eq(x => x.NombreAgente, nombreagente);

        var lista = collection.Find(filtro).ToList();
        return Ok(lista);
    }
    [HttpGet("listar-operacion")]
     public IActionResult ListarOperacion(string operacion){

        MongoClient client = new  MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Eq(x => x.Operacion, operacion);
      
        var lista = collection.Find(filtro).ToList();
        return Ok(lista);
    }
    [HttpGet("listar-tipo")]
    public IActionResult ListarTipo(string tipo){

        MongoClient client = new  MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Eq(x => x.Tipo, tipo);

        var lista = collection.Find(filtro).ToList();
        return Ok(lista);
    }
    [HttpGet("listar-agencias")]
    public IActionResult ListarAgencias(string agencia){

        MongoClient client = new  MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Eq(x => x.Agencia, agencia);

        var lista = collection.Find(filtro).ToList();
        return Ok(lista);
    }
 [HttpGet("listar-patio")]
    public IActionResult ListarTienePatio(bool tienepatio){

        MongoClient client = new  MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Eq(x => x.TienePatio, tienepatio);

        var lista = collection.Find(filtro).ToList();
        return Ok(lista);
    }

    }