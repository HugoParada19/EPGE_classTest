using System;

namespace jogo;
public class Program
{
	public static void Main(String[] args)
	{
		monstro[] mon = new monstro[2]; //criar a array.
		mon[0] = new monstro();
		mon[0].setNome("Godzilla");
		mon[0].setEspecie("Iguana");
		mon[0].setEnergia(50);
		mon[0].setMalvadez(50);
		mon[0].setVelocidade(50); //Valores do Godzilla

		mon[1] = new monstro();
		mon[1].setNome("Gargulina");
		mon[1].setEspecie("Gargula");
		mon[1].setMalvadez(80);
		mon[1].setVelocidade(30);
		mon[1].setEnergia(30); //Valores da Gargulina

		for (int i = 0; i <= mon.Length - 1; i++)
		{
			Console.WriteLine(mon[i].mostrarCaract());
			Console.WriteLine();
		}

		Console.ReadLine();

		Console.WriteLine("A energia do Godzilla é: " + mon[0].obterEnergia().ToString());
		Console.ReadLine();

		Console.WriteLine("A malvadez da Gargulina é: " + mon[1].obterMalvadez().ToString());
		Console.ReadLine();
	}
}
