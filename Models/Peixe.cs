namespace zoo.Models
{  
  public class Peixe : Animal, INadar
  {
    public double LimiteProfundidade { get; set; }

    public Peixe(string nome, string alimento, double limiteProfundidade) : base(nome, alimento)
    {
      LimiteProfundidade = limiteProfundidade;
    }

    public override void Comer()
    {
      Console.WriteLine($"{Nome} está comendo {Alimento}.");
    }
  
    public void Subir(double metros)
    {
        if (metros <= LimiteProfundidade)
        {
          Console.WriteLine($"{Nome} está subindo {metros} metros na água.");
        }
        else
        {
          Console.WriteLine($"{Nome} não pode subir {metros} metros, pois não pode sair da água.");
        }
    }

    public void Descer(double metros)
    {
        if (metros <= LimiteProfundidade)
        {
          Console.WriteLine($"{Nome} está descendo {metros} metros na água.");
        }
        else
        {
          Console.WriteLine($"{Nome} não pode descer {metros} metros, seu limite de profundidade é de {LimiteProfundidade} metros.");
        }
    }
  }
}
