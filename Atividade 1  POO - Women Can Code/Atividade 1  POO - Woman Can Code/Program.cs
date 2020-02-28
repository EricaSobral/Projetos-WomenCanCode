using System;

namespace Atividade_1__POO___Woman_Can_Code
{
    class Program
    {
        static void Main(string[] args)
        {
           //Instanciando classe membro
            
           Familia mae = new Familia();
                        
           mae.Nome = "Maria";
           mae.Sobrenome = "Silva";
           mae.Idade = 34;
           mae.Ocupacao = "Bancário";
           mae.GrauParentesco = "Mãe";
           mae.MinhaRenda = 1200;


            //Instanciando classe ContaFixa(ResponsavelPorPagar)
            mae.ResponsavelPorPagar = new ContasFixa();
            mae.ResponsavelPorPagar.ContaAgua = 100;
            mae.ResponsavelPorPagar.ContaEnergia = 200;
            

        
            //Criando objeto Membro Pai    

            Familia pai = new Familia();
            pai.Nome = "Rogério";
            pai.Idade = 45;
            pai.Ocupacao = "Comerciante";
            pai.GrauParentesco = "Pai";
            pai.Sobrenome = "Silva";
            pai.MinhaRenda = 6000;

            //Instanciando classe ContaFixa(ResponsavelPorPagar)
            pai.ResponsavelPorPagar = new ContasFixa();
            pai.ResponsavelPorPagar.ContaAlimentacao = 700;
            pai.ResponsavelPorPagar.ContaAluguel = 1200;

            //Criando objeto Membro Filho

            Familia filho = new Familia();

            filho.Nome = "Rafael";
            filho.Idade = 18;
            filho.Ocupacao = "Estágirio";
            filho.GrauParentesco = "Filho";
            filho.Sobrenome = "Silva";
            filho.MinhaRenda = 1500;

            filho.ResponsavelPorPagar = new ContasFixa();
            filho.ResponsavelPorPagar.ContaNET = 50;
            filho.ResponsavelPorPagar.ContaEducacao = 150;
            filho.ResponsavelPorPagar.ContaTransporte = 150;


            //Criando objeto Membro Avo

            Familia avo = new Familia();

            avo.Nome = "Nair";
            avo.Sobrenome = "Silva";
            avo.Idade = 72;
            avo.Ocupacao = "Aposentada";
            avo.GrauParentesco = "Avó";
            avo.MinhaRenda = 1300;

            avo.ResponsavelPorPagar = new ContasFixa();
            avo.ResponsavelPorPagar.Convenio = 550;

            int rendaTotal;
            rendaTotal = filho.MinhaRenda + mae.MinhaRenda + pai.MinhaRenda + avo.MinhaRenda;


            int gastoFilho;
            int gastoPai;
            int gastoMae;
            int gastoAvo = avo.ResponsavelPorPagar.Convenio; 

            gastoFilho = filho.ResponsavelPorPagar.ContaNET + filho.ResponsavelPorPagar.ContaEducacao + filho.ResponsavelPorPagar.ContaTransporte;
            gastoPai = pai.ResponsavelPorPagar.ContaAluguel + pai.ResponsavelPorPagar.ContaAlimentacao;
            gastoMae = mae.ResponsavelPorPagar.ContaAgua + mae.ResponsavelPorPagar.ContaEnergia;


            int totalGasto;

            totalGasto = gastoFilho + gastoMae + gastoPai + gastoAvo;

            int ptgPai;
            int ptgAvo;
            int ptgMae;
            int ptgFilho;


            ptgPai = (gastoPai*100)/totalGasto;
            ptgAvo = (gastoAvo * 100) / totalGasto;
            ptgMae = (gastoMae * 100) / totalGasto;
            ptgFilho = (gastoFilho * 100) / totalGasto;



            Console.WriteLine($"-------------------------------------------------------------------------------------------------\n" +
                $"A familia {mae.Sobrenome} é composta por: {pai.Nome} ({pai.GrauParentesco}), {mae.Nome} ({mae.GrauParentesco}), {filho.Nome} ({filho.GrauParentesco}) e {avo.Nome} ({avo.GrauParentesco})." +
                $"\n A renda mensal da familia é: { rendaTotal}. \n O gasto mensal é: {totalGasto}. " +
                $"\n O principal provedor é o: {pai.Nome}, é responsável por pagar {ptgPai}% do total do orçamento." +
                $"\n-------------------------------------------------------------------------------------------------" +
                $"\n {avo.Nome} tem {avo.Idade} anos, tem uma renda total de  {avo.MinhaRenda} e é responsável por pagar {ptgAvo}% do total dos gastos." +
                $"\n {mae.Nome} tem {mae.Idade} anos, tem uma renda total de {mae.MinhaRenda} e é reposável por {ptgMae}% do total dos gastos."+
                $"\n {filho.Nome} tem {filho.Idade} anos, tem uma renda total de {filho.MinhaRenda} e é responsável por {ptgFilho}% do total dos gastos"+
                 $"\n-------------------------------------------------------------------------------------------------");

          
          //  Console.WriteLine($"Qual a renda per capita?");
            //Console.WriteLine($"Qual");
        }
    }
}
