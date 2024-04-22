using System;
class Program { 
    static void Main(string[] args)
    {   Calculadora calculadora = new Calculadora("MarcaC", "SerieC");
        Console.WriteLine($"1.Sumar: {calculadora.Sumar(1, 2)}");
        Console.WriteLine($"2.Restar: {calculadora.Restar(2, 1)}");
        Console.WriteLine($"3.Multiplicación: {calculadora.Multiplicar(2, 3)}");
        Console.WriteLine($"4.División: {calculadora.Dividir(15, 3)}");

        Calculadoracientifica calculadoraC = new Calculadoracientifica("MarcaCC", "SerieCC");
        Console.WriteLine($"5.Potencia: {calculadoraC.Potencia(1, 2)}");
        Console.WriteLine($"6.Raíz cuadrada: {calculadoraC.Raiz(2, 1)}");
        Console.WriteLine($"7.Módulo: {calculadoraC.Modulo(100, 2)}");
        Console.WriteLine($"8.Logaritmo: {calculadoraC.Logaritmo(100, 10)}");
    }
}
public class Calculadora
{ public string Marcac { get; set; }
    public string Seriec { get; set; }
    public Calculadora(string Marca, string Serie)
    {Marcac = Marca;
        Seriec = Serie; }
    public double Sumar(double a, double b)
    { return a + b; }
    public double Restar(double a, double b)
    {return a - b;}
    public double Multiplicar(double a, double b)
    { return a * b; }
    public double Dividir(double a, double b)
    { return a / b;}
}
public class Calculadoracientifica : Calculadora
{public Calculadoracientifica(string Marcacc, string Seriecc) : base(Marcacc, Seriecc)
    {}public double Potencia(double baseNum, double exponente)
    {return Math.Pow(baseNum, exponente);}
    public double Raiz(double numero, double raiz)
    {return Math.Pow(numero, 1 / raiz); }
    public double Modulo(double a, double b)
    {return a % b;}
    public double Logaritmo(double numero, double baseLogaritmo)
    {return Math.Log(numero, baseLogaritmo);}
}

