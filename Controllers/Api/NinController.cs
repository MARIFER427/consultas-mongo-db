using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
[ApiController]
[Route("api/Nin")]
public class NinController : Controller {
 [HttpGet("listar-agente")]
     public IActionResult ListarAgente(){

        MongoClient client = new  MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        List<string> agencia = new List<string>();
        agencia.Add("Inmobiliaria Pérez");
        List<string> nombreagente = new List<string>();
        nombreagente.Add("Ana Torres");

        var filtroagencia = Builders<Inmueble>.Filter.Nin(x => x.Agencia,agencia);
        var filtronombreagente = Builders<Inmueble>.Filter.Nin(x => x.NombreAgente, nombreagente);

       var filtroCompuesto = Builders<Inmueble>.Filter.And(filtroagencia, filtronombreagente);
        var lista = collection.Find(filtroCompuesto).ToList();
        return Ok(lista);
    }
    [HttpGet("listar-banio")]
     public IActionResult ListarBanio(){

        MongoClient client = new  MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        List<string> agencia = new List<string>();
        agencia.Add("Torres Realty");
        List<int> banios = new List<int>();
        banios.Add(2);

        var filtroagencia = Builders<Inmueble>.Filter.Nin(x => x.Agencia,agencia);
        var filtrobanios = Builders<Inmueble>.Filter.Nin(x => x.Banios, banios);

       var filtroCompuesto = Builders<Inmueble>.Filter.And(filtroagencia, filtrobanios);
        var lista = collection.Find(filtroCompuesto).ToList();
        return Ok(lista);
    }
     [HttpGet("listar-pisos")]
     public IActionResult ListarPisos(){

        MongoClient client = new  MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        List<int> pisos = new List<int>();
        pisos.Add(2);
        List<string> tipo = new List<string>();
        tipo.Add("Casa");

        var filtropisos = Builders<Inmueble>.Filter.Nin(x => x.Pisos,pisos);
        var filtrotipo = Builders<Inmueble>.Filter.Nin(x => x.Tipo, tipo);

       var filtroCompuesto = Builders<Inmueble>.Filter.And(filtropisos, filtrotipo);
        var lista = collection.Find(filtroCompuesto).ToList();
        return Ok(lista);
    }
    [HttpGet("listar-terrenos")]
     public IActionResult ListarTerrenos(){

        MongoClient client = new  MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        List<string> agencia = new List<string>();
        agencia.Add("García Propiedades");
        List<string> tipo = new List<string>();
        tipo.Add("Terreno");

        var filtroagencia = Builders<Inmueble>.Filter.Nin(x => x.Agencia,agencia);
        var filtrotipo = Builders<Inmueble>.Filter.Nin(x => x.Tipo, tipo);

       var filtroCompuesto = Builders<Inmueble>.Filter.And(filtroagencia, filtrotipo);
        var lista = collection.Find(filtroCompuesto).ToList();
        return Ok(lista);
    }
     [HttpGet("listar-operacion")]
     public IActionResult ListarOperacion(){

        MongoClient client = new  MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        List<int> pisos = new List<int>();
        pisos.Add(2);
        List<string> operacion = new List<string>();
        operacion.Add("Renta");

        var filtropisos = Builders<Inmueble>.Filter.Nin(x => x.Pisos,pisos);
        var filtrooperacion = Builders<Inmueble>.Filter.Nin(x => x.Operacion, operacion);

       var filtroCompuesto = Builders<Inmueble>.Filter.And(filtropisos, filtrooperacion);
        var lista = collection.Find(filtroCompuesto).ToList();
        return Ok(lista);
    }
}