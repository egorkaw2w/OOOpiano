using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp6
{
    internal class Program
    {
        static int[] choosenActive = new int[12] { 65, 69, 73, 77, 82, 87, 92, 98, 103, 110, 116, 123 };
        static void Sound_1(ConsoleKeyInfo txt)
        {

            if (txt.Key == ConsoleKey.S) //До
            {
                Console.Beep(choosenActive[1], 100);
            }
            if (txt.Key == ConsoleKey.Q) // До#
            {
                Console.Beep(choosenActive[0], 100);
            }
            if (txt.Key == ConsoleKey.D) // Ре
            {
                Console.Beep(choosenActive[2], 100);
            }
            if (txt.Key == ConsoleKey.R)// ре#
            {
                Console.Beep(choosenActive[3], 100);
            }
            if (txt.Key == ConsoleKey.F) // Ми
            {
                Console.Beep(choosenActive[4], 100);
            }
            if (txt.Key == ConsoleKey.T) // Фа#
            {
                Console.Beep(choosenActive[5], 100);
            }
            if (txt.Key == ConsoleKey.G) // Фа
            {
                Console.Beep(choosenActive[6], 100);
            }
            if (txt.Key == ConsoleKey.Y) // Соль#
            {
                Console.Beep(choosenActive[7], 100);
            }
            if (txt.Key == ConsoleKey.H) // Соль
            {
                Console.Beep(choosenActive[8], 100);
            }
            if (txt.Key == ConsoleKey.J) // Ля
            {
                Console.Beep(choosenActive[9], 100);
            }
            if (txt.Key == ConsoleKey.I) // Ля#
            {
                Console.Beep(choosenActive[10], 100);
            }
            if (txt.Key == ConsoleKey.K) // Си
            {
                Console.Beep(choosenActive[11], 100);
            }

        }
        static void Octava(ConsoleKeyInfo txt)
        {

            while (true)
            {

                if (txt.Key == ConsoleKey.F1)
                {
                    choosenActive = new int[12] { 65, 69, 73, 77, 82, 87, 92, 98, 103, 110, 116, 123 };
                    Console.WriteLine("Ето первая октава");
                    break;
                }
                if (txt.Key == ConsoleKey.F2)
                {
                    choosenActive = new int[12] { 130, 138, 146, 155, 164, 174, 185, 196, 207, 220, 233, 246 };
                    Console.WriteLine("Ето вторая октава");
                    break;
                }
                if (txt.Key == ConsoleKey.F3)
                {
                    choosenActive = new int[12] { 261, 277, 293, 311, 329, 349, 370, 392, 415, 440, 466, 493 };
                    Console.WriteLine("Ето третья октава");
                    break;
                }
                if (txt.Key == ConsoleKey.F4)
                {
                    choosenActive = new int[12] { 523, 554, 587, 622, 659, 698, 740, 784, 830, 880, 932, 987 };
                    Console.WriteLine("Ето четвёртая октава");
                    break;
                }
                if (txt.Key == ConsoleKey.F5)
                {
                    choosenActive = new int[12] { 1046, 1108, 1174, 1244, 1318, 1397, 1480, 1568, 1661, 1760, 1864, 1975 };
                    Console.WriteLine("Ето пятая октава");
                    break;
                }
                if (txt.Key == ConsoleKey.F6)
                {
                    choosenActive = new int[12] { 2093, 2217, 2349, 2489, 2637, 2794, 2960, 3136, 3322, 3520, 3729, 3951 };
                    Console.WriteLine("Ето шестая октава");
                    break;
                }
                if (txt.Key == ConsoleKey.F7)
                {
                    choosenActive = new int[12] { 4186, 4435, 4699, 4978, 5274, 5588, 5920, 6272, 6645, 7040, 7459, 7902 };
                    Console.WriteLine("Ето седьмая октава");
                    break;
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("            !!!!!           ВНИМАНИЕ       !!!!!                        ");
            Console.WriteLine();
            Console.WriteLine("         ВСЕ ЧАСТОТЫ УКАЗАНЫ В СИСТЕМЕ КООРДИНАТ АВТОРА!     "           );
            Console.WriteLine("              т.е. 1 - это втортая, а 7 - это восьмая октавы!"           );
            Console.WriteLine();
            Console.WriteLine("         Управление сей машины смерти    ");
            Console.WriteLine("      1. До - S               |                 8. До#  - Q             ");
            Console.WriteLine("      2. Ре - D               |                  9. Ре#  - R            ");
            Console.WriteLine("      3. Ми - F               |                 10. Фа№  - T            ");
            Console.WriteLine("      4. Фа - G               |                 11.Соль# - Y            ");
            Console.WriteLine("      5. Соль - H             |                 12.Ля#   - I            ");
            Console.WriteLine("      6. Ля - J               |               Бимолей нема              ");
            Console.WriteLine("      7. Си - K               |               педалей тоже :(           ");
            Console.WriteLine("                  CTRL + (F1 ---> F7) - Смена октав               ");

            while (true)
            {
                ConsoleKeyInfo txt = Console.ReadKey(true);
                if (txt.Modifiers.HasFlag(ConsoleModifiers.Control))
                {
                    Octava(txt);
                }
                Sound_1(txt);
            }

        }


    }
}
