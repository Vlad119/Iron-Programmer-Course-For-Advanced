using System;

public static class CodeGenerator
{
    public static int Get()
    {
        return new Random().Next(1000, 9999);
    }
}