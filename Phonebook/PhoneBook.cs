using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookApp
{
  internal class PhoneBook
  {
    private List<Abonent> _abonents { get; set; } = new List<Abonent>();

    private void DisplayAbonentDetails(Abonent abonent)
    {
      Console.WriteLine($"Абонент: {abonent.Name}, номер: {abonent.Number}");
    }

    public void DisplayAbonentsDetails(List<Abonent> abonents)
    {
      foreach (var abonent in abonents)
      {
        DisplayAbonentDetails(abonent);
      }
    }

    public void AddAbonent(Abonent abonent)
    {
      _abonents.Add(abonent);
    }

    public void DisplayAbonent(string number)
    {
      var abonent = _abonents.FirstOrDefault(c => c.Number == number);
      if (abonent == null) 
      {
        Console.WriteLine("Абонент не найден");
      }
      else
      {
        DisplayAbonentDetails(abonent);
      }
    }

    public void DisplayAllAbonent()
    {
      DisplayAbonentsDetails(_abonents);
    }

    public void DisplayMatchingAbonents(string searchPhrase)
    {
      var matchingAbonents = _abonents.Where(c => c.Name.Contains(searchPhrase)).ToList();
      DisplayAbonentsDetails(matchingAbonents);
    }
  }
}
