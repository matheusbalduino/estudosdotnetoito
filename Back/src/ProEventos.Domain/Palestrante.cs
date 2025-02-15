namespace ProEventos.Domain;

public class Palestrante: BaseModel
{    public string Nome { get; set; }
    public string MiniCurriculo { get; set; }
    public string ImagemURL { get; set; }
    public string Telefone { get; set; }
    public string Email { get; set; }
    public IEnumerable<RedeSocial> RedeSociais { get; set; }
    public IEnumerable<PalestranteEvento> PalestranteEventos { get; set; }

}