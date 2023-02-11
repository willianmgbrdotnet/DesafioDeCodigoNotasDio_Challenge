using System; 

class minhaClasse {

    static void Main(string[] args) { 
/*Leia um valor de ponto flutuante com duas casas decimais. 
Este valor representa um valor monetário. A seguir, 
calcule o menor número de notas e moedas possíveis 
no qual o valor pode ser decomposto. As notas consideradas são de 
100, 50, 20, 10, 5, 2. As moedas possíveis são de 
1, 0.50, 0.25, 0.10, 0.05 e 0.01. A seguir mostre a relação de notas necessárias. */

            double valor;
            int inteiro, auxNotas, auxMoedas;

            
            valor = Convert.ToDouble(Console.ReadLine());

            inteiro = (int)valor;
            valor *= 100;
            auxMoedas = (int)valor;


            Console.WriteLine("NOTAS:");
            Console.WriteLine("{0} nota(s) de R$ 100.00", inteiro/100);
            auxNotas = (inteiro % 100);
            //complete o código
            Console.WriteLine("{0} nota(s) de R$ 50.00", auxNotas/50);
            auxNotas = (auxNotas % 50);
            Console.WriteLine("{0} nota(s) de R$ 20.00", auxNotas/20);
            auxNotas = (auxNotas % 20);
            Console.WriteLine("{0} nota(s) de R$ 10.00", auxNotas/10);
            auxNotas = (auxNotas % 10);
            Console.WriteLine("{0} nota(s) de R$ 5.00", auxNotas/5);
            auxNotas = (auxNotas % 5);
            Console.WriteLine("{0} nota(s) de R$ 2.00", auxNotas/2);
            auxNotas = (auxNotas % 2);            

            Console.WriteLine("MOEDAS:");
            Console.WriteLine("{0} moeda(s) de R$ 1.00", auxNotas / 1);
            auxMoedas %= 100;
            //complete o codigo
            Console.WriteLine("{0} moeda(s) de R$ 0.50", auxMoedas / 50);
            inteiro = auxMoedas % 50;
            Console.WriteLine("{0} moeda(s) de R$ 0.25", inteiro / 25);
            auxMoedas = inteiro % 25;
            Console.WriteLine("{0} moeda(s) de R$ 0.10", auxMoedas / 10);
            inteiro = auxMoedas % 10;
            Console.WriteLine("{0} moeda(s) de R$ 0.05", inteiro / 5);
            auxMoedas = inteiro % 5;
            Console.WriteLine("{0} moeda(s) de R$ 0.01", auxMoedas / 1);

    }

}