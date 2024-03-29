﻿// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Console.WriteLine("\n=======part 2: prints every number from 1 to 100==============");
// for (int i=1; i <=100; i++)
// {
//     // Console.WriteLine(i); // auto new line
//     Console.Write(i + " "); // '' is only for single character, need to use "" for string
// }

// Console.WriteLine("\n=======part3: print “Fizz“ whenever the number is a multiple of 3==============");
// for (int i=1; i <=100; i++)
// {
//     if (i % 3 == 0 )
//     {
//         Console.Write("Fizz "); 
//     }
//     else
//     {
//         Console.Write(i + " ");
//     }
// }

// Console.WriteLine("\n=======part4: Buzz for 5, FizzBuzz==============");
// for (int i=1; i <=100; i++)
// {
//     if (i % 15 == 0)
//     {
//         Console.Write("FizzBuzz "); 
//     }
//     else if (i % 3 == 0)
//     {
//         Console.Write("Fizz "); 
//     }
//     else if (i % 5 == 0)
//     {
//         Console.Write("Buzz "); 
//     }
//     else
//     {
//         Console.Write(i + " ");
//     }
// }

// Console.WriteLine("Please enter the range: ");
// int range = int.Parse(Console.ReadLine());

// for (int i=1; i <=range; i++)
// {
//     List<string> output = [];

//     string fizz = "";
//     if (i % 3 == 0){fizz = "Fizz";}  
//     string buzz = "";
//     if (i % 5 == 0){buzz = "Buzz";}
//     string bang = "";
//     if (i % 7 == 0){bang = "Bang";}
//     string bong = "";
//     if (i % 11 == 0){bong = "Bong";}
//     string fezz = "";
//     if (i % 13 == 0){fezz = "Fezz";}

//     // 3, 5, 7: append fizz buzz bang  
//     output = [fizz, buzz, bang];

//     // 11: bong 
//     if (i % 11 == 0){output = [bong];}  

//     // check if converted to string or not
//     bool noStr = output.All(str => str == "");

//     // 13: fezz goes befor first B or append
//     if (i % 13 == 0)
//     {    
//         if (noStr)
//         {
//             output = [fezz];
//         }
//         else if (output.All(str => str.IndexOf('B') == -1)) // fizz only
//         {
//             output.Add(fezz);
//         }
//         else
//         {
//             int bWordIndex = output.FindIndex(str => str.StartsWith('B'));
//             output.Insert(bWordIndex, fezz);
//         }   
//     }
//     // 17: reverse printed words
//     if (i % 17 == 0)
//     {
//         output.Reverse();
//     }

//     // print number or output
//     if (noStr) 
//     {
//         Console.Write(i + " ");
//     }
//     else 
//     {
//         foreach (string element in output)
//         {
//             Console.Write(element);
//         }
//         Console.Write(" ");
//     }

// }

using System.Security.Cryptography;

Console.WriteLine("What is the oven temperature? ");
var ovenTemp = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine("======An if-else block=====");
if (ovenTemp < 180)
{
    Console.WriteLine("The oven is too cold to cook a potato.");
}
else if (ovenTemp > 220)
{
    Console.WriteLine("The oven is too hot to cook a potato.");
}
else
{
    Console.WriteLine("The oven is just right to cook a potato.");
}


Console.WriteLine("======Ternary conditional operators=====");
Console.WriteLine
(
    ovenTemp < 180 
        ? "The oven is too cold to cook a potato."
        : ovenTemp > 220 
            ? "The oven is too hot to cook a potato."
            : "The oven is just right to cook a potato."
);

Console.WriteLine("======A switch statement=====");
switch (ovenTemp)
{
    case < 180: 
        Console.WriteLine("The oven is too cold to cook a potato.");
        break;

    case > 220:
        Console.WriteLine("The oven is too hot to cook a potato.");
        break;

    default:
        Console.WriteLine("The oven is just right to cook a potato.");
        break; // must: 【error CS8070】: Control cannot fall out of switch from final case label ('default:')
}

Console.WriteLine("======A switch expression=====");
Console.WriteLine
(
    ovenTemp switch
    {
        < 180 => "The oven is too cold to cook a potato.",
        > 220 => "The oven is too hot to cook a potato.",
        _ => "The oven is just right to cook a potato.",
    }
);