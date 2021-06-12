using System;

// ReSharper disable once IdentifierTypo
namespace Hangfire.Jobs
{
    public class PrintJob : IPrintJob
    {
        public void Print()
        {
            Console.WriteLine($"Hang-fire recurring print job!");
        }
    }
}
