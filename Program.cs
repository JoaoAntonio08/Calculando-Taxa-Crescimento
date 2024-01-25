using System.Net.Security;

System.Console.WriteLine("Digite a população do primeiro país");
int populacaoA = int.Parse(Console.ReadLine());

System.Console.WriteLine("Digite a taxa de crescimento do primeiro país");
int taxaPaisA = int.Parse(Console.ReadLine());

System.Console.WriteLine("Digite a população do segundo país");
int populacaoB = int.Parse(Console.ReadLine());

System.Console.WriteLine("Digite a taxa de crescimento do segundo país");
int taxaPaisB = int.Parse(Console.ReadLine());
int contarAnos = 0;

do
{
    contarAnos += 1;

    populacaoA += RetornaDaPopulacao(populacaoA, taxaPaisA);
    populacaoB += RetornaDaPopulacao(populacaoB, taxaPaisB);
    System.Console.WriteLine($"Estamos no ano {contarAnos}");

} while (populacaoA < populacaoB);

System.Console.WriteLine($"A população do país A passou a do país B em {contarAnos} anos");
System.Console.WriteLine($"Sendo que atualmente a população do país A é de {populacaoA}");
System.Console.WriteLine($"E a população atualmente do país B é de {populacaoB}");

static int RetornaDaPopulacao(int parametroPopulacaoPais, int parametroTaxa)
{
    int resultado = (parametroPopulacaoPais * parametroTaxa) / 100;

    return resultado;
}