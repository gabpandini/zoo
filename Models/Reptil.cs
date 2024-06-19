namespace zoo.Models
{  
  public class Reptil : Animal
  {
    public Reptil(string nome, string alimento) : base(nome, alimento) { }

    public override void Comer()
    {
      Console.WriteLine($"{Nome} está comendo {Alimento}.");
    }
  }
}
