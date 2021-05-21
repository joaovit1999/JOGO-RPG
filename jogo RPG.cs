using System;

class Elir
{
	public static int Dano = 5;
	public static int Poder = 0;
	public static int Critico = 10;
	public static int HP = 50;
	public static int MaxHP = 50;
}

class Goblin
{
	public static int Dano = 2;
	public static int HP = 40;
}

class Esqueleto
{
	public static int Dano = 8;
	public static int HP = 10;
}

class ReiDemoniaco
{
	public static int Dano = 25;
	public static int HP = 150;
}

class HordaEsqueletos
{
	public static int Dano = 20;
	public static int HP = 30;
}

class Lobo
{
	public static int Dano = 2;
	public static int HP = 10;
}

class JavaliGigante
{
	public static int Dano = 6;
	public static int HP = 15;
}

class Raposa
{
	public static int Dano = 4;
	public static int HP = 20;
}

public class Program
{
	public static void Main()
	{

		//PRIMEIRA BATALHA - LOBO

		int FaltaPoder = 5;
		int total;

		Console.WriteLine("Um mundo de guerra e magia, este lugar é chamado de “A GRANDE CIVILIZAÇÃO”,\n" +
			"no entanto nunca soube o quão perigoso este mundo é até aquele dia. \n" +
			"Cresci em meio a um grupo circense, aprendi a atuar e tocar alaúde desde cedo, \n" +
			"claro até aquela época não conseguia fazer todos os acordes, mas já conseguia acompanhar a peça. ");
		Console.ReadLine();
		Console.WriteLine("Crescer neste meio faz você perceber que, todos são iguais, por exemplo, \n" +
			"em nossa trupe havia desde antigos soldados até prostitutas e foi em meio a isso que cresci, \n" +
			"aprendendo esgrima nas manhãs, aulas de teatro e leitura de poesia a tarde e na parte da noite \n" +
			"passávamos cantando, bebendo e dançando, não tínhamos muito, mas o que tínhamos era o suficiente. ");
		Console.ReadLine();
		Console.WriteLine("Com doze anos, nossa trupe estava indo para um pequeno condado perto da republica, \n" +
			"lugar de pessoas ignorantes, tratavam todas as trupes iguais, simplesmente nos menosprezavam, \n" +
			"infelizmente, não conseguimos chegar nesse condado, pois no meio do caminho, fomos atacados, \n" +
			"eu estava tomando banho no rio, quando voltei estava tudo destruído e todos mortos, por sorte, \n" +
			"encontrei um medalhão, ou uma placa de metal e tinha certeza de que aquilo significava alguma coisa.");
		Console.ReadLine();
		Console.WriteLine("Cavei um tumulo para todos ali, os enterrei e peguei o alaúde de meu pai e um cordão \n" +
			"que minha mãe sempre carregara, infelizmente dei Adeus ao meu passado maravilhoso e um \n" +
			"olá ao meu presente sombrio e cheio de sangue, ali, enquanto cavava a cova de meus pais, \n" +
			"decidi destruir tudo relacionado a esse medalhão, desde pessoas e condados, até o próprio rei\n" +
			" se for necessário.");
		Console.ReadLine();
		Console.WriteLine("Seu primeiro adversario sera o Lobo!\n");
		while (Elir.HP > 0 && Lobo.HP > 0)
		{
			Console.WriteLine("Para atacar digite 1, digite 2 para defender:\n");
			int opcao = int.Parse(Console.ReadLine());
			if (opcao == 1)
			{
				if (Elir.Poder == 5)
				{
					Lobo.HP -= Elir.Critico;
					Elir.Poder = 0;
					Console.WriteLine("Voce utilizou a arma especial!\n");
				}
				else
				{
					Lobo.HP -= Elir.Dano;
					Console.WriteLine("Voce atacou!\n");
				}
				Console.WriteLine("Seu HP é igual a {0}, e o HP de seu adversario é igual a {1}!\n", Elir.HP, Lobo.HP);
				Elir.HP -= Lobo.Dano;
			}
			else if (opcao == 2)
			{
				Elir.HP -= 1;
				Elir.Poder++;
				total = FaltaPoder - Elir.Poder;
				Console.WriteLine("Voce se defendeu, voce esta a {0} defesas de poder utilizar a arma especial!\n", total);
			}
			if (Lobo.HP > 0)
			{
				Console.WriteLine("Lobo te atacou!\n");
				Console.WriteLine("Seu HP é igual a {0}, e o HP de seu adversario é igual a {1}!\n", Elir.HP, Lobo.HP);
			}
		}
		if (Elir.HP <= 0)
		{
			Console.WriteLine("VOCE FOI DERROTADO PELO LOBO!\n");
			Environment.Exit(1);
		}
		else
		{
			Console.WriteLine("VOCE VENCEU O DESAFIO!\n");

		}

		//SEGUNDA BATALHA JAVALIS

		FaltaPoder = 5;
		total = 0;
		Elir.HP = Elir.MaxHP;
		Elir.Poder = 0;

		Console.WriteLine("");
		Console.WriteLine("Seu adversario será O Javali Gigante!\n");
		while (Elir.HP > 0 && JavaliGigante.HP > 0)
		{
			Console.WriteLine("Para atacar digite 1, digite 2 para defender:\n");
			int opcao = int.Parse(Console.ReadLine());
			if (opcao == 1)
			{
				if (Elir.Poder == 5)
				{
					JavaliGigante.HP -= Elir.Critico;
					Elir.Poder = 0;
					Console.WriteLine("Voce utilizou a arma especial!\n");
				}
				else
				{
					JavaliGigante.HP -= Elir.Dano;
				}
				Console.WriteLine("Seu HP é igual a {0}, e o HP de seu adversario é igual a {1}!\n", Elir.HP, JavaliGigante.HP);
				Elir.HP -= JavaliGigante.Dano;
			}
			else if (opcao == 2)
			{
				Elir.HP -= 1;
				Elir.Poder++;
				total = FaltaPoder - Elir.Poder;
				Console.WriteLine("Voce se defendeu, voce esta a {0} defesas de poder utilizar a arma especial!\n", total);
			}
			if (JavaliGigante.HP > 0)
			{
				Console.WriteLine("Javali Gigante te atacou!\n");
				Console.WriteLine("Seu HP é igual a {0}, e o HP de seu adversario é igual a {1}!\n", Elir.HP, JavaliGigante.HP);
			}
		}
		if (Elir.HP <= 0)
		{
			Console.WriteLine("VOCE FOI DERROTADO PELO JAVALI GIGANTE!\n");
			Environment.Exit(1);
		}
		else
		{
			Console.WriteLine("VOCE VENCEU O DESAFIO!\n");

		}

		//TERCEIRA BATALHA RAPOSA

		FaltaPoder = 5;
		total = 0;
		Elir.HP = Elir.MaxHP;
		Elir.Poder = 0;
		int rodada = 1;

		Console.WriteLine("");
		Console.WriteLine("Seu adversario será a Raposa!\n");
		while (Elir.HP > 0 && Raposa.HP > 0)
		{
			Console.WriteLine("Para atacar digite 1, digite 2 para defender:\n");
			int opcao = int.Parse(Console.ReadLine());
			if (opcao == 1)
			{
				if (Elir.Poder == 5)
				{
					Raposa.HP -= Elir.Critico;
					Elir.Poder = 0;
					Console.WriteLine("Voce utilizou a arma especial!\n");
				}
				else if (rodada == 5)
				{
					Console.WriteLine("Raposa se esquivou!");
					rodada = 0;
				}
				else
				{
					Raposa.HP -= Elir.Dano;
				}
				Console.WriteLine("Seu HP é igual a {0}, e o HP de seu adversario é igual a {1}!\n", Elir.HP, Raposa.HP);
				Elir.HP -= Raposa.Dano;
			}
			else if (opcao == 2)
			{
				Elir.HP -= 1;
				Elir.Poder++;
				total = FaltaPoder - Elir.Poder;
				Console.WriteLine("Voce se defendeu, voce esta a {0} defesas de poder utilizar a arma especial!\n", total);
			}
			if (Raposa.HP > 0)
			{
				Console.WriteLine("Raposa atacou voce!\n");
				Console.WriteLine("Seu HP é igual a {0}, e o HP de seu adversario é igual a {1}!\n", Elir.HP, Raposa.HP);
			}
			rodada++;
		}
		if (Elir.HP <= 0)
		{
			Console.WriteLine("VOCE FOI DERROTADO PELA RAPOSA!\n");
			Environment.Exit(1);
		}
		else
		{
			Console.WriteLine("VOCE VENCEU O DESAFIO!\n");

		}

		//QUARTA BATALHA GOBLIN 

		FaltaPoder = 5;
		total = 0;
		Elir.HP = Elir.MaxHP;
		Elir.Poder = 0;

		Console.WriteLine("");
		Console.WriteLine("Seu adversario será Goblin!\n");
		while (Elir.HP > 0 && Goblin.HP > 0)
		{
			Console.WriteLine("Para atacar digite 1, digite 2 para defender:\n");
			int opcao = int.Parse(Console.ReadLine());
			if (opcao == 1)
			{
				if (Elir.Poder == 5)
				{
					Goblin.HP -= Elir.Critico;
					Elir.Poder = 0;
					Console.WriteLine("Voce utilizou a arma especial!\n");
				}
				else
				{
					Goblin.HP -= Elir.Dano;
				}
				Console.WriteLine("Seu HP é igual a {0}, e o HP de seu adversario é igual a {1}!\n", Elir.HP, Goblin.HP);
				Elir.HP -= Goblin.Dano;
			}
			else if (opcao == 2)
			{
				Elir.HP -= 1;
				Elir.Poder++;
				total = FaltaPoder - Elir.Poder;
				Console.WriteLine("Voce se defendeu, voce esta a {0} defesas de poder utilizar a arma especial!\n", total);
			}
			if (Goblin.HP > 0)
			{
				Console.WriteLine("Goblin atacou voce!\n");
				Console.WriteLine("Seu HP é igual a {0}, e o HP de seu adversario é igual a {1}!\n", Elir.HP, Goblin.HP);
			}
		}
		if (Elir.HP <= 0)
		{
			Console.WriteLine("VOCE FOI DERROTADO POR GOBLIN!\n");
			Environment.Exit(1);
		}
		else
		{
			Console.WriteLine("VOCE VENCEU O DESAFIO!\n");

		}

		//QUINTA BATALHA ESQUELETO

		FaltaPoder = 5;
		total = 0;
		Elir.HP = Elir.MaxHP;
		Elir.Poder = 0;

		Console.WriteLine("");
		Console.WriteLine("Seu adversario será o Esqueleto!\n");
		while (Elir.HP > 0 && Esqueleto.HP > 0)
		{
			Console.WriteLine("Para atacar digite 1, digite 2 para defender:\n");
			int opcao = int.Parse(Console.ReadLine());
			if (opcao == 1)
			{
				if (Elir.Poder == 5)
				{
					Esqueleto.HP -= Elir.Critico;
					Elir.Poder = 0;
					Console.WriteLine("Voce utilizou a arma especial!\n");
				}
				else
				{
					Esqueleto.HP -= Elir.Dano;
				}
				Console.WriteLine("Seu HP é igual a {0}, e o HP de seu adversario é igual a {1}!\n", Elir.HP, Esqueleto.HP);
				Elir.HP -= Esqueleto.Dano;
			}
			else if (opcao == 2)
			{
				Elir.HP -= 1;
				Elir.Poder++;
				total = FaltaPoder - Elir.Poder;
				Console.WriteLine("Voce se defendeu, voce esta a {0} defesas de poder utilizar a arma especial!\n", total);
			}
			if (Esqueleto.HP > 0)
			{
				Console.WriteLine("Esqueleto atacou voce!");
				Console.WriteLine("Seu HP é igual a {0}, e o HP de seu adversario é igual a {1}!\n", Elir.HP, Esqueleto.HP);
			}
		}
		if (Elir.HP <= 0)
		{
			Console.WriteLine("VOCE FOI DERROTADO PELO ESQUELETO!\n");
			Environment.Exit(1);
		}
		else
		{
			Console.WriteLine("VOCE VENCEU O DESAFIO!\n");

		}

		//SEXTA BATALHA HORDA DE ESQUELETOS

		FaltaPoder = 5;
		total = 0;
		Elir.HP = Elir.MaxHP;
		Elir.Poder = 0;

		Console.WriteLine("");
		Console.WriteLine("Seu adversario será a Orda de Esqueletos!\n");
		while (Elir.HP > 0 && HordaEsqueletos.HP > 0)
		{
			Console.WriteLine("Para atacar digite 1, digite 2 para defender:\n");
			int opcao = int.Parse(Console.ReadLine());
			if (opcao == 1)
			{
				if (Elir.Poder == 5)
				{
					HordaEsqueletos.HP -= Elir.Critico;
					Elir.Poder = 0;
					Console.WriteLine("Voce utilizou a arma especial!\n");
				}
				else
				{
					HordaEsqueletos.HP -= Elir.Dano;
				}
				Console.WriteLine("Seu HP é igual a {0}, e o HP de seu adversario é igual a {1}!\n", Elir.HP, HordaEsqueletos.HP);
				Elir.HP -= HordaEsqueletos.Dano;
			}
			else if (opcao == 2)
			{
				Elir.HP -= 1;
				Elir.Poder++;
				total = FaltaPoder - Elir.Poder;
				Console.WriteLine("Voce se defendeu, voce esta a {0} defesas de poder utilizar a arma especial!\n", total);
			}
			if (HordaEsqueletos.HP > 0)
			{
				Console.WriteLine("Horda de Esqueletos atacou voce!");
				Console.WriteLine("Seu HP é igual a {0}, e o HP de seu adversario é igual a {1}!\n", Elir.HP, HordaEsqueletos.HP);
			}
		}
		if (Elir.HP <= 0)
		{
			Console.WriteLine("VOCE FOI DERROTADO PELA HORDA DE ESQUELETOS!\n");
			Environment.Exit(1);
		}
		else
		{
			Console.WriteLine("VOCE VENCEU O DESAFIO!\n");

		}

		//DESAFIO FINAL REI DEMONIACO

		FaltaPoder = 5;
		total = 0;
		Elir.HP = Elir.MaxHP;
		Elir.Poder = 0;

		Console.WriteLine("Após 10 anos de treino e estudo ele descobre q aquele grupo tinha sido contratado \n" +
			"pelo rei demoníaco,  para destruir as republica, no ataque a guarda real suprimiu os malfeitores \n" +
			"e garantiram a paz, no entanto, eu não estava satisfeito, fui em cada território demoníaco que \n" +
			"pude encontrar, destruindo tudo e recolhendo informação até que o dia de nossa luta, chegasse.");
		Console.ReadLine();
		Console.WriteLine("Voce conseguiu chegar ao desafio final!\nSeu ultimo oponente sera: \nREI DEMONIACO!");
		while (Elir.HP > 0 && ReiDemoniaco.HP > 0)
		{
			Console.WriteLine("Para atacar digite 1, digite 2 para defender:\n");
			int opcao = int.Parse(Console.ReadLine());
			if (opcao == 1)
			{
				if (Elir.Poder == 5)
				{
					ReiDemoniaco.HP -= Elir.Critico;
					Elir.Poder = 0;
					Console.WriteLine("Voce utilizou a arma especial!\n");
				}
				else
				{
					ReiDemoniaco.HP -= Elir.Dano;
				}
				Console.WriteLine("Seu HP é igual a {0}, e o HP de seu adversario é igual a {1}!\n", Elir.HP, ReiDemoniaco.HP);
				Elir.HP -= ReiDemoniaco.Dano;
			}
			else if (opcao == 2)
			{
				Elir.HP -= 1;
				Elir.Poder++;
				total = FaltaPoder - Elir.Poder;
				Console.WriteLine("Voce se defendeu, voce esta a {0} defesas de poder utilizar a arma especial!\n", total);
			}
			if (ReiDemoniaco.HP > 0)
			{
				Console.WriteLine("Rei Demoniaco atacou voce!");
				Console.WriteLine("Seu HP é igual a {0}, e o HP de seu adversario é igual a {1}!\n", Elir.HP, ReiDemoniaco.HP);
			}
		}
		if (Elir.HP <= 0)
		{
			Console.WriteLine("VOCE FOI DERROTADO PELO LICHT!\n");
			Environment.Exit(1);
		}
		else
		{
			Console.WriteLine("VOCE VENCEU O ULTIMO DESAFIO!\n");

		}
	}
}
