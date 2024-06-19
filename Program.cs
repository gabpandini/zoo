using System;
using System.Collections.Generic;
using zoo.Models;

namespace zoo
{
  class Program
  {
    static void Main(string[] args)
    {
      List<Animal> animais = new List<Animal>();

      Mamifero leao = new Mamifero("Leão", "carne");
      Ave papagaio = new Ave("Papagaio", "alpiste");
      Peixe tubarao = new Peixe("Tubarão", "carne", 1000);
      Reptil cobra = new Reptil("Cobra", "carne");
      Anfibio sapo = new Anfibio("Sapo", "insetos", 2);

      animais.Add(leao);
      animais.Add(papagaio);
      animais.Add(tubarao);
      animais.Add(cobra);
      animais.Add(sapo);

      foreach (var animal in animais)
      {
        animal.Comer();

        if (animal is IVoar voador)
        {
          voador.Voar();
          voador.Pousar();
        }

        if (animal is INadar nadador)
        {
          nadador.Descer(10);
          nadador.Subir(2.5);
        }

        Console.WriteLine();
      }
    }
  }
}
