using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Правила игры
            Console.WriteLine("Крестики-нолики (v.0.1)");
            Console.WriteLine();
            Console.WriteLine("Правила:");
            Console.WriteLine("1. Для выполнения хода введите число соответствующее желаемой клетке.");
            Console.WriteLine("2. В занятую клетку уже не сходить.");
            Console.WriteLine("3. Выйгрывает тот, кто первым заполнит одинаковыми знаками всю строку или столбец, либо одну из диагоналей.");
            //Хотите сыграть против другого игрока
            Console.WriteLine("Хотите сыграть против другого игрока? (y/n)");
            var game = Console.ReadLine();
            int Game;
            if (game == "y")
            {
                Game = 1;
            }
            else
            {
                Game = 0;
                Console.WriteLine("В разработке.");
            };
            if (Game == 1)                      // Игра
            {
                string[] pole = new[] { "X", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
                string[] gamer = new[] { "Крестики", "Нолики" };
                int i = 0, pob = 0;

                while (i < pole.Length) { Console.WriteLine(pole[i]); i++; }; //отладка - проверка содержимого массива.
                i = 0;

                while (pob != 0 || i != 9)      //Процесс игры
                {
                    int a = i % 2;
                    Console.WriteLine();
                    Console.Write(pole[2]);
                    Console.Write(pole[3]);
                    Console.Write(pole[4]);
                    Console.WriteLine(" ", pole[2], " | ", pole[3], " | ", pole[4], " ");
                    Console.WriteLine("---|---|---");
                    Console.WriteLine(" ", pole[5], " | ", pole[6], " | ", pole[7], " ");
                    Console.WriteLine("---|---|---");
                    Console.WriteLine(" ", pole[8], " | ", pole[9], " | ", pole[10], " ");
                    Console.WriteLine();
                    Console.WriteLine("Ходят ", gamer[a]);
                    Console.WriteLine("Введите номер поля: ");

                    bool hodVer = false;
                    while (hodVer != true)        //Считывание хода и его проверка на лигитимность
                    {
                        var x = Console.ReadLine();

                        if (x == "1" && pole[2] == "1")
                        {
                            pole[2] = pole[(i % 2)];
                            hodVer = true;
                        }
                        else if (x == "2" && pole[3] == "2")
                        {
                            pole[3] = pole[(i % 2)];
                            hodVer = true;
                        }
                        else if (x == "3" && pole[4] == "3")
                        {
                            pole[4] = pole[(i % 2)];
                            hodVer = true;
                        }
                        else if (x == "4" && pole[5] == "4")
                        {
                            pole[5] = pole[(i % 2)];
                            hodVer = true;
                        }
                        else if (x == "5" && pole[6] == "5")
                        {
                            pole[6] = pole[(i % 2)];
                            hodVer = true;
                        }
                        else if (x == "6" && pole[7] == "6")
                        {
                            pole[7] = pole[(i % 2)];
                            hodVer = true;
                        }
                        else if (x == "7" && pole[8] == "7")
                        {
                            pole[8] = pole[(i % 2)];
                            hodVer = true;
                        }
                        else if (x == "8" && pole[9] == "8")
                        {
                            pole[9] = pole[(i % 2)];
                            hodVer = true;
                        }
                        else if (x == "9" && pole[10] == "9")
                        {
                            pole[10] = pole[(i % 2)];
                            hodVer = true;
                        }
                        else
                        {
                            Console.WriteLine("Неправильный ход.");
                            Console.WriteLine("Укажите свободное поле: ");
                        };
                    };
                }
            }
            //Результат игры

            //Сыграть ещё раз?
        }

    }
}
