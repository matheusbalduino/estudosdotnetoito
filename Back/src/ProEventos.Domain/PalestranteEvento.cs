namespace ProEventos.Domain;

public class PalestranteEvento: BaseModel
{
    public int PalestranteId { get; set; }
    public Palestrante Palestrante { get; set; }
    public int EventoId { get; set; }
    public Evento Evento { get; set; }
}