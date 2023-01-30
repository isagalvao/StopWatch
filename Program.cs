using System;
using System.Threading;

namespace StopWatch
{
  class Program
  {
    static void Main(string[] args)
    {
      Start(6);
    }
    static void Menu()
    {
      Console.Clear();
      Console.WriteLine("Cronometro, Selecione uma opção");
      Console.WriteLine("S = Segundo");
      Console.WriteLine("M = Minuto");
      Console.WriteLine("Finalizar cronometro");
      Console.WriteLine("Quanto tempo deseja contar?");
    }

    static void Start(int time)
    {

      int currentTime = 0;

      while (currentTime != time)
      {
        Console.Clear();
        currentTime++;
        Console.WriteLine(currentTime);
        Thread.Sleep(1000);
      }

      Console.Clear();
      Console.WriteLine("StopWhatch finalizado");
      Thread.Sleep(2500);
    }
  }
}
