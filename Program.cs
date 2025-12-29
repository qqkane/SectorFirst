using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using static System.Net.Mime.MediaTypeNames;

namespace CSHARP_L
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Базовые настройки окна
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Console.CursorVisible = false;
            Console.Title = "Sector First";
            Console.SetWindowSize(150, 40);
            Random rand = new Random();

            char[,] map =
            {
                {'┏','━','━','━','━','━','━','━','━','━','━','━','━','━','━','━','━','━','━','━','━','━','━','━','━','━','━','━','━','━','━','━','━','━','━','━','━','━','━','━','━','━','━','━','━','━','━','━','━','━','━','━','━','━','━','━','━','━','━','━','━','━','━','━','━','━','━','━','━','━','━','━','━','━','━','━','┓'},
                {'┃',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','┃'},
                {'┃',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','┃'},
                {'┃',' ','$','$',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','┃'},
                {'┃',' ',' ','$',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','┃'},
                {'┃',' ',' ','$',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','┃'},
                {'┃',' ',' ','$',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','┃'},
                {'┃',' ',' ','$',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','┃'},
                {'┃',' ',' ','$',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','┃'},
                {'┃',' ',' ','$',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','┃'},
                {'┃',' ',' ','$',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','┃'},
                {'┃',' ',' ','$',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','┃'},
                {'┃',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','┃'},
                {'┃',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','┃'},
                {'┃',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','┃'},
                {'┃',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','┃'},
                {'┃',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','┃'},
                {'┃',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','┃'},
                {'┃',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','┃'},
                {'┃',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','┃'},
                {'┃',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','┃'},
                {'┃',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','┃'},
                {'┃',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','┃'},
                {'┃',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','┃'},
                {'┃',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','┃'},
                {'┃',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','┃'},
                {'┃',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','┃'},
                {'┃',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','┃'},
                {'┃',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','┃'},
                {'┗','━','━','━','━','━','━','━','━','━','━','━','━','━','━','━','━','━','━','━','━','━','━','━','━','━','━','━','━','━','━','━','━','━','━','━','━','━','━','━','━','━','━','━','━','━','━','━','━','━','━','━','━','━','━','━','━','━','━','━','━','━','━','━','━','━','━','━','━','━','━','━','━','━','━','━','┛'}

            };
            // Инициализация переменных игрока
            // Создание коллекцию инвентаря
            List<char> Backpack = new List<char>();
            int health = 10; int maxHealth = 10;
            int userY = 1, userX = 1;

            // Символы которые являются стенами и не проходимыми
            char[] walls = new char[] { '━', '┃', '┏', '┓', '┗', '┛', '┣', '┫', '┻', '┳', '╋' };

            string playerName = "";

            
            ShowForeword(map, ref playerName);
            ConsoleKeyInfo openMenu = new ConsoleKeyInfo('\0', ConsoleKey.Escape, false, false, false);
            Menu(map, openMenu, playerName);

            // Функция для обновления событий в игре
            void RefreshGameFrame(ConsoleKeyInfo keyInfo1)
            {
                Console.SetCursorPosition(userX, userY);
                Console.Write('@');
                Moovement(ref map, keyInfo1, ref userX, ref userY, walls);
                Healthbar(health, maxHealth);
                Inventory(ref map, userY, userX, Backpack);
            }

            // Функция запуска уровня
            void StartGameLevel(ConsoleKeyInfo keyInfo) {
                if (keyInfo.Key == ConsoleKey.D1 || keyInfo.Key == ConsoleKey.NumPad1) {
                    userY = 1; userX = 1;
                    Console.Clear();
                    DrawMap(map);
                    Console.SetCursorPosition(userX, userY);
                    Console.Write('@');
                    Console.SetCursorPosition(0, 37);
                    Console.WriteLine("Для выхода в меню нажмите Esc");
                    while (true) {
                        keyInfo = Console.ReadKey(true);
                        switch (keyInfo.Key) {
                            case ConsoleKey.UpArrow or ConsoleKey.W: RefreshGameFrame(keyInfo); break;
                            case ConsoleKey.DownArrow or ConsoleKey.S: RefreshGameFrame(keyInfo); break;
                            case ConsoleKey.LeftArrow or ConsoleKey.A: RefreshGameFrame(keyInfo); break;
                            case ConsoleKey.RightArrow or ConsoleKey.D: RefreshGameFrame(keyInfo); break;

                            default: break;
                        }
                        if (keyInfo.Key == ConsoleKey.Escape) {
                            Menu(map, keyInfo, playerName);
                            break;
                        }
                        else { continue; }
                    }
                }
            }

            void Menu(char[,] map, ConsoleKeyInfo charKey, string playerName)
            {

                string MenuText = $"Привет, {playerName}! Что будем делать дальше?" +
                    $"\n" +
                    $"\n1. Играть" +
                    $"\n2. Уровни" +
                    $"\n3. Настройки" +
                    $"\n4. Выход из игры\n";

                if (charKey.Key == ConsoleKey.Escape)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"{MenuText}\n");
                    Console.ResetColor();
                    switch (charKey.Key)
                    {
                        case ConsoleKey.D1 or ConsoleKey.NumPad1: Console.Clear(); StartGameLevel(charKey); break;
                        case ConsoleKey.D2 or ConsoleKey.NumPad2: Console.Clear(); Console.WriteLine("T"); break;
                        case ConsoleKey.D3 or ConsoleKey.NumPad3: Console.Clear(); Console.WriteLine("T"); break;
                        case ConsoleKey.D4 or ConsoleKey.NumPad4: Console.Clear(); Console.WriteLine("Закрытие игры..."); System.Threading.Thread.Sleep(500); Environment.Exit(0); break;
                    }
                }

            }

            // Тело программы
            while (true)
            {
                // Получаем введённую букву
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                Menu(map, keyInfo, playerName);

                StartGameLevel(keyInfo);
            }
        }
        static void Moovement(ref char[,] map, ConsoleKeyInfo charKey, ref int userX, ref int userY, char[] wallsList)
        {
            // Локальная переменная координат игрока
            int nextX = userX; int nextY = userY;
            switch (charKey.Key)
            {
                // Свитч для обработки нажатий стрелочек
                case ConsoleKey.UpArrow or ConsoleKey.W: nextY--; break;
                case ConsoleKey.DownArrow or ConsoleKey.S: nextY++; break;
                case ConsoleKey.LeftArrow or ConsoleKey.A: nextX--; break;
                case ConsoleKey.RightArrow or ConsoleKey.D: nextX++; break;
            }

            // Проверка следующего блока куда человек хочет пойти, если это ' ' или '$' или 'X' то персонаж пройдёт
            if (!wallsList.Contains(map[nextY, nextX]))
            {
                // Очистка прошлых координат после того как пользователь ушёл с них
                Console.SetCursorPosition(userX, userY);
                Console.Write(map[userY, userX]);
                userX = nextX;
                userY = nextY;
                // Установка персонажа в userX/Y
                Console.SetCursorPosition(userX, userY);
                Console.Write("@");
            }
        }
        static void Inventory(ref char[,] map, int userY, int userX, List<char> Backpack)
        {
            Console.SetCursorPosition(0, 34);
            Console.WriteLine("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");
            Console.SetCursorPosition(18, 32);
            Console.Write("Inventory:");

            // Отрисовка вещей в инвентаре
            for (int i = 0; i < Backpack.Count; i++)
            {
                Console.Write(Backpack[i] + " ");
            }
            // Проверка наступления на вещи и добавление их в инвентарь
            if (map[userY, userX] == '$')
            {
                Console.SetCursorPosition(userX, userY);
                map[userY, userX] = 'X';
                Backpack.Add('$');
            }

        }
        static void Healthbar(int value, int maxValue, ConsoleColor color = ConsoleColor.Green, ConsoleColor colorBackground = ConsoleColor.Red)
        {
            Console.SetCursorPosition(0, 31);
            Console.WriteLine("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓\n┃ Health Points");
            ConsoleColor defaultColor = Console.BackgroundColor;
            string bar = "";

            // Заполнение бара в зависимости от хп
            for (int i = 0; i < value; i++)
            {
                bar += "░";
            }

            //Отрисовка бара ниже карты и установка цветов
            Console.SetCursorPosition(0, 33);
            Console.WriteLine("┃ ");
            Console.SetCursorPosition(2, 33);
            Console.Write('[');
            Console.BackgroundColor = color;
            Console.Write(bar);
            Console.BackgroundColor = colorBackground;
            bar = "";

            for (int i = value; i < maxValue; ++i)
            {
                bar += "░";
            }
            // Возвращение цвета обратно на дефолт
            Console.BackgroundColor = defaultColor;
            Console.Write("]");
        }
        static void DrawMap(char[,] map)
        {
            //Установка карты в левом верхнем углу
            Console.SetCursorPosition(0, 0);
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    Console.Write(map[i, j]);
                }
                Console.WriteLine();
            }
        }

        static void ShowForeword(char[,] map,ref string playerName)
        {
            int noPause = 0;
            int smallPause = 500;
            int mediumPause = 1500;
            int largePause = 2500;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Сигнал слаб... Вспышка... Тишина.");
            Thread.Sleep(largePause);
            Console.WriteLine("Ты приходишь в себя в холодном, металлическом коридоре.");
            Thread.Sleep(mediumPause);
            Console.WriteLine("В голове гулко отдается одно лишь слово: Сектор...");
            Thread.Sleep(mediumPause);
            Console.WriteLine("Сектор Первый.");
            Thread.Sleep(mediumPause);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\nНажмите любую клавишу, чтобы продолжить...");
            Console.ReadKey();
            Console.ResetColor();
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("========================================");
            Console.WriteLine("==                                    ==");
            Console.WriteLine("==   ДОБРО ПОЖАЛОВАТЬ В СЕКТОР №1     ==");
            Console.WriteLine("==                                    ==");
            Console.WriteLine("========================================");
            Console.ResetColor();


            
            Console.WriteLine("\nГеймплей:");
            System.Threading.Thread.Sleep(smallPause);
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\nВам предстоит передвигатся в комнатах на кнопки WASD/Стрелки, обыскивая их на наличие ключей.");
            System.Threading.Thread.Sleep(mediumPause);
            Console.WriteLine("\nС помощью ключей, вы сможете выбраться из заброшенного бункера.");
            System.Threading.Thread.Sleep(mediumPause);
            Console.WriteLine("\nТак же у вас есть 10 едениц здоровья, которые уменьшаются при получении урона от шипов и других ловушек.");
            System.Threading.Thread.Sleep(mediumPause);
            Console.WriteLine("\nЕсли ваше здоровье будет равно нулю, вы погибнете.");
            System.Threading.Thread.Sleep(mediumPause);
            Console.WriteLine("\nТак же на карте будут лежать аптечки, которые восстанавливают по 2 еденицы здоровья");
            System.Threading.Thread.Sleep(mediumPause);


            Console.ForegroundColor = ConsoleColor.White;
            
            while (true)
            {
                Console.Write("\nВведите ваш никнейм: ");
                playerName = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(playerName))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Никнейм не может быть пустым, попробуйте ещё раз...");
                    Console.ResetColor();
                }
                else {break;break; }
            }
            System.Threading.Thread.Sleep(mediumPause);

        }

    }
}

