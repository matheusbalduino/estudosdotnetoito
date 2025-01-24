namespace ProEventos.CrossCutting;

public class Error
{
    public Error(string message, string code){
        this.Message = message;
        this.Code = code;
    }
    public string Message { get; protected set; }
    public string Code { get; protected set; }

}