using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
  internal class Program
  {
    static int Game;
    static string[] pole = new[] { "X", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
    static string[] gamer = new[] { "Крестики", "Нолики" };
    static int result = 0;        // 0 - идет игра, 1 - победа/проигрыш, 2 - ничья.
    static string step = string.Empty;
    static int i = 0;
    static int verified = 0;

    static void Main(string[] args)
    {
      Console.WriteLine("Хотите сыграть против другого игрока? (y/n)");
      var game = Console.ReadLine();
      if (game == "y")
      {
        Game = 1;
      }
      else
      {
        Game = 0;
        Console.WriteLine("В разработке.");
        Console.ReadKey();
      };
      while (result == 0 && Game == 1)
      {
        Printgamespace();
        Console.WriteLine("Ходят {0}", gamer[i % 2]);
        Console.WriteLine("Введите номер поля: ");
        while (verified != 1)
        {
          step = Console.ReadLine();
          Legitimacy();
        }
        verified = 0;
        Analisis();
        i++;
      }
      #region Report
      if (result == 1)
      {
        Console.Clear();
        Console.WriteLine("Победили {0}", gamer[(i + 1) % 2]);
        Console.WriteLine(string.Empty);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(" {0} | {1} | {2} ", pole[2], pole[3], pole[4]);
        Console.ResetColor();
        Console.WriteLine("---|---|---");
        Console.WriteLine(" {0} | {1} | {2} ", pole[5], pole[6], pole[7]);
        Console.WriteLine("---|---|---");
        Console.WriteLine(" {0} | {1} | {2} ", pole[8], pole[9], pole[10]);
        Console.ReadKey();
      }
      else if (result == 2)
      {
        Console.Clear();
        Console.WriteLine("Победили {0}", gamer[(i + 1) % 2]);
        Console.WriteLine(string.Empty);
        Console.WriteLine(" {0} | {1} | {2} ", pole[2], pole[3], pole[4]);
        Console.WriteLine("---|---|---");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(" {0} | {1} | {2} ", pole[5], pole[6], pole[7]);
        Console.ResetColor();
        Console.WriteLine("---|---|---");
        Console.WriteLine(" {0} | {1} | {2} ", pole[8], pole[9], pole[10]);
        Console.ReadKey();
      }
      else if (result == 3)
      {
        Console.Clear();
        Console.WriteLine("Победили {0}", gamer[(i + 1) % 2]);
        Console.WriteLine(string.Empty);
        Console.WriteLine(" {0} | {1} | {2} ", pole[2], pole[3], pole[4]);
        Console.WriteLine("---|---|---");
        Console.WriteLine(" {0} | {1} | {2} ", pole[5], pole[6], pole[7]);
        Console.WriteLine("---|---|---");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(" {0} | {1} | {2} ", pole[8], pole[9], pole[10]);
        Console.ResetColor();
        Console.ReadKey();
      }
      else if (result == 4)
      {
        Console.Clear();
        Console.WriteLine("Победили {0}", gamer[(i + 1) % 2]);
        Console.WriteLine(string.Empty);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(" {0} ", pole[2]);
        Console.ResetColor();
        Console.WriteLine("| {0} | {1} ", pole[3], pole[4]);
        Console.WriteLine("---|---|---");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(" {0} ", pole[5]);
        Console.ResetColor();
        Console.WriteLine("| {0} | {1} ", pole[6], pole[7]);
        Console.WriteLine("---|---|---");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(" {0} ", pole[8]);
        Console.ResetColor();
        Console.WriteLine("| {0} | {1} ", pole[9], pole[10]);
        Console.ReadKey();
      }
      else if (result == 5)
      {
        Console.Clear();
        Console.WriteLine("Победили {0}", gamer[(i + 1) % 2]);
        Console.WriteLine(string.Empty);
        Console.Write(" {0} | ", pole[2]);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(pole[3]);
        Console.ResetColor();
        Console.WriteLine(" | {0} ", pole[4]);
        Console.WriteLine("---|---|---");
        Console.Write(" {0} | ", pole[5]);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(pole[6]);
        Console.ResetColor();
        Console.WriteLine(" | {0} ", pole[7]);
        Console.WriteLine("---|---|---");
        Console.Write(" {0} | ", pole[8]);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(pole[9]);
        Console.ResetColor();
        Console.WriteLine(" | {0} ", pole[10]);
        Console.ReadKey();
      }
      else if (result == 6)
      {
        Console.Clear();
        Console.WriteLine("Победили {0}", gamer[(i + 1) % 2]);
        Console.WriteLine(string.Empty);
        Console.Write(" {0} | {1} | ", pole[2], pole[3]);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(pole[4]);
        Console.ResetColor();
        Console.WriteLine("---|---|---");
        Console.Write(" {0} | {1} | ", pole[5], pole[6]);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(pole[7]);
        Console.ResetColor();
        Console.WriteLine("---|---|---");
        Console.Write(" {0} | {1} | ", pole[8], pole[9]);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(pole[10]);
        Console.ResetColor();
        Console.ReadKey();
      }
      else if (result == 7)
      {
        Console.Clear();
        Console.WriteLine("Победили {0}", gamer[(i + 1) % 2]);
        Console.WriteLine(string.Empty);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(" {0} ", pole[2]);
        Console.ResetColor();
        Console.WriteLine("| {0} | {1} ", pole[3], pole[4]);
        Console.WriteLine("---|---|---");
        Console.Write(" {0} | ", pole[5]);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(pole[6]);
        Console.ResetColor();
        Console.WriteLine(" | {0} ", pole[7]);
        Console.WriteLine("---|---|---");
        Console.Write(" {0} | {1} | ", pole[8], pole[9]);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(pole[10]);
        Console.ResetColor();
        Console.ReadKey();
      }
      else if (result == 8)
      {
        Console.Clear();
        Console.WriteLine("Победили {0}", gamer[(i + 1) % 2]);
        Console.WriteLine(string.Empty);
        Console.Write(" {0} | {1} | ", pole[2], pole[3]);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(pole[4]);
        Console.ResetColor();
        Console.WriteLine("---|---|---");
        Console.Write(" {0} | ", pole[5]);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(pole[6]);
        Console.ResetColor();
        Console.WriteLine(" | {0} ", pole[7]);
        Console.WriteLine("---|---|---");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(" {0} ", pole[8]);
        Console.ResetColor();
        Console.WriteLine("| {0} | {1} ", pole[9], pole[10]);
        Console.ReadKey();
      }
            else if (result == 9)
      {
        Console.Clear();

        Console.WriteLine("Ничья");
        Console.WriteLine(string.Empty);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(" {0} | {1} | {2} ", pole[2], pole[3], pole[4]);
        Console.WriteLine("---|---|---");
        Console.WriteLine(" {0} | {1} | {2} ", pole[5], pole[6], pole[7]);
        Console.WriteLine("---|---|---");
        Console.WriteLine(" {0} | {1} | {2} ", pole[8], pole[9], pole[10]);
        Console.ResetColor();
        Console.ReadKey();
      }
      #endregion
    }

    /// <summary>
    /// Выводит на экран обновленное игровое поле.
    /// </summary>
    static void Printgamespace()
    {
      Console.Clear();
      
      Console.WriteLine("Крестики-нолики (v.0.1)");
      Console.WriteLine(string.Empty);
      Console.WriteLine("Правила:");
      Console.WriteLine("1. Для выполнения хода введите число соответствующее желаемой клетке.");
      Console.WriteLine("2. В занятую клетку уже не сходить.");
      Console.WriteLine("3. Выйгрывает тот, кто первым заполнит одинаковыми знаками");
      Console.WriteLine("всю строку или столбец, либо одну из диагоналей.");
      Console.WriteLine("4. Первыми ходят Крестики.");
      Console.WriteLine(string.Empty);
      Console.WriteLine(" {0} | {1} | {2} ", pole[2], pole[3], pole[4]);
      Console.WriteLine("---|---|---");
      Console.WriteLine(" {0} | {1} | {2} ", pole[5], pole[6], pole[7]);
      Console.WriteLine("---|---|---");
      Console.WriteLine(" {0} | {1} | {2} ", pole[8], pole[9], pole[10]);
      Console.WriteLine(string.Empty);
    }

    /// <summary>
    /// Проверяет на правильность дейстия игрока при совершении хода.
    /// </summary>
    static void Legitimacy()
    {
      if (step == "1" && pole[2] == "1")
      {
        pole[2] = pole[(i % 2)];
        verified = 1;
      }
      else if (step == "2" && pole[3] == "2")
      {
        pole[3] = pole[(i % 2)];
        verified = 1;
      }
      else if (step == "3" && pole[4] == "3")
      {
        pole[4] = pole[(i % 2)];
        verified = 1;
      }
      else if (step == "4" && pole[5] == "4")
      {
        pole[5] = pole[(i % 2)];
        verified = 1;
      }
      else if (step == "5" && pole[6] == "5")
      {
        pole[6] = pole[(i % 2)];
        verified = 1;
      }
      else if (step == "6" && pole[7] == "6")
      {
        pole[7] = pole[(i % 2)];
        verified = 1;
      }
      else if (step == "7" && pole[8] == "7")
      {
        pole[8] = pole[(i % 2)];
        verified = 1;
      }
      else if (step == "8" && pole[9] == "8")
      {
        pole[9] = pole[(i % 2)];
        verified = 1;
      }
      else if (step == "9" && pole[10] == "9")
      {
        pole[10] = pole[(i % 2)];
        verified = 1;
      }
      else
      {
        Console.WriteLine("Неправильный ход.");
        Console.WriteLine("Укажите свободное поле: ");
        verified = 0;
      };
    }

    /// <summary>
    /// Возвращает номер результата партии.
    /// </summary>
    static void Analisis()
    {
      if (pole[2] == pole[3] && pole[3] == pole[4])
      {
        result = 1;
      }
      else if (pole[5] == pole[6] && pole[6] == pole[7])
      {
        result = 2;
      }
      else if (pole[8] == pole[9] && pole[9] == pole[10])
      {
        result = 3;
      }
      else if (pole[2] == pole[5] && pole[5] == pole[8])
      {
        result = 4;
      }
      else if (pole[3] == pole[6] && pole[6] == pole[9])
      {
        result = 5;
      }
      else if (pole[4] == pole[7] && pole[7] == pole[10])
      {
        result = 6;
      }
      else if (pole[2] == pole[6] && pole[6] == pole[10])
      {
        result = 7;
      }
      else if (pole[4] == pole[6] && pole[6] == pole[8])
      {
        result = 8;
      }
      else if (i == 8)
      {
        result = 9;
      }
    }
  }
}
