
int A = Int32.Parse(Console.ReadLine());
int B = Int32.Parse(Console.ReadLine());
int C = Int32.Parse(Console.ReadLine());
if (C > A + B)
{
    Console.WriteLine("3начение С превышает размер сторон прямоугольника, введите заного данные.");
    return;
}
int squadAB = A * B;
Console.WriteLine("Прямоугольник размера A*B равен " + squadAB);
int squadC = C * C;
Console.WriteLine("Квадрат стороны C равен " + squadC);
int squadCount = squadAB / squadC;
Console.WriteLine("На прямоугольнике размера A*B размещено максимально " + squadCount + " квадрат со стороной C");

int noUseSquad = squadAB % squadC;

Console.WriteLine("Площадь незанятой части прямоугольника равен " + noUseSquad);


