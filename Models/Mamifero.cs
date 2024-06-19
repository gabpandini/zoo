namespace zoo.Models
{  
  public class Mamifero : Animal
  {
    public Mamifero(string nome, string alimento) : base(nome, alimento) { }

    public override void Comer()
    {
      Console.WriteLine($"{Nome} está comendo {Alimento}.");
    }
  }
}
