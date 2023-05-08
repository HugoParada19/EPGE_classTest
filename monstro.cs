using System;
using System.Timers;

namespace jogo;
public class monstro
{
	private const int min = 0; //Valor minimo
	private const int max = 100; //Valor maximo

	private int energia, malvadez, velocidade;
	private string nome, especie;

	//variaveis principais

	public void setNome(string nome)
	{
		this.nome = nome;
	}

	public void setEspecie(string especie)
	{
		this.especie = especie;
	}

	public void setEnergia(int energia)
	{
		if (energia >= min && energia <= max)
			this.energia = energia;
		else
			this.energia = 50; //Em caso de divergencia (o valor é maior a 100 ou inferior a 0), o valor é corrigido para 50
	}

	public void setMalvadez(int malvadez)
	{
		if (malvadez >= min && malvadez <= max)
			this.malvadez = energia;
		else
			this.energia = 50;
	}

	public void setVelocidade(int velocidade)
	{
		if (velocidade >= min && velocidade <= max)
			this.velocidade = velocidade;
		else
			this.velocidade = 50;
	}

	public string mostrarCaract()
	{
		return "Nome: " + this.nome + " Especie: " + this.especie + " energia: " + this.energia.ToString() + " Malvadez: " + this.malvadez.ToString() + " Velocidade: " + this.velocidade.ToString();
	}

	public int obterEnergia()
	{
		return this.energia;
	}

	public void lutar(int tempo) //A variavel é contada como milisegundos
	{
		tempo *= 1000;
		long cTime = DateTime.Now.Ticks;

		while(DateTime.Now.Ticks <= cTime + tempo)
		{
			Thread.Sleep(5000); //Criar um temporizador de 5 segundos

			this.energia -= 10;
		}
	}

	public int obterMalvadez()
	{
		return this.velocidade;
	}
}
