int num=0, counter=0, suma=0;

//Enunciado 1

//Ejercicio 1
while (counter<5)
{
    num++;
    if (num % 2 == 0)
    {
        Console.WriteLine(num);
        counter++;
    }
}

//Ejercicio 2
for (int i = 0; i <= 10; i++)
{
    suma +=i;
}
Console.WriteLine("La suma de los primeros 10 números naturales es: {0}",suma);

//Enunciado 2

//Ejercicio 1
int numero=0;
int sumita = 0;
do
{
    Console.WriteLine("Ingrese un número: ");
    int.TryParse(Console.ReadLine(), out numero);

    if (numero >0)
    {
        sumita += numero;
    }
} while (numero > 0);
Console.WriteLine("La suma de los números es {0}", sumita);

//Ejercicio 2
int num2 = 1;
while (true)
{
    if (num2%7==0 && num2%11==0)
    {
        Console.WriteLine($"El número positivo divisible entre 7 y 11 es: {num2}");
        break;
    }
    num2++;
}

//Enunciado 3

//Ejercicio 1
string contraseña = "jutiapa";
string? usuarioInsert;

do
{
    Console.WriteLine("Ingrese su contraseña");
    usuarioInsert = Console.ReadLine();

    if (usuarioInsert!=contraseña)
    {
        Console.WriteLine("Contraseña incorrecta!!!");
    }

} while (contraseña!=usuarioInsert);

Console.WriteLine("Contraseña correcta!");