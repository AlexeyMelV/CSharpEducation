using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
  internal class ScoreTable
  {
    private List<Gamer> _gamers { get; set; } = new List<Gamer>();

    private void DisplayGamerScore(Gamer gamer)
    {
      Console.WriteLine($"Игрок: {gamer.Name}, счёт: {gamer.Score}");
    }

    public void DisplayGamersScore(List<Gamer> gamers)
    {
      foreach (var gamer in gamers)
      {
        DisplayGamerScore(gamer);
      }
    }

    public void AddGamer(Gamer gamer)
    {
      _gamers.Add(gamer);

    }

    
    public void DisplayAllGamers()
    {
      DisplayGamersScore(_gamers);
    }
  }
}
