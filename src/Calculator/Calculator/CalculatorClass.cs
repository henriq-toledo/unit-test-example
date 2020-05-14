using System;

namespace Calculator
{
    public class CalculatorClass
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public CalculatorClass(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int Sum() => X + Y;

        public int Minus() => Math.Abs(X - Y);

        public int Divide() => X / Y;

        public int Multiply() => X * Y;
    }
}
