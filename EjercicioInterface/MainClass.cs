

namespace EjercicioInterface
{
    public class MainClass:IOperaciones
    {



        double a, b, resultado;



        public void Captura()
        {

            Console.WriteLine("Ingrese los datos para realizar operaciones");
            Console.WriteLine("");


            Console.WriteLine("Ingrese Primer numero: ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese Segundo numero: ");
            b = int.Parse(Console.ReadLine());


        }





        public void Imprimir()
        {

            Console.WriteLine($"El resultado es: {resultado}");


        }








        public void Area()
        {

            Console.WriteLine("");
            Console.WriteLine("Calculo de Area, Ingrese Alto y Ancho");
            Console.WriteLine("");

            Captura();
            resultado = a * b;
            Imprimir();
        }








        public void Volumen_Cubo()
        {
            Console.WriteLine("");
            Console.WriteLine("Calculo de Volumen de un cubo");
            Console.WriteLine("");
            Console.WriteLine("Ingrese el tamaño de uno de los lados del cubo en cm:");
            a = double.Parse(Console.ReadLine());
            resultado = Math.Pow(a, 3);
            Console.WriteLine($"El resultado es {resultado} cm3");



        }






        public void Raiz_Suma()
        {



            Console.WriteLine("Calculo de Raiz de una Suma");
            Console.WriteLine("");
            Captura();
            resultado = Math.Sqrt(a + b);
            Imprimir();




        }



        public void Mitad_Suma()
        {

            Console.WriteLine("Calculo Mitad de una suma");
            Console.WriteLine("");
            Captura();
            resultado = (a + b) / 2;
            Imprimir();



        }





    }




}

