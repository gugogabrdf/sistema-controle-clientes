using System;

namespace Atividade
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Informar Nome: ");
            string var_nome = Console.ReadLine();
            Console.WriteLine("Informar Endereço: ");
            string var_endereco = Console.ReadLine();
            Console.WriteLine("Para Pessoa Física(f) ou Pessoa Jurídica(j): ");
            string var_tipo = Console.ReadLine();

            if(var_tipo == "f")
            {
                Pessoa_Fisica pf = new Pessoa_Fisica();
                pf.nome = var_nome;
                pf.endereco = var_endereco;
                Console.WriteLine("Informar o CPF: ");
                pf.cpf = Console.ReadLine();
                Console.WriteLine("Informar o RG: ");
                pf.rg = Console.ReadLine();
                Console.WriteLine("Informar o Valor de Compra: ");
                float val_pag = float.Parse(Console.ReadLine());
                pf.Pagar_Imposto(val_pag);
                Console.WriteLine($"Nome: {pf.nome}, Total a Pagar: {pf.total}");
            }
            else if(var_tipo == "j")
            {
                Pessoa_Juridica pj = new Pessoa_Juridica();
                pj.nome = var_nome;
                pj.endereco = var_endereco;
                Console.WriteLine("Informar o CNPJ: ");
                pj.cnpj = Console.ReadLine();
                Console.WriteLine("Informar o IE: ");
                pj.ie = Console.ReadLine();
                Console.WriteLine("Informar o Valor de Compra: ");
                float val_pag = float.Parse(Console.ReadLine());
                pj.Pagar_Imposto(val_pag);
                Console.WriteLine($"Nome: {pj.nome}, Total a Pagar: {pj.total}");
            }
        }
    }
}