


Console.WriteLine("Hola");

Console.WriteLine("que operacion desea realizar?(suma,division,multiplicacion, resta)");
string operacion = Console.ReadLine();
switch (operacion) {

    case "suma":
        Console.WriteLine("Ingrese el primer numero");
        int num1 = Int32.Parse(Console.ReadLine());
        Console.WriteLine("ingrese el segundo numero");
        int num2 = Int32.Parse(Console.ReadLine());

        int suma = num1 + num2;
        Console.WriteLine($"la suma es:{suma}");
        break;

    case "division":

        Console.WriteLine("Ingrese el primer numero");
        double num3 = double.Parse(Console.ReadLine());
        Console.WriteLine("ingrese el segundo numero");
        double num4 = double.Parse(Console.ReadLine());
        if (num4 == 0) {
            Console.WriteLine("no se puede dividir entre cero");
            break;
        }

        double divi = num3 / num4;
        Console.WriteLine($"la division de los dos numero es:{divi}");
        break;
    case "multiplicacion":
        Console.WriteLine("Ingrese el primer numero");
        double num5 = double.Parse(Console.ReadLine());
        Console.WriteLine("ingrese el segundo numero");
        double num6 = double.Parse(Console.ReadLine());
        double producto = num5 * num6;
        Console.WriteLine($"el producto de los dos numero es:{producto}");
        break;
    case "resta":
        Console.WriteLine("Ingrese el primer numero");
        double num7 = double.Parse(Console.ReadLine());
        Console.WriteLine("ingrese el segundo numero");
        double num8 = double.Parse(Console.ReadLine());
        double residuo = num7-num8;
        Console.WriteLine($"el residuo de los dos numero es:{residuo}");





        break;

    default: Console.WriteLine("No existe esa funcion");

        break;

}
