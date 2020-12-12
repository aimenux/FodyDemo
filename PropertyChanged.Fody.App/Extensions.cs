﻿using System;

namespace PropertyChanged.Fody.App
{
    public static class Extensions
    {
        public static void WriteLine(this ConsoleColor color, object value)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(value);
            Console.ResetColor();
        }
    }
}
