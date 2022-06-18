int opcao;
double resultado = 0;
double resultadoConta;

double somarValor(double valor)
{
    Console.WriteLine("Qual valor deseja somar?");
    try
    {
        valor = double.Parse(Console.ReadLine());
        resultadoConta = resultado + valor;
        definirResultadoDaUltimaOperacaoMatematica(resultadoConta);
    }
    catch (FormatException CodError002)
    {
        Console.WriteLine("Você deve digitar um número. Erro: " + CodError002.Message);
    }

    return pegarResultadoDaUltimaOperacaoMatematica();
}

double subtrairValor(double valor)
{
    Console.WriteLine("Qual valor deseja subtrair?");
    try
    {
        valor = double.Parse(Console.ReadLine());
        resultadoConta = resultado - valor;
        definirResultadoDaUltimaOperacaoMatematica(resultadoConta);
    } catch (FormatException CodError002)
    {
        Console.WriteLine("Você deve digitar um número. Erro: " + CodError002.Message);
    }

    return pegarResultadoDaUltimaOperacaoMatematica();

}
void divisaoPorZero(double valor)
{
    if (valor == 0)
    {
        throw new DivideByZeroException(message: "Não pode ser zero.");
    }
}
double dividirValor(double valor)
{
    Console.WriteLine("Por qual valor deseja dividir?");
    try
    {            
        valor = double.Parse(Console.ReadLine());
        try
        {
            divisaoPorZero(valor);
            resultadoConta = resultado / valor;
            definirResultadoDaUltimaOperacaoMatematica(resultadoConta);
        }
        catch (Exception CodError001)
        {
            Console.WriteLine("Não é possível dividir por zero!");

        }
    }catch(FormatException CodError002)
    {
        Console.WriteLine("Você deve digitar um número. Erro: " + CodError002.Message);
    }

    return pegarResultadoDaUltimaOperacaoMatematica();

}

double multiplicarValor(double valor)
{
    Console.WriteLine("Por qual valor deseja multiplicar?");
    try
    {
        valor = double.Parse(Console.ReadLine());
        resultadoConta = resultado * valor;
        definirResultadoDaUltimaOperacaoMatematica(resultadoConta);
    }
    catch (FormatException CodError002)
    {
        Console.WriteLine("Você deve digitar um número. Erro: " + CodError002.Message);
    }

    return pegarResultadoDaUltimaOperacaoMatematica();

}

double zerarResultado()
{
   resultado = 0;
   return pegarResultadoDaUltimaOperacaoMatematica();

}

double pegarResultadoDaUltimaOperacaoMatematica()
{
        return resultado;    
}

void definirResultadoDaUltimaOperacaoMatematica(double resultadoDaOperacao)
{
   resultado = resultadoDaOperacao;
}


do
{
   
    Console.WriteLine("Escolha qual opção deseja realizar:");
    Console.WriteLine("1 - Somar");
    Console.WriteLine("2 - Subtrair");
    Console.WriteLine("3 - Multiplicar");
    Console.WriteLine("4 - Dividir");
    Console.WriteLine("5 - Zerar calculadora");
    Console.WriteLine("6 - Mostrar resultado atual");
    Console.WriteLine("7 - Sair da calculadora");

        opcao = int.Parse(Console.ReadLine());
        Console.WriteLine("Você digitou : " + opcao);
   


    switch (opcao)
    {
        case 1:
            
            somarValor(resultado);
            Console.WriteLine("O resultado é " + resultado);
        break;

       case 2:
            subtrairValor(resultado);
            Console.WriteLine("O resultado é " + resultado);
       break;

        case 3:
            multiplicarValor(resultado);
            Console.WriteLine("O resultado é " + resultado);
        break;

        case 4:
                dividirValor(resultado);
                Console.WriteLine("O resultado é " + resultado);
        break;

        case 5:
            zerarResultado();
            Console.WriteLine("Resultado zerado");
        break;

        case 6:
            Console.WriteLine("O resultado atual é de ");
            Console.WriteLine(pegarResultadoDaUltimaOperacaoMatematica());
        break;

        case 7:
           Console.WriteLine("Saindo da calculadora."); 
        break;

        default:
            Console.WriteLine("Opção inválida");
        break;
    }


} while (opcao !=7);

Console.WriteLine("Programa encerrado.");


