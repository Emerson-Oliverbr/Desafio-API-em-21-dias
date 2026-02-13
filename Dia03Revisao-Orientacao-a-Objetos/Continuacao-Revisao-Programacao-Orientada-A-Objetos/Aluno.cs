namespace IntroducaoPoo;

public class Aluno()
{
    public string Nome {get; set;}
    public string Matricula {get; set;}
    private List<double> _notas;

    public List<double> Notas 
    {
        get
        {
            if(_notas == null) _notas = new List<double>();
            {                
                return _notas;
            }
        }
        set
        {
            _notas = value;
        }
    }  

    public double CalcularMedia()
    {
        double somaNotas = 0.0;
        foreach(var nota in this.Notas)
        {
            somaNotas += nota;
        }
        return somaNotas / this.Notas.Count;
    }   

    public string Situacao()
    {
        return this.CalcularMedia() >= 7.0 ? "Aprovaddo" : "Reprovado"; 
    }
}