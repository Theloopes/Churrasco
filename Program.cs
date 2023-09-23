Console.WriteLine("Vamos organizar seu churrasco!");
Console.WriteLine("");
Console.WriteLine("Quantos adultos vão comparecer?");
double adultos = Convert.ToInt32(Console.ReadLine()!);
Console.WriteLine("Desses adultos, quantos consomem bebidas alcoólicas?");
double alcool = Convert.ToInt32(Console.ReadLine()!);
Console.WriteLine("Quantas crianças vão comparecer?");
double criancas = Convert.ToInt32(Console.ReadLine()!);

double naoalcool;

if (adultos < alcool)
{
    naoalcool = alcool - adultos;
}
else
{
    naoalcool = adultos - alcool;
}

double carne = (adultos * 0.4) + criancas * 0.2;
double acomp = (adultos * 0.2) + criancas * 0.2;
double refri = (naoalcool * 0.5) + criancas * 0.5;
double agua = (adultos * 0.4) + criancas * 0.4;
double cerveja = (alcool * 2);

Console.Clear();
Console.WriteLine("--- Churrasco ---");
Console.WriteLine("");
Console.WriteLine($"Adultos (que consomem bebidas alcoólicas).......: {alcool}");
Console.WriteLine($"Adultos (que não consomem bebidas alcoólicas)...: {naoalcool}");
Console.WriteLine($"Crianças........................................: {criancas}");
Console.WriteLine("");
Console.WriteLine($"Carne.............: {carne}Kg");
Console.WriteLine($"Acompanhamentos...: {acomp}Kg");
Console.WriteLine($"Cerveja...........: {cerveja}L");
Console.WriteLine($"Refrigerante......: {refri}L");
Console.WriteLine($"Água..............: {agua}L");
Console.WriteLine("");
