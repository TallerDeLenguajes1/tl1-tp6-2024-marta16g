// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int a;
int b;
a = 10;
b = a;

Console.WriteLine("El valor de a es " + a);
Console.WriteLine("El valor de b es " + b);

//Punto 1

Console.WriteLine("Iniciando punto 1");

int numero;
int invertido;

Console.WriteLine("Ingrese un número");

if (int.TryParse(Console.ReadLine(), out numero))
{
    if (numero > 0)
    {
        invertido = invertirNumero(numero);
        Console.WriteLine("El numero invertido de " + numero + " es " + invertido);
    }
    else
    {
        Console.WriteLine("El número ingresado debe ser mayor a 0 sorry bye");
    }
}
else
{
    Console.WriteLine("Lo ingresado no es un numero chau");
};


static int invertirNumero(int num)
{

    int centenas, decenas, unidades, aux;
    if (num > 9)
    {
        if (!(num > 99))
        {
            decenas = num / 10;
            unidades = num % 10;

            aux = (unidades * 10) + decenas;
        }
        else
        {
            centenas = num / 100;
            num %= 100;

            decenas = num / 10;
            unidades = num % 10;

            aux = (unidades * 100) + (decenas * 10) + centenas;

        }
    }
    else
    {
        aux = num;
    };

    return aux;
};
//Punto 2

Console.WriteLine("Iniciando punto 2");

char letra;
Console.WriteLine("ELIJA LA OPERACION A REALIZAR: ");
Console.WriteLine("a) Sumar");
Console.WriteLine("b) Restar");
Console.WriteLine("c) Multiplicar");
Console.WriteLine("d) Dividir");


if (char.TryParse(Console.ReadLine(), out letra))
{
    if (letra < 69 && letra > 64 || letra < 101 && letra > 96)
    {
        switch (letra)
        {
            case :


            default:
        }
    }
}
else
{
    Console.WriteLine("No se ingresó una letra");
}



