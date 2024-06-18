Console.Clear();
const double CapacidadeLata = 18;
const double CapacidadeGalao = 3.6;
 
const double MargemErro = 0.1;
const double Rendimento = 3;
 
double area, tinta;
double tintaEMLatas, tintaEMGaloes;
int latas, galoes;

 string cor;

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("--- CASA DE TINTA ---");
Console.ResetColor();
 
Colorir("\nEscolha a cor da sua tinta..: ",  ConsoleColor.DarkCyan);
cor = Convert.ToString(Console.ReadLine())!;
 
Colorir("\nÁrea a ser Preenchido (m²)...: ",  ConsoleColor.DarkCyan);
  
area = Convert.ToDouble(Console.ReadLine());
 
tinta = area / Rendimento;
tinta += tinta * MargemErro;
 
Colorir($"\nTotal de {tinta:N1} litro(s) de tinta.\n",  ConsoleColor.DarkCyan);
Console.ResetColor();
 
latas = (int)(tinta / CapacidadeLata);
tintaEMLatas = latas * CapacidadeLata;
 
galoes = (int)((tinta - tintaEMLatas) / CapacidadeGalao);
tintaEMGaloes = galoes * CapacidadeGalao;
 
if (tinta - tintaEMLatas - tintaEMGaloes > 0)
{
    galoes++;
}
 
Colorir("\nDistribuição: \n",  ConsoleColor.DarkCyan);
Colorir($"Latas...: {latas:N0} unidade(s)\n",  ConsoleColor.DarkCyan);
Colorir($"Galões..: {galoes:N0} unidade(s)\n",  ConsoleColor.DarkCyan);

Colorir("\nPressione uma tecla para finalizar....",  ConsoleColor.DarkCyan);
Console.ReadKey();
 
void Colorir(string texto, ConsoleColor cor)
{
    Console.ForegroundColor = cor;
    Console.Write(texto);
    Console.ResetColor();
}
