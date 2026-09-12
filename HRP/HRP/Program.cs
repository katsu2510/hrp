global using System;
global using Microsoft.EntityFrameworkCore;
namespace HRP;

internal class Program
{
    static void Main(string[] args)
    {
       
        using var app = new Application();
        
        app.Run();
    }
}