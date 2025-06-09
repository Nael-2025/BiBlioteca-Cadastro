public class Usuario : Pessoa
{
    public string Matrícula {get;set;}

    public Usuario(string nome, string matricula) : base(nome)

    {
        Matrícula = matricula;
    }
}