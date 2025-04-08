using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
[ApiController]
[Route("api/Lt")]
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
    [HttpGet("listar-costo")]
     public IActionResult ListarCosto(int costo, string operacion ){

        MongoClient client = new  MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtrocosto = Builders<Inmueble>.Filter.Eq(x => x.Costo,costo);
        var filtrooperacion = Builders<Inmueble>.Filter.Eq(x => x.Operacion, operacion);

       var filtroCompuesto = Builders<Inmueble>.Filter.And(filtrocosto, filtrooperacion);
        var lista = collection.Find(filtroCompuesto).ToList();
        return Ok(lista);
    }
    [HttpGet("listar-banios")]
     public IActionResult ListarBanios(int banios, string tipo ){

        MongoClient client = new  MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtrobanios = Builders<Inmueble>.Filter.Eq(x => x.Banios,banios);
        var filtrotipo = Builders<Inmueble>.Filter.Eq(x => x.Tipo, tipo);

       var filtroCompuesto = Builders<Inmueble>.Filter.And(filtrobanios, filtrotipo);
        var lista = collection.Find(filtroCompuesto).ToList();
        return Ok(lista);
    }
    [HttpGet("listar-terrenos")]
     public IActionResult ListarTerrenos(int metrosterreno, string tipo ){

        MongoClient client = new  MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtroterrenos = Builders<Inmueble>.Filter.Eq(x => x.MetrosTerreno,metrosterreno);
        var filtrotipo = Builders<Inmueble>.Filter.Eq(x => x.Tipo, tipo);

       var filtroCompuesto = Builders<Inmueble>.Filter.And(filtroterrenos, filtrotipo);
        var lista = collection.Find(filtroCompuesto).ToList();
        return Ok(lista);
    }
    [HttpGet("listar-terreno")]
     public IActionResult ListarTerreno(int metrosconstruccion, string tipo ){

        MongoClient client = new  MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtrometrosconstruccion= Builders<Inmueble>.Filter.Eq(x => x.MetrosConstruccion,metrosconstruccion);
        var filtrotipo = Builders<Inmueble>.Filter.Eq(x => x.Tipo, tipo);

       var filtroCompuesto = Builders<Inmueble>.Filter.And(filtrometrosconstruccion, filtrotipo);
        var lista = collection.Find(filtroCompuesto).ToList();
        return Ok(lista);
    }
    
    }
    
    