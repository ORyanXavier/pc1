string mes = "";
int dias = 0;

Console.Clear();
Console.WriteLine("---------------\n");
Console.WriteLine("dias de um mes");
Console.WriteLine("---------------\n");

Console.WriteLine(" informe o mes por extenso: ");
mes = Console.ReadLine()! .ToUpper();

switch(mes)
{
    case "JANEIRO":
    case "MARCO":
    case "MAIO":
    case "JULHO":
    case "AGOSTO":
    case "OUTUBRO":
    case "DEZEMBRO":
          dias = 31;
          break;

    case  "FEVEREIRO":
        dias = 28;
        break;


    case "ABRIL":
    case "JUNHO":
    case "SETEMBRO":
    case "NOVEMBRO":
         dias = 30;
         break;


default:
    Console.WriteLine("mes invalido");
    Environment.Exit(0);
    break;
}



Console.WriteLine($"O mes de {mes} possui {dias} dias");