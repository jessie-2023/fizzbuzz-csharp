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
for (int i=1; i <=1000; i++)
{
    string fizz = "";
    if (i % 3 == 0) {fizz = "Fizz";}  
    string buzz = "";
    if (i % 5 == 0){buzz = "Buzz";}
    string bang = "";
    if (i % 7 == 0){bang = "Bang";}

    // append fizz, buzz, bang
    string output = fizz + buzz + bang;

    // bong only
    string bong = "";
    if (i % 11 == 0) 
    {
        bong = "Bong";
        output = bong;
    }  
    
    // fezz goes befor first B or append
    string fezz = "";
    if (i % 13 == 0)
    {
        fezz = "Fezz";
        if (output == "")
        {
            output = fezz;
        }
        else if (output.IndexOf('B') == -1) // fizz only
        {
            output += fezz;
        }
        else if (bong != "") // bong only
        {
            output = fezz + output;
        }
        else if (buzz != "")
        {
            output = fizz + fezz + buzz + bang;
        }
        else if (bang != "")
        {
            output = fizz + buzz + fezz + bang;
        }
    }


    if (output == "") 
    {
        Console.Write(i + " ");
    }
    else 
    {
        Console.Write(output + " ");
    }
    

}
