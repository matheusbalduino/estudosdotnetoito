using System;
namespace ProEventos.Domain;

public class Lote: BaseModel
{    
    public string Nome { get; set; }
    public decimal Preco { get; set; }
    public DateTime? DataInicio { get; set; }
    public DateTime? DataFim { get; set; }
    public int Quantidade { get; set; }
    public int EventoId { get; set; }
    public Evento Evento { get; set; }

}