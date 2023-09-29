using System;
public class Program
{
    public static void main(string[] args)
    {
        int a, b;
        //hien thi
        Console.WriteLine("Nhap a=");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("Nhap b=");
        b = int.Parse(Console.ReadLine());
        int tong = a + b;
        Console.WriteLine("tong a+b" + a + "+" + b + "=" + tong);
        //in ra ket qua
        Console.Read();
    }
}