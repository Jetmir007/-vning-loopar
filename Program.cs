// See https://aka.ms/new-console-template for more information



/*for(int tal=1; tal<= 20; tal++)
{
    Console.WriteLine(tal);
      
}


Console.Write("Skriv ett number ");

for(int i = int.Parse(Console.ReadLine());i<=101;i++)
{
    
    Console.Write(i);
    if(i!=101){
        Console.Write(", ");
    }


}
*/

int antalTal;
double summa = 0, input;
Console.Write("Antal tal som ska matas in");
antalTal = Convert.ToInt32(Console.ReadLine());
for (int i=1; i <= antalTal; i++)
{
    Console.Write("Skriv värde " + i + ": ");
    input = Convert.ToDouble(Console.ReadLine());
    summa = summa + input;

}
Console.WriteLine("Medelvärdet är: " + (summa / antalTal));