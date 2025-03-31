Console.Clear();

int adultoalcool = 0, adultosemalcool = 0, totaladultos, crianca = 0 ;
double carne = 0.0, acompanhamentos =0.0, cerveja = 0.0, refrigerante = 0.0 , agua = 0.0;
 
Console.WriteLine("###Dados para cálculo do Churrasco###");
 
Console.WriteLine("Indique a quantidade de adultos que consomem álcool:");
adultoalcool = Convert.ToInt32(Console.ReadLine()!);
 
Console.WriteLine("Indique a quantidade de adultos que não consumem álcool:");
adultosemalcool = Convert.ToInt32(Console.ReadLine()!);
 
Console.WriteLine("Diga a quantidade de crianças presentes:");
crianca = Convert.ToInt32(Console.ReadLine()!); 

totaladultos = adultoalcool + adultosemalcool;
 
carne = 0.4 *  totaladultos + (0.2 * crianca);
acompanhamentos = 0.2 * (totaladultos + crianca);
cerveja = 2 * adultoalcool;
refrigerante = 0.5 * (totaladultos + crianca);
agua = 0.4 * (totaladultos + crianca);
 
Console.WriteLine("--- Churrasco ---");
 
Console.WriteLine($"Adultos (que consomem bebidas alcoólicas).......: {adultoalcool}");
 
Console.WriteLine($"Adultos (que não consomem bebidas alcoólicas)...: {adultosemalcool}");
 
Console.WriteLine($"Crianças........................................: {crianca}");
 
Console.WriteLine($"Carne.............: {carne :N1} kg");
 
Console.WriteLine($"Acompanhamentos...: {acompanhamentos :N1} kg");
 
Console.WriteLine($"Cerveja...........:{cerveja :N1} l");

Console.WriteLine($"Refrigerante......:{refrigerante :N1} l");

Console.WriteLine($"Água..............:{agua :N1} l");

