Console.WriteLine($"Введите числа b1, k1, b2, k2: ");
double b1 = Convert.ToInt32(Console.ReadLine());
double k1 = Convert.ToInt32(Console.ReadLine());
double b2 = Convert.ToInt32(Console.ReadLine());
double k2 = Convert.ToInt32(Console.ReadLine());

double FindIntersection(double b1, double k1, double b2, double k2)
{   double x = 0;
    double y = 0;
    if((b1 == b2) && (k1 == k2))
    {
       Console.WriteLine("Прямые совпадают!"); 
    }
    else
    {
        if(k1 == k2)
        {Console.WriteLine("Прямые параллельны!"); }
        else{
    x = (b2-b1)/(k1-k2);
    y = (k1*(b2-b1))/(k1-k2)+b1;
    Console.WriteLine(x);
    Console.WriteLine(y);
        }
    }
   return 0;
}

double result = FindIntersection(b1, k1, b2, k2);