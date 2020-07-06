using System;

namespace ByDenisRafi
{
    class Program
    {
        private static int Width;
        private static int Hieght;
        private static int LocationX;
        private static int LocationY;
        private static ConsoleColor BorderColor;
        public static void Draw()
        {
            string s = "╔";
            string space = "";
            string temp = "";
            for (int i = 0; i < Width; i++)
            {
                space += " ";
                s += "═";
            }
            for (int j = 0; j < LocationX; j++)
                temp += " ";
            s += "╗" + "\n";
            for (int i = 0; i < Hieght; i++)
                s += temp + "║" + space + "║" + "\n";
            s += temp + "╚";
            for (int i = 0; i < Width; i++)
                s += "═";
            s += "╝" + "\n";
            Console.ForegroundColor = BorderColor;
            Console.CursorTop = LocationY;
            Console.CursorLeft = LocationX;
            Console.Write(s);
            Console.ResetColor();
        }
        private static void ConsoleRectangle(int width, int hieght,
           int locationX, int locationY, ConsoleColor borderColor)
        {
            Width = width;
            Hieght = hieght;
            LocationX = locationX;
            LocationY = locationY;
            BorderColor = borderColor;
        }
        static void Main()
        {
            Console.Title = "How To Draw a Rectangle";
            ConsoleRectangle(20, 10, 7, 8, ConsoleColor.DarkGreen);
            Draw();
            Console.ReadLine();
        }
    }
}