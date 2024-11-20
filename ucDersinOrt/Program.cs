int ders1, ders2, ders3;

Console.Write("1. Dersin Ortalamasını giriniz: ");
ders1 = Convert.ToInt32(Console.ReadLine());
Console.Write("2. Dersin Ortalamasını giriniz: ");
ders2 = Convert.ToInt32(Console.ReadLine());
Console.Write("3. Dersin Ortalamasını giriniz: ");
ders3 = Convert.ToInt32(Console.ReadLine());

Console.Clear();

int dersOrt = (ders1 + ders2 + ders3) / 3;
if (dersOrt >= 50)
{
    Console.WriteLine("Öğrenci geçmiştir");
}
else if (dersOrt < 50)
{
    Console.WriteLine("Öğrenci Kalmıştır");
}

Console.ReadKey();
