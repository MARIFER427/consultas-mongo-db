using MongoDB.Bson.Serialization.Attributes;

public class Inmubles {
    [BsonId]
    [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
    public string? Id {get; set;}

[BsonElement("tipo")]
    public string Tipo {get; set;} = string.Empty;
    public string Operacion {get; set;} = string.Empty;
    public string NombreOperador {get; set;} = string.Empty;
    public int Banios {get; set;}
    public int MetrosTerreno {get; set;}
    public int MetrosConstruccion {get; set;}
    public bool TienePatio {get; set;}
    public int Pisos {get; set;}
    public string Agencia {get; set;} = string.Empty;
    public string FechaPublicacion {get; set;} = string.Empty;
    public int Costo {get; set;}

}