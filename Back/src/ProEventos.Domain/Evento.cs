namespace ProEventos.Domain;

public class Evento : BaseModel
{
    public string Local { get; set; }
    public DateTime? DataEvento { get; set; }
    public string Tema { get; set; }
    public int QtdPessoas { get; set; }
    public string ImagemURL { get; set; }
    public string Telefone { get; set; }
    public string Email { get; set; }
    public IEnumerable<Lote> Lote { get; set; }
    public IEnumerable<RedeSocial> RedeSocial { get; set; }
    public IEnumerable<PalestranteEvento> PalestranteEventos { get; set; }

}