using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaCorrente contaDoBruno = new ContaCorrente();

            contaDoBruno.titular = "Bruno";

            Console.WriteLine(contaDoBruno.saldo);
            
            contaDoBruno.Sacar(50);
            contaDoBruno.Depositar(500);

            Console.WriteLine(contaDoBruno.saldo);

            ContaCorrente contaDaGabriela = new ContaCorrente();

            contaDaGabriela.titular = "Gabriela";
           
            Console.WriteLine("Gabriela, saldo antes de transferir: " + contaDaGabriela.saldo);
            Console.WriteLine("Bruno, saldo antes de transferir: " + contaDoBruno.saldo);

            contaDaGabriela.Transferir(50, contaDoBruno);

            Console.WriteLine("Bruno, saldo após transferência: " + contaDoBruno.saldo);
            Console.WriteLine("Gabriela, saldo após transferência: " + contaDaGabriela.saldo);


            Console.ReadLine();
        }
    }
}
