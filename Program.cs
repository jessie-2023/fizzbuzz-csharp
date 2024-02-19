// See https://aka.ms/new-console-template for more information
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

using System.ComponentModel.DataAnnotations;

Console.WriteLine("\n=======strech 1: Bang for 7, FizzBuzz==============");
for (int i=1; i <=300; i++)
{
    List<string> output = [];

    string fizz = "";
    if (i % 3 == 0){fizz = "Fizz";}  
    string buzz = "";
    if (i % 5 == 0){buzz = "Buzz";}
    string bang = "";
    if (i % 7 == 0){bang = "Bang";}
    string bong = "";
    if (i % 11 == 0){bong = "Bong";}
    string fezz = "";
    if (i % 13 == 0){fezz = "Fezz";}

    // bong only for 11*n, otherwise append fizz buzz bang  
    if (i % 11 == 0) 
    {       
        output = [bong];
    }  
    else
    {
        output = [fizz, buzz, bang];
    }
    // check if converted to string or not
    bool noStr = output.All(str => str == "");

    // fezz goes befor first B or append
    if (i % 13 == 0)
    {    
        if (noStr)
        {
            output = [fezz];
        }
        else if (output.All(str => str.IndexOf('B') == -1)) // fizz only
        {
            output.Add(fezz);
        }
        else
        {
            int bWordIndex = output.FindIndex(str => str.StartsWith('B'));
            output.Insert(bWordIndex, fezz);
        }   
    }

    // reverse for 17
    if (i % 17 == 0)
    {
        output.Reverse();
    }

    if (output.All(x => x == "")) 
    {
        Console.Write(i + " ");
    }
    else 
    {
        foreach (string element in output)
        {
            Console.Write(element);
        }
        Console.Write(" ");
    }

}
