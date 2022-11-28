﻿namespace DesignPatterns.Decorator;

public class SmallPizza : IPizza
{
    public double CalculatePrice()
    {
        return 15;
    }
}