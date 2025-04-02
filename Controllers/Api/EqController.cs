using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
[ApiController]
[Route("api/eq")]
public class EqController : Controller {
    [HttpGet("listar-agencias")]

    public IActionResult ListarAgencias(){

        MongoClient client = new  MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Eq(x => x.Agencia, "Inmobiliaria Pére");

        var lista = collection.Find(filtro).ToList();
        return Ok(lista);
    }

     [HttpGet("listar-tipo")]
    public IActionResult ListarTipo(){

        MongoClient client = new  MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Eq(x => x.Tipo, "Terreno");

        var lista = collection.Find(filtro).ToList();
        return Ok(lista);
    }

[HttpGet("listar-operacion")]
     public IActionResult ListarOperacion(){

        MongoClient client = new  MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Eq(x => x.Operacion, "Venta");

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

    [HttpGet("listar-construccion")]
     public IActionResult ListarMetrosConstruccion(int MetrosConstruccion){

        MongoClient client = new  MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Eq(x => x.MetrosConstruccion, MetrosConstruccion);

        var lista = collection.Find(filtro).ToList();
        return Ok(lista);
    }
}