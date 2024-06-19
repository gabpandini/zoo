namespace zoo.Models
{  
  public abstract class Animal
  {
    public string Nome { get; set; }
    public string Alimento { get; set; }
    
    public Animal(string nome, string alimento)
    {
      Nome = nome;
      Alimento = alimento;
    }

    public abstract void Comer();
  }
}
