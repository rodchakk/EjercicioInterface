






using EjercicioInterface;

MainClass mainClass = new MainClass();  









Console.WriteLine("Ingrese [1]Calculo Area,     [2]Calculo Volumen Cubo");
Console.WriteLine("        [3]Calculo Raiz      [4] Calculo Mitad de una Suma");
int opc = 0;

opc = int.Parse(Console.ReadLine());


switch (opc)
{

    case 1:


        mainClass.Area();


        break;



    case 2:

        mainClass.Volumen_Cubo();
        break;


    case 3:

        mainClass.Raiz_Suma();

        break;

    case 4:

        mainClass.Mitad_Suma();
        break;



    default:
        Console.WriteLine("Opcion no valida, ingrese valor correcto");
        break;


}







