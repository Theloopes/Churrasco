﻿Console.WriteLine("Vamos organizar seu churrasco!");
Console.WriteLine("");
Console.WriteLine("Quantos adultos vão comparecer?");
double adultos = Convert.ToInt32(Console.ReadLine()!);
Console.WriteLine("Desses adultos, quantos consomem bebidas alcoólicas?");
double alcool = Convert.ToInt32(Console.ReadLine()!);
Console.WriteLine("Quantas crianças vão comparecer?");
double criancas = Convert.ToInt32(Console.ReadLine()!);

double carne = adultos * 400 + criancas * 200;
double acomp = adultos * 200 + criancas * 200;
double cerveja = adultos * 2000;
double refrigerante = adultos * 500 + criancas * 500;
double agua = adultos * 400 + criancas * 400;

Console.WriteLine("--- Churrasco ---");
Console.WriteLine("");
Console.WriteLine($"Adultos (que consomem bebidas alcoólicas).......: {adultos}");
Console.WriteLine($"Adultos (que não consomem bebidas alcoólicas)...: {alcool}");
Console.WriteLine($"Crianças........................................: {criancas}");
Console.WriteLine("");
Console.WriteLine($"Carne.............: {carne}Kg");
Console.WriteLine($"Acompanhamentos...: {acomp}Kg");
Console.WriteLine($"Cerveja...........: {cerveja}L");
Console.WriteLine($"Refrigerante......: {refrigerante}L");
Console.WriteLine($"Água..............: {agua}L");