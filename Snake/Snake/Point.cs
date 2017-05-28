using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snake
{
    class Point
    {
        public int x;
        public int y;
        public char sym;

        //строим конструктор
        public Point()
        { 
        }

        // конструктор хочу присоздании новой точки вызывать фунцию которая понимает три аргумента
        public Point(int _x, int _y, char _sym)
        {
            //я хочу заполнить эти значения в переменных относящихся к данной точке
            x = _x;
            y = _y;
            sym = _sym;

        }
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}
