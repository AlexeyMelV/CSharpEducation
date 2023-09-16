using System;

namespace PhoneBookApp
{
  internal class Program
  {
    static void Main()
    {
      Console.WriteLine("Phonebook v.0.1");
      Console.WriteLine("Выберите действие");
      Console.WriteLine("1. Добавить абонента");
      Console.WriteLine("2. Найти абонента по номеру");
      Console.WriteLine("3. Отобразить всех абонентов");
      Console.WriteLine("4. Поиск абонента по имени");
      Console.WriteLine("x. Выйти из программы");

      var userInput = Console.ReadLine();

      var phoneBook = new PhoneBook();

      while (true)
      {
        switch (userInput)
        {
          case "1":
            Console.WriteLine("Введите имя абонента:");
            var name = Console.ReadLine();
            Console.WriteLine("Введите номер абонента:");
            var number = Console.ReadLine();

            var newAbonent = new Abonent(name, number);
            phoneBook.AddAbonent(newAbonent);
            
            break;

          case "2":
            Console.WriteLine("Введите номер абонента:");
            var searchNumber = Console.ReadLine();
            phoneBook.DisplayAbonent(searchNumber);
            break;

          case "3":
            phoneBook.DisplayAllAbonent();
            break;

          case "4":
            Console.WriteLine("Введите часть имени абонента:");
            var searcPhrase = Console.ReadLine();
            phoneBook.DisplayMatchingAbonents(searcPhrase);
            break;

              break;

          case "x":
            return;
          default:
            Console.WriteLine("Ошибка. Выбранное действие не возможно.");
            break;
        }

        Console.WriteLine("Выберите действие");
        userInput = Console.ReadLine();
      }
    }
  }
}