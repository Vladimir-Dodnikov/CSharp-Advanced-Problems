﻿using System;
using System.Linq;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = Console.ReadLine()
                .Split()
                .Skip(1)
                .ToList();
            ListyIterator<string> list = new ListyIterator<string>(data);

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "END")
            {
                switch (input)
                {
                    case "Move":
                        Console.WriteLine(list.Move());
                        break;
                    case "HasNext":
                        Console.WriteLine(list.HasNext);
                        break;
                    case "Print":
                        try
                        {
                            list.Print();
                        }
                        catch (InvalidOperationException e)
                        {

                            Console.WriteLine(e.Message);
                        }
                        break;
                    case "PrintAll":
                        Console.WriteLine(string.Join(" ", list));
                        break;
                    default:
                        break;
                }

            }
        }
    }
}
