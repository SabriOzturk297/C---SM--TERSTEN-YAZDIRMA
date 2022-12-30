Console.Write("Lütfen bir metin giriniz");
string metin = Console.ReadLine();
Console.WriteLine("Metnimizin ters hali");
for (int i = metin.Length - 1; i >= 0; i--)
{
    Console.Write(metin[i]);
}