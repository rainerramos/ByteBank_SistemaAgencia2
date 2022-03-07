using System;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(847, 458954);

            FuncionarioAutenticavel carlos = null;
            carlos.Autenticar("ahushuahfaf");
            AutenticacaoHelper teste;
                            
            Console.WriteLine(conta.Numero);

            Console.ReadLine();
        }
    }
}
