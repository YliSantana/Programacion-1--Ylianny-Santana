// año bisiesto 
int year=0;


Console.Write("Introduce un año: ");
year = Convert.ToInt32(Console.ReadLine());
 if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
     Console.WriteLine("{0} es un año bisiesto",year);
else
    Console.WriteLine("{0} no es un año bisiesto",year);
 
Console.ReadLine();
   