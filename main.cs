using System;
using System.Threading;

class MainClass {
  public static void Main (string[] args) {
   float ym = 0f;
  
   float ans = 0f;
   
Console.ForegroundColor = ConsoleColor.Cyan;

    Console.WriteLine("Enter 1 to figure out the slope m = ((y sub 2) - (y sub 1)) / ((x sub 2) - x sub 1))\n");
    
    Console.WriteLine("Enter 2 for slope of _ that pass through (x,y)\n");

Console.WriteLine("Enter 3 for slope and y intercept");

Console.WriteLine("\nEnter 4 for Trigonometric functions");

int geoMath = Convert.ToInt32(Console.ReadLine());


if (geoMath == 1)
{
  Console.WriteLine("Enter first y (x,y)");
  float firsty = float.Parse(Console.ReadLine());
  
  Console.WriteLine("Enter second y (x,y)");
  float secondy = float.Parse(Console.ReadLine());
  
  float GoY = firsty - secondy;
  Console.WriteLine("Now enter first x (x,y)");
  float firstx = float.Parse(Console.ReadLine());

  Console.WriteLine("Now Enter second x (x,y)");
  float secondx = float.Parse(Console.ReadLine());

  float GoX = firstx - secondx;
  float GoXY = GoY / GoX;
  Console.WriteLine($"Your slope is: {GoXY}");
  Console.WriteLine("Would you like to countinue? Y/N");
  string yesno = Console.ReadLine();
  if (yesno == "Y" || yesno == "y")
  {
ans = firsty - (GoXY * firstx);
Console.WriteLine($"Your equation is y ={GoXY}x + {ans}");


  }
  if (yesno == "N" || yesno == "n")
  {
    Console.WriteLine("Thanks you for using my calculator");
  Thread.Sleep(2000);
  Console.WriteLine("Press any key to close");
  Console.ReadKey();
  return;
  
  
  }
}

if (geoMath == 2)
{
Console.WriteLine("Enter slope in fractions");

  Console.WriteLine("Enter numerator");
  float numer = float.Parse(Console.ReadLine());
  Console.WriteLine("Enter denominator");
  float denom = float.Parse(Console.ReadLine());
  float madeSlope = numer / denom;

Console.WriteLine("Enter the x location (x,y)");
float firstx2 = float.Parse(Console.ReadLine());



float bx = firstx2;

Console.WriteLine("Enter y location (x,y)");


float firsty2 = float.Parse(Console.ReadLine());
ym = firsty2;
ans = ym - (madeSlope * bx) ;
Console.WriteLine("Your equation is y = " + madeSlope + "x"+ "+" + ans);


  
  
}
if (geoMath == 3)
{
  Console.WriteLine("Enter slope");
  float daslope = float.Parse(Console.ReadLine());
  Console.WriteLine("Enter y intercept");
  float daint = float.Parse(Console.ReadLine());
  Console.WriteLine($"Your equation is y = {daslope}x + {daint}");

  

  
  
  
} 

if (geoMath == 4)
{
  
                
                    Console.Write("Would you like to do abs, tan, sin, cos, tanh, cosh, sinh, or log: ");
                    string dacalculation = Console.ReadLine().ToUpper();
                    if (dacalculation == "TAN")
                    {
                        Console.Write("Enter a number: ");
                        int datan = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(Math.Tan(datan));
                    }
                     if (dacalculation == "SIN")
                    {
                        Console.Write("Enter a number: ");
                        int dasin = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(Math.Sin(dasin));
                    }
                     if (dacalculation == "COS")
                    {
                        Console.Write("Enter a number: ");
                        int dacos = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(Math.Cos(dacos));

                    }
                     if (dacalculation == "TANH")
                    {
                        Console.Write("Enter a Number: ");
                        int datanh = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(Math.Tanh(datanh));
                    }
                     if (dacalculation == "COSH")
                    {
                        Console.Write("Enter a number: ");
                        int dacosh = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(Math.Cosh(dacosh));
                    }
                     if (dacalculation == "SINH")
                    {
                        Console.Write("Enter a Number: ");
                        int dasinh = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(Math.Sinh(dasinh));
                    }
                     if (dacalculation == "LOG")
                    {
                        Console.Write("Enter a Base: ");
                        int BaseNumber = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter a Number: ");
                        int LogNumber = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(Math.Log(LogNumber, BaseNumber));
                    }
                     if (dacalculation == "ABS")
                    {
                        Console.Write("You can only use negative Numbers for this. Enter a Number: ");
                        double absNumber = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(Math.Abs(absNumber));
  
  
  
                        
}
 

  
}
   if (geoMath > 4|| geoMath < 1)
{
Console.ForegroundColor= ConsoleColor.DarkRed;
Console.WriteLine("Inavlid Input");
return;
}
  Console.WriteLine("Thanks you for using my calculator");
  Thread.Sleep(2000);
  Console.WriteLine("Press any key to close");
  Console.ReadKey();
  }

}
  
