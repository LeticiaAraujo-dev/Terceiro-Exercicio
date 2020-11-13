using System;

namespace Terceiro_Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            //entrada de dados
            Console.WriteLine("Digite o valor do seu salário:");
            int salario = int.Parse(Console.ReadLine());

            //processo
            if(salario > 500){
                Console.WriteLine("Você não receberá um aumento no salário");
            }else{
                int aumento = (salario * 30)/100;
                int salarioN = aumento + salario;
                Console.WriteLine("Você receberá um aumento de "+aumento+ " reais e seu salário novo será "+salarioN+ " reais");
            }
        }
    }
}
