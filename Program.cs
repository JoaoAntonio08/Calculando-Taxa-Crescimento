using System.Net.Security;

Console.Clear();
System.Console.WriteLine("############# Seja Bem Vindo ao programa de calcular taxa de crescimento #############");

#region Perguntar nome dos países
string nomePaisA, nomePaisb;
System.Console.WriteLine("");
System.Console.WriteLine("Para iniciarmos nosso programa digite o nome do primeiro país:");
nomePaisA = Console.ReadLine();
System.Console.WriteLine("");
System.Console.WriteLine("Agora digite o nome do segundo o país:");
nomePaisb = Console.ReadLine();
System.Console.WriteLine("");
#endregion Perguntar nome dos países

#region Informações
System.Console.WriteLine($"Digite a população do país {nomePaisA}");
int populacaoA = int.Parse(Console.ReadLine());

System.Console.WriteLine("");
System.Console.WriteLine($"Digite a taxa de crescimento do país {nomePaisA}");
int taxaPaisA = int.Parse(Console.ReadLine());

System.Console.WriteLine("");
System.Console.WriteLine($"Digite a população do país {nomePaisb}");
int populacaoB = int.Parse(Console.ReadLine());

System.Console.WriteLine("");
System.Console.WriteLine($"Digite a taxa de crescimento país {nomePaisb}");
int taxaPaisB = int.Parse(Console.ReadLine());
int contarAnos = 0;

#endregion Informações

do
{
    contarAnos += 1;

    populacaoA += RetornaDaPopulacao(populacaoA, taxaPaisA);
    populacaoB += RetornaDaPopulacao(populacaoB, taxaPaisB);
    System.Console.WriteLine($"----- Estamos no ano {contarAnos} -----");

} while (populacaoA > populacaoB);

System.Console.WriteLine($"A população do país {nomePaisb} passou a do país {nomePaisA} em {contarAnos} anos");
System.Console.WriteLine($"Sendo que atualmente a população do país {nomePaisA} é de {populacaoA}");
System.Console.WriteLine($"E a população atualmente do país {nomePaisb} é de {populacaoB}");

static int RetornaDaPopulacao(int parametroPopulacaoPais, int parametroTaxa)
{
    int resultado = (parametroPopulacaoPais * parametroTaxa) / 100;

    return resultado;
}