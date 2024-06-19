namespace zoo.Models
{  
  public class Ave : Animal, IVoar
  {
    public Ave(string nome, string alimento) : base(nome, alimento) { }

    public override void Comer()
    {
      Console.WriteLine($"{Nome} está comendo {Alimento}.");
    }

    public void Voar()
    {
      Console.WriteLine($"{Nome} está levantando voo.");
    }

    public void Pousar()
    {
      Console.WriteLine($"{Nome} está pousando.");
    }
  }
}
