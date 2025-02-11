using CapaNegocio;

Negocio negocio = new Negocio();
var list = negocio.GetUsers();


int opcion;
string subOpcion;
string codigo;
var resultado = "";

do
{
    Console.WriteLine("------Sistema de Registro entrada y salida-----");
    Console.WriteLine();
    Console.WriteLine("Opciones");
    Console.WriteLine("[1] Ponchar");
    Console.WriteLine("[2] Administrar");
    Console.WriteLine("[3] Salir");
    opcion = int.Parse(Console.ReadLine());


    if (opcion == 1)
    {
        do
        {
            Console.WriteLine("------Ponchar-----");
            Console.WriteLine();
            Console.WriteLine("Opciones");
            Console.WriteLine("[E] Entrada");
            Console.WriteLine("[S] Salida");
            Console.WriteLine("[T] Terminar programa");
            subOpcion = Console.ReadLine();
            subOpcion = subOpcion.ToLower(); //converti la opcion en minusula

            switch (subOpcion)
            {
                case "e":
                    Console.WriteLine("Ingrese su codigo");
                    codigo = Console.ReadLine();
                    resultado = negocio.getCodigo(codigo);
                    Console.WriteLine(resultado);
                    break;

                case "s":
                    Console.WriteLine("Ingrese su codigo");
                    codigo = Console.ReadLine();
                    resultado = negocio.getCodigo(codigo);
                    Console.WriteLine(resultado);
                    break;

                case "t":
                    Console.WriteLine("Saliendoo");
                    break;

                default:
                    Console.WriteLine("Opcion incorrecta");
                    break;

            }
        }
        while (subOpcion.Contains("t"));
        
    }
    else
        if (opcion == 2)
    {
        do
        {
            Console.WriteLine("------Ponchar-----");
            Console.WriteLine();
            Console.WriteLine("Opciones");
            Console.WriteLine("[L] Lista de empleados");
            Console.WriteLine("[P] ******");
            Console.WriteLine("[T] Terminar programa");
            subOpcion = Console.ReadLine();
            subOpcion = subOpcion.ToLower(); //converti la opcion en minusula

            switch (subOpcion)
            {
                case "l":
                    Console.WriteLine("Lista de Empleados");
                    foreach (var item in list)
                    {
                        Console.WriteLine($"-{item.Codigo} || {item.Nombre} || {item.Departamento}");
                    }
                    break;

                case "p":
                    Console.WriteLine("Incognitoo");
                    break;

                default:
                    Console.WriteLine("Opcion incorrecta");
                    break;

            }
        }
        while (subOpcion.Contains("t"));


    }
    else
     if (opcion == 3){ 
         Console.WriteLine("Saliendooo");
    }
    else
    {
        Console.WriteLine("Opcion incorrecta");
    }

}
while (opcion != 3);
