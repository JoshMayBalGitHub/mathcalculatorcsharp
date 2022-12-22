using System;

class Program {
    public static void Main(string[] args)
     {
        Console.WriteLine("Write SUB for calculating (not complete)");
        Console.WriteLine("Write CON for converting");
        SON:
        string ONS = Console.ReadLine();
        if (ONS == "SUB") {
            Console.WriteLine("OK calculating time!");
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(2));
            goto SUB;
        } 
        else if (ONS == "CON") {
            Console.WriteLine("OK converting time!");
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(2));
            goto CVO;
        }
        else
        {
            Console.WriteLine("Error, try again please.");
            goto SON;
        }
         ////// Temporary Calculator Here
         SUB:
         Console.WriteLine("Subtraction");
         float SN = Convert.ToSingle(Console.ReadLine());
         Console.WriteLine(SN);
         
         CVO:
         Console.WriteLine("Go to the thing you want to calculate");
         Console.WriteLine("Note: Fractions are not implemented yet...");
         Console.WriteLine("You might have to convert it into decimals first...");
         Console.WriteLine("MF for meters to feet");
         Console.WriteLine("MI for Meters to Inches");
         Console.WriteLine("MCM for Meters to Centimeters");
         Console.WriteLine("KGG for kilograms to grams");
         Console.WriteLine("GKG for Grams to Kilograms");
         Console.WriteLine("CF for Celsius to Fahrenheit");
         Console.WriteLine("FK for Farenheit to Kelvin");
         Console.WriteLine("CMCL for cubic centimeters to liters");
         Console.WriteLine("ICM for inches to centimeters");
         Console.WriteLine("PG for Pints to Gallons");
         
         CV:
         string CV = Console.ReadLine();
         if (CV == "MF") {
             Console.WriteLine("Ok, then...");
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(2));
         } 
         /////////////
         else if (CV == "MI") {
             Console.WriteLine("Ok, Then...");
             System.Threading.Thread.Sleep(TimeSpan.FromSeconds(2));
             goto MI;
         }
         /////////////
          else if (CV == "MCM") {
             Console.WriteLine("Ok, Then...");
             System.Threading.Thread.Sleep(TimeSpan.FromSeconds(2));
             goto MCM;
         }
         ///////////
         else if (CV == "KGG") {
             Console.WriteLine("Ok, Then...");
             System.Threading.Thread.Sleep(TimeSpan.FromSeconds(2));
             goto KGG;
         }
         //////////
         else if (CV == "GKG") {
             Console.WriteLine("Ok, Then...");
             System.Threading.Thread.Sleep(TimeSpan.FromSeconds(2));
             goto GKG;
         }
         //////////
         else if (CV == "CF") {
             Console.WriteLine("Ok, Then...");
             System.Threading.Thread.Sleep(TimeSpan.FromSeconds(2));
             goto CF;
         }
         else if (CV == "FK") {
             Console.WriteLine("Ok, Then...");
             System.Threading.Thread.Sleep(TimeSpan.FromSeconds(2));
             goto FK;
         }
         ///////////////
         else if (CV == "CMCL") {
             Console.WriteLine("Ok, Then...");
             System.Threading.Thread.Sleep(TimeSpan.FromSeconds(2));
             goto CMCL;
         }
         //////////////
         else if (CV == "ICM") {
             Console.WriteLine("Ok, Then...");
             System.Threading.Thread.Sleep(TimeSpan.FromSeconds(2));
             goto ICM;
         }
         ///////////
         else if (CV == "PG") {
             Console.WriteLine("Ok, Then...");
             System.Threading.Thread.Sleep(TimeSpan.FromSeconds(2));
             goto PG;
         }
         ////////////
         else {
             Console.WriteLine("Error, try again please.");
             goto CV;
         }
         ////// Meter to Feet
         Console.WriteLine("Type the meter number you want to convert to feet.");
         float numberM = Convert.ToSingle(Console.ReadLine());
         System.Threading.Thread.Sleep(TimeSpan.FromSeconds(2));
         Console.WriteLine(numberM * 3.28 + " feet");
         Console.WriteLine("Press 'Enter' to exit this...");
         Console.ReadLine();
         Environment.Exit(1);
         ///// Meter to Feet

         ///// Meters to Inches
         MI:
         Console.WriteLine("Type the Meters number you want to convert to Inches");
         float numberMI = Convert.ToSingle(Console.ReadLine());
         System.Threading.Thread.Sleep(TimeSpan.FromSeconds(2));
         Console.WriteLine(numberMI / 0.0254 + " inches");
         Console.WriteLine("Press 'Enter' to exit this...");
         Console.ReadLine();
         Environment.Exit(1);
        ///// Meters to Inches

        ///// Meters to Centimeters
        MCM:
        Console.WriteLine("Type the Meters number you want to convert to Centimeters");
         float numberMCM = Convert.ToSingle(Console.ReadLine());
         System.Threading.Thread.Sleep(TimeSpan.FromSeconds(2));
         Console.WriteLine(numberMCM * 100 + " centimeters");
         Console.WriteLine("Press 'Enter' to exit this...");
         Console.ReadLine();
         Environment.Exit(1);
        ///// Meters to Centimeters

         ///// Kilogram to Gram
         KGG:
         Console.WriteLine("Type the Kilogram number you want to convert to gram.");
         float numberKG = Convert.ToSingle(Console.ReadLine());
         System.Threading.Thread.Sleep(TimeSpan.FromSeconds(2));
         Console.WriteLine(numberKG * 1000 + " grams");
         Console.WriteLine("Press 'Enter' to exit this...");
         Console.ReadLine();
         Environment.Exit(1);
         ///// Kilogram to Gram

         ///// Gram to Kilogram
         GKG:
         Console.WriteLine("Type the gram number you want to convert to kilogram.");
         float numberG = Convert.ToSingle(Console.ReadLine());
         System.Threading.Thread.Sleep(TimeSpan.FromSeconds(2));
         Console.WriteLine(numberG / 1000 + " kilograms");
         Console.WriteLine("Press 'Enter' to exit this...");
         Console.ReadLine();
         Environment.Exit(1);
         ///// Gram to Kilogram

         ///// Celsius to Fahrenheit
         CF:
         Console.WriteLine("Type the Celsius number you want to convert to Fahrenheit.");
         float numberC = Convert.ToSingle(Console.ReadLine());
         System.Threading.Thread.Sleep(TimeSpan.FromSeconds(2));
         Console.WriteLine(numberC * 1.800 + 32.00 + " fahrenheit");
         Console.WriteLine("Press 'Enter' to exit this...");
         Console.ReadLine();
         Environment.Exit(1);
         ///// Celsius to Fahrenheit

         ///// Fahrenheit to Kelvin
         FK:
         Console.WriteLine("Type the Fahrenheit number you want to convert to Kelvin.");
         float numberF = Convert.ToSingle(Console.ReadLine());
         System.Threading.Thread.Sleep(TimeSpan.FromSeconds(2));
         Console.WriteLine(numberF - 32 / 1.80 + 273.15 + " fahrenheit");
         Console.WriteLine("Press 'Enter' to exit this...");
         Console.ReadLine();
         Environment.Exit(1);
         ///// Fahrenheit to Kelvin

         ///// Cubic CM to Liters
         CMCL:
         Console.WriteLine("Type the Cubic Centimeters number you want to convert to Liters");
         float numberCMC = Convert.ToSingle(Console.ReadLine());
         System.Threading.Thread.Sleep(TimeSpan.FromSeconds(2));
         Console.WriteLine(numberCMC * 0.001 + " liters");
         Console.WriteLine("Press 'Enter' to exit this...");
         Console.ReadLine();
         Environment.Exit(1);
         ///// Cubic CM to Liters

         ///// Inches to CM
         ICM:
         Console.WriteLine("Type the Inches number you want to convert to Centimeters");
         float numberI = Convert.ToSingle(Console.ReadLine());
         System.Threading.Thread.Sleep(TimeSpan.FromSeconds(2));
         Console.WriteLine(numberI * 2.54 + " centimeters");
         Console.WriteLine("Press 'Enter' to exit this...");
         Console.ReadLine();
         Environment.Exit(1);
         ///// Inches to CM

         ///// Pints to Gallons
         PG:
         Console.WriteLine("Type the Pints number you want to convert to Gallons");
         float numberP = Convert.ToSingle(Console.ReadLine());
         System.Threading.Thread.Sleep(TimeSpan.FromSeconds(2));
         Console.WriteLine(numberP * 0.125 + " gallons");
         Console.WriteLine("Press 'Enter' to exit this...");
         Console.ReadLine();
         Environment.Exit(1);
        ///// Pints to Gallons
         
     }
 }