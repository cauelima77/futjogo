using System;
using System.Diagnostics;
class Program
{


    //INICIAR O PROGRAMA
    static void Main(string[] args)
    {
        bool jogarNovamente = true;

        while (jogarNovamente)
        {
            LimparTela();

            JogoFutebol jogo = new JogoFutebol();
            jogo.IniciarJogo();

            Console.WriteLine("Deseja jogar novamente? (S/N)");
            string resposta = Console.ReadLine();
            jogarNovamente = (resposta.ToUpper() == "S");
        }
    }

    //LIMPAR A TELA
    static void LimparTela()
    {
        Console.Clear();
    }
}




class JogoFutebol
{
    private Jogador jogador;
    private Jogador jogador2;
    private Computador computador;

    private int golsJogador1 = 0;
    private int golsJogador2 = 0;
    private int pontosJogador1 = 0;
    private int pontosJogador2 = 0;


    private int golsJogador;
    private int golsComputador;

    private void LimparTela()
    {
        Console.Clear();
    }

    public JogoFutebol()
    {
        jogador = new Jogador();
        jogador2 = new Jogador();
        computador = new Computador();
       

    }


//INICIAR O JOGO
    public void IniciarJogo()
    {
        int pontosJogador = 0;
        int pontosComputador = 0;
        int golsJogador = 0;
        int golsComputador = 0;

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Digite o seu nome");
        Console.ResetColor();
        jogador.Nome = Console.ReadLine();

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Nome do jogador 2");
        Console.ResetColor();
        jogador2.Nome = Console.ReadLine();

        
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("----------------Futebol Score------------------");
        Console.ResetColor();
        Console.WriteLine($"1. {jogador.Nome} x Computador");
        Console.WriteLine($"2. {jogador.Nome}  x {jogador2.Nome}");
        Console.WriteLine($"3. CRÉDITOS E MAIS INFORMAÇÕES");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("-----------------------------------------------");
        Console.ResetColor();
        Console.WriteLine("Escolha uma das opções (1 ou 2)");
        int resp = int.Parse(Console.ReadLine());
        Console.ResetColor();

       

//ESCOLHER O MODO DE JOGO
        switch (resp)
        {
            case 1:
                //implementar a lógica para Computador X Jogador ****FEITO
                JogarPartidaContraComputador(ref pontosJogador, ref pontosComputador, ref golsJogador, ref golsComputador);
                
                ExibirResultado(jogador.Nome, "Computador", golsJogador, golsComputador,pontosJogador, pontosComputador);
                ExibirPlacar(jogador.Nome, "Computador", pontosJogador, pontosComputador);
                break;
            case 2:
                // Implementar a lógica para jogadores x jogadores ****FEITO
                 JogarPartidaEntreJogadores(ref pontosJogador, ref pontosComputador, ref golsJogador, ref golsComputador);

                 ExibirResultado(jogador.Nome, "Computador", golsJogador, golsComputador,pontosJogador, pontosComputador);
                 ExibirPlacar(jogador.Nome, "Computador", pontosJogador, pontosComputador);
                break;

               case 3: 
//---------------------------------------------------------------------------CRÉDITOS----------------------------------------------------------------------------\\

                LimparTela();

                Console.ForegroundColor = ConsoleColor.Yellow;
                
                
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Link dos 'criadores' do código (Digite 1 para acessar ou 2 para cancelar)");
                Console.WriteLine("");
                
                Console.WriteLine("░░░░░░░░▌▒█░░░░░░░░░░░▄▀▒▌ ");
                Console.WriteLine("░░░░░░░░▌▒▒█░░░░░░░░▄▀▒▒▒▐ ");
                Console.WriteLine("░░░░░░░▐▄▀▒▒▀▀▀▀▄▄▄▀▒▒▒▒▒▐ ");
                Console.WriteLine("░░░░░▄▄▀▒░▒▒▒▒▒▒▒▒▒█▒▒▄█▒▐ ");
                Console.WriteLine("░░░▄▀▒▒▒░░░▒▒▒░░░▒▒▒▀██▀▒▌ ");
                Console.WriteLine("░░▐▒▒▒▄▄▒▒▒▒░░░▒▒▒▒▒▒▒▀▄▒▒▌ ");
                Console.WriteLine("░░▌░░▌█▀▒▒▒▒▒▄▀█▄▒▒▒▒▒▒▒█▒▐ ");
                Console.WriteLine("░▐░░░▒▒▒▒▒▒▒▒▌██▀▒▒░░░▒▒▒▀▄▌ ");
                Console.WriteLine("░▌░▒▄██▄▒▒▒▒▒▒▒▒▒░░░░░░▒▒▒▒▌ ");
                Console.WriteLine("▌▒▀▐▄█▄█▌▄░▀▒▒░░░░░░░░░░▒▒▒▐ ");
                Console.WriteLine("▐▒▒▐▀▐▀▒░▄▄▒▄▒▒▒▒▒▒░▒░▒░▒▒▒▒▌ ");
                Console.WriteLine("▐▒▒▒▀▀▄▄▒▒▒▄▒▒▒▒▒▒▒▒░▒░▒░▒▒▐ ");
                Console.WriteLine("░▌▒▒▒▒▒▒▀▀▀▒▒▒▒▒▒░▒░▒░▒░▒▒▒▌ ");
                Console.WriteLine("░▐▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒░▒░▒▒▄▒▒▐ ");
                Console.WriteLine("░░▀▄▒▒▒▒▒▒▒▒▒▒▒░▒░▒░▒▄▒▒▒▒▌ ");
                Console.WriteLine("░░░░▀▄▒▒▒▒▒▒▒▒▒▒▄▄▄▀▒▒▒▒▄▀ ");
                Console.ResetColor();
                 string escolha = Console.ReadLine();

                  if (escolha == "1")
                   {
                      AbrirLinkArquivoWord();
                   }
                     else if (escolha == "2")
                     {
                        Console.WriteLine("Operação cancelada pelo usuário.");
                     }
                         else
                  {
                    Console.WriteLine("Opção inválida.");
                   }

static void AbrirLinkArquivoWord()
    {
        string link = "http://127.0.0.1:5500/index.html";

        try
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "cmd",
                Arguments = $"/c start {link}",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                CreateNoWindow = true
            });
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao abrir o link: {ex.Message}");
        }

    }

        
                break;

            default:
                Console.WriteLine("Opção inválida. Tente novamente.");
                break;
        }

        
    }
    

 //------------------------------------------------------JOGADOR1 X JOGADOR2 -------------------------------------------------------------------------------------
  private void JogarPartidaEntreJogadores(ref int pontosJogador, ref int pontosComputador, ref int golsJogador, ref int golsComputador)
    {
        Random random = new Random();
        int energiaJogador1 = 10;
        int energiaJogador2 = 10;

        Console.WriteLine($"{jogador.Nome} foi escolhido para começar primeiro");
        Console.WriteLine("Aperte ENTER para começar");
        Console.ReadLine();

        while (energiaJogador1 > 0 && energiaJogador2 > 0)
        {
            LimparTela();
            ExibirStatus(energiaJogador1, jogador2.Nome, energiaJogador2, pontosJogador, pontosComputador);

            Console.WriteLine("\n\n\n");

            // Vez do jogador 1

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Vez de {jogador.Nome}");
            Console.ResetColor();
            Console.ReadLine();
            int[] cartasJogador1 = GerarCartasAleatorias(random);
            int pontos1 = CalcularPontos(cartasJogador1, jogador.Nome, ref energiaJogador1);
            pontosJogador += pontos1;
            energiaJogador1--;

            // Vez do jogador 2
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Vez de {jogador2.Nome}");
            Console.ResetColor();
            Console.ReadLine();
            int[] cartasJogador2 = GerarCartasAleatorias(random);
            int pontos2 = CalcularPontos(cartasJogador2, jogador2.Nome, ref energiaJogador2);
            pontosComputador += pontos2;
            energiaJogador2--;
        }

        AtualizarGols(ref golsJogador, ref golsComputador, pontosJogador, pontosComputador);
        Console.WriteLine("Fim de jogo!");
    }


    //------------------------------------------------------COMPUTADOR X JOGADOR-------------------------------------------------------------------------------------
    private void JogarPartidaContraComputador(ref int pontosJogador, ref int pontosComputador, ref int golsJogador, ref int golsComputador)
    {
        Random random = new Random();
        int energiaJogador = 10;
        int energiaComputador = 10;

        Console.WriteLine($"{jogador.Nome} foi escolhido para começar primeiro");
        Console.WriteLine("Aperte ENTER para começar");
        Console.ReadLine();

        while (energiaJogador > 0 && energiaComputador > 0)
        {
            LimparTela();
            ExibirStatus(energiaJogador, "Computador", energiaComputador, pontosJogador, pontosComputador);

            Console.WriteLine("\n\n\n");

            //-----------------------------------Vez do jogador de jogar ***FEITO-------------------------------------------------------
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Vez de {jogador.Nome}");
            Console.ResetColor();
            Console.ReadLine();
            int[] cartasJogador = GerarCartasAleatorias(random);
            int pontos = CalcularPontos(cartasJogador, jogador.Nome, ref energiaJogador);
            pontosJogador += pontos;

            //-------------------------Reduzir energia do jogador após escolha ***FEITO-------------------------------------------------\\
            energiaJogador--;

            //--------------------------------------------------------------------------------------------------------------------------\\

            //-------------------------------Vez do Computador de jogar ***FEITO-------------------------------------------------------\\
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Vez do Computador");
            Console.ResetColor();

            //--------------------------------------------------------------------------------------------------------------------------\\


            int[] cartasComputador = GerarCartasAleatorias(random);
            int pontosComp = CalcularPontos(cartasComputador, "Computador", ref energiaComputador);
            pontosComputador += pontosComp;

            //-------------------------Reduzir energia do computador após escolha ***FEITO-------------------------------------------------\\
            energiaComputador--;
            //--------------------------------------------------------------------------------------------------------------------------\\
            
        }
        AtualizarGols(ref golsJogador, ref golsComputador, pontosJogador, pontosComputador);
        Console.WriteLine("Fim de jogo!");

    
    }

//EXIBIR RESULTADO DE AMBOS JOGADORES
    private void ExibirResultado(string nomeJogador1, string nomeJogador2, int golsJogador1, int golsJogador2, int pontosJogador, int pontosComputador)
    {
        Console.ReadLine();
        LimparTela();

        Console.WriteLine($"Qual opção você escolheu? 1-({nomeJogador1} x computador) ou 2-({nomeJogador1}  x {jogador2.Nome})");
        int resposta = int.Parse(Console.ReadLine());

        if (resposta == 1){
    
        Console.WriteLine("---------------------- Resultado Jogador x Computador (Caso escolheu 1)----------------------");
        Console.WriteLine($"Pontos de {nomeJogador1}: {pontosJogador}");
        Console.WriteLine($"Pontos de {nomeJogador2}: {pontosComputador}");
        Console.WriteLine($"GOLS de {nomeJogador1}: {golsJogador1}");
        Console.WriteLine($"GOLS de {nomeJogador2}: {golsJogador2}");
        Console.WriteLine("----------------------------------------------------------------------------------------------");
        }
        
        else if (resposta == 2){
   

        Console.WriteLine("---------------------- Resultado Jogador x jogador 2 (Caso escolheu 2)----------------------");
        Console.WriteLine($"Pontos de {jogador.Nome}: {pontosJogador}");
        Console.WriteLine($"Pontos de {jogador2.Nome}: {pontosComputador}");
        Console.WriteLine($"GOLS de {jogador.Nome}: {golsJogador1}");
        Console.WriteLine($"GOLS de {jogador2.Nome}: {golsJogador2}");
        Console.WriteLine("--------------------------------------------------------");



         if (resposta == 2 && golsJogador1 > golsJogador2 && pontosJogador>pontosComputador || golsJogador1 > golsJogador2 && pontosJogador<pontosComputador || golsJogador1 == golsJogador2 && pontosJogador>pontosComputador )
        {
            Console.WriteLine($"PARABÉNS, {jogador.Nome}! VOCÊ VENCEU COM {golsJogador1} GOLS.");
            Console.WriteLine($"{jogador.Nome}: {pontosJogador} pontos.");
            LimparTela();

        }
        else if (resposta == 2 && golsJogador2 > golsJogador1 && pontosComputador>pontosJogador || golsJogador2 > golsJogador1 && pontosComputador<pontosJogador ||golsJogador2 == golsJogador1 && pontosComputador>pontosJogador  )
        {
            Console.WriteLine($"{jogador2.Nome} VENCEU COM {golsJogador2} GOLS.");
            Console.WriteLine($"{jogador2.Nome}: {pontosComputador} pontos.");
            LimparTela();
        }

           else
        {
            Console.WriteLine("O JOGO TERMINOU EMPATADO!");
            Console.WriteLine("Escolha o que deseja fazer para desempatar:");
            Console.WriteLine("1. Disputa de pênaltis");
            Console.WriteLine("2. Gol de ouro");
            Console.WriteLine("3. Permanecer empatado");
       

            int opcaoDesempate = int.Parse(Console.ReadLine());

            switch (opcaoDesempate)
            {
                case 1:
                    DisputaPenaltis();
                    break;
                case 2:
                    GolDeOuro();
                    break;
            
                case 3:
                    Console.WriteLine("O jogo permanece empatado.");
                    break;

                default:
                    Console.WriteLine("Opção inválida. O jogo permanece empatado.");
                    break;
            }
        }



        }

        
        
        if (resposta == 1 &&  golsJogador1 > golsJogador2 && pontosJogador>pontosComputador || golsJogador1 > golsJogador2 && pontosJogador<pontosComputador || golsJogador1 == golsJogador2 && pontosJogador>pontosComputador )
        {
            Console.WriteLine($"PARABÉNS, {nomeJogador1}! VOCÊ VENCEU COM {golsJogador1} GOLS.");
            Console.WriteLine($"{nomeJogador1}: {pontosJogador} pontos.");
        }
        else if (resposta == 1 && golsJogador2 > golsJogador1 && pontosComputador>pontosJogador || golsJogador2 > golsJogador1 && pontosComputador<pontosJogador ||golsJogador2 == golsJogador1 && pontosComputador>pontosJogador  )
        {
            Console.WriteLine($"{nomeJogador2} VENCEU COM {golsJogador2} GOLS.");
            Console.WriteLine($"{nomeJogador2}: {pontosComputador} pontos.");
        }
        else
        {
            Console.WriteLine("O JOGO TERMINOU EMPATADO!");
            Console.WriteLine("Escolha o que deseja fazer para desempatar:");
            Console.WriteLine("1. Disputa de pênaltis");
            Console.WriteLine("2. Gol de ouro");
            Console.WriteLine("3. Permanecer empatado");
       

            int opcaoDesempate = int.Parse(Console.ReadLine());

            switch (opcaoDesempate)
            {
                case 1:
                    DisputaPenaltis();
                    break;
                case 2:
                    GolDeOuro();
                    break;
            
                case 3:
                    Console.WriteLine("O jogo permanece empatado.");
                    break;

                default:
                    Console.WriteLine("Opção inválida. O jogo permanece empatado.");
                    break;
            }
        }
    }




    
   



//DISPUTA DE PENALTIS
    private void DisputaPenaltis()
    {


        
        Console.WriteLine("Iniciando a disputa de pênaltis...");

        int pontosJogador1 = 0;
        int pontosJogador2 = 0;

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Pênalti {i + 1}: Escolha o canto (1 - Esquerda, 2 - Centro, 3 - Direita) - {jogador.Nome}");
            int escolhaJogador = int.Parse(Console.ReadLine());

            Random random = new Random();
            int escolhaComputador = random.Next(1, 4);

            Console.WriteLine($"O Computador escolheu o canto {escolhaComputador}");

            if (escolhaJogador == escolhaComputador)
            {
                Console.WriteLine($"{jogador.Nome} marcou o pênalti!");
                pontosJogador1++;
            }
            else
            {
                Console.WriteLine($"{jogador.Nome} errou o pênalti!");
            }
        }

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Pênalti {i + 1}: Escolha o canto (1 - Esquerda, 2 - Centro, 3 - Direita) - {jogador2.Nome}");
            int escolhaJogador2 = int.Parse(Console.ReadLine());

            Random random = new Random();
            int escolhaComputador = random.Next(1, 4);

            Console.WriteLine($"O Computador escolheu o canto {escolhaComputador}");

            if (escolhaJogador2 == escolhaComputador)
            {
                Console.WriteLine($"{jogador2.Nome} marcou o pênalti!");
                pontosJogador2++;
            }
            else
            {
                Console.WriteLine($"{jogador2.Nome} errou o pênalti!");
            }
        }

        Console.WriteLine("---------------- Resultado Pênaltis -----------------");
        Console.WriteLine($"{jogador.Nome}: {pontosJogador1} x {pontosJogador2} :{jogador2.Nome}");

        if (pontosJogador1 > pontosJogador2)
        {
            Console.WriteLine($"PARABÉNS, {jogador.Nome}! Você venceu na disputa de pênaltis.");
        }
        else if (pontosJogador2 > pontosJogador1)
        {
            Console.WriteLine($"PARABÉNS, {jogador2.Nome}! Você venceu na disputa de pênaltis.");
        }
    }


//G0L DE OURO
    private void GolDeOuro()
    {
        Console.WriteLine("Iniciando o Gol de Ouro...");

        int golsJogador1 = 0;
        int golsJogador2 = 0;

        while (true)
        {

            

            Console.WriteLine($"Jogada: jogador está perto de marca na área adversária (1 - Esquerda, 2 - Centro, 3 - Direita) - {jogador.Nome}");
            int escolhaJogador = int.Parse(Console.ReadLine());

            Random random = new Random();
            int escolhaComputador = random.Next(1, 4);

            Console.WriteLine($"O Computador escolheu o canto {escolhaComputador}");

            if (escolhaJogador == escolhaComputador)
            {
                Console.WriteLine($"{jogador.Nome} marcou o gol de ouro!");
                golsJogador1++;
                break;
            }
            else
            {
                Console.WriteLine($"{jogador.Nome} errou o gol de ouro!");
            }

            Console.WriteLine($"Jogada:  jogador está perto de marca na área adversária (1 - Esquerda, 2 - Centro, 3 - Direita) - {jogador2.Nome}");
            int escolhaJogador2 = int.Parse(Console.ReadLine());

            escolhaComputador = random.Next(1, 4);

            Console.WriteLine($"O Computador escolheu o canto {escolhaComputador}");

            if (escolhaJogador2 == escolhaComputador)
            {
                Console.WriteLine($"{jogador2.Nome} marcou o gol de ouro!");
                golsJogador2++;
                break;
            }
            else
            {
                Console.WriteLine($"{jogador2.Nome} errou o gol de ouro!");
            }
        }

        Console.WriteLine("---------------- Resultado Gol de Ouro -----------------");
        Console.WriteLine($"{jogador.Nome}: {golsJogador1} x {golsJogador2} :{jogador2.Nome}");

        if (golsJogador1 > golsJogador2)
        {
            Console.WriteLine($"PARABÉNS, {jogador.Nome}! Você venceu no gol de ouro.");
        }
        else if (golsJogador2 > golsJogador1)
        {
            Console.WriteLine($"PARABÉNS, {jogador2.Nome}! Você venceu no gol de ouro.");
        }
        else
        {
            Console.WriteLine("O gol de ouro também terminou empatado. Vamos para o próximo desempate.");
            DisputaPenaltis();
        }
    }




//PLACAR DE PONTOS
    private void ExibirPlacar(string nomeJogador1, string nomeJogador2, int pontosJogador1, int pontosJogador2)
    {
        Console.WriteLine($"Placar de pontos: {nomeJogador1} ({pontosJogador1}) - {nomeJogador2} ({pontosJogador2})");
    }

//PLACAR DE ENERGIA

    private void ExibirStatus(int energiaJogador1, string nomeJogador2, int energiaJogador2, int pontosJogador1, int pontosJogador2)
    {
        Console.WriteLine($"Energia de {jogador.Nome}: {energiaJogador1}");
        Console.WriteLine($"Energia de {nomeJogador2}: {energiaJogador2}");
        ExibirPlacar(jogador.Nome, nomeJogador2, pontosJogador1, pontosJogador2);
    }

//CONVERTER PONTOS EM GOLS

    private void AtualizarGols(ref int golsJogador, ref int golsComputador, int pontosJogador, int pontosComputador)
    {
        
      
        if (pontosJogador > pontosComputador)
        {
            golsJogador++;
        }
        else if (pontosComputador > pontosJogador)
        {
            golsComputador++;
        }
    }

//GERAR CARTAS ALEATÓRIAS PARA O JOGADOR QUE FOR ABRIR
    private int[] GerarCartasAleatorias(Random random)
    {
        int[] cartas = new int[3];
        for (int i = 0; i < cartas.Length; i++)
        {
            cartas[i] = random.Next(1, 7);
        }
        return cartas;
    }


//CALCULAR OS PONTOS CASO AS CARTAS FOREM IGUAIS

    private int CalcularPontos(int[] cartasJogador, string jogadorNome, ref int energia)
    {
        Console.WriteLine($"{jogadorNome}, pressione ENTER para abrir as cartas");
        Console.ReadLine();

        int cartasIguais = 0;

        for (int i = 0; i < cartasJogador.Length; i++)
        {
            Console.WriteLine($"Carta {i + 1}: {cartasJogador[i]}");


            if (cartasJogador[i] == 1){ 
                Console.WriteLine("GOl");
            }else if (cartasJogador[i] == 2){ 
                Console.WriteLine("Pênalti");
            }else if (cartasJogador[i] == 3){ 
                Console.WriteLine("Falta");
            }else if (cartasJogador[i] == 4){ 
                Console.WriteLine("Cartão amarelo");
            }else if (cartasJogador[i] == 5){ 
                Console.WriteLine("Cartão vermelho");
            }else if (cartasJogador[i] == 6){ 
                Console.WriteLine("Energia");
            }

            

            if (i > 0 && cartasJogador[i] == cartasJogador[i - 1])
            {
                cartasIguais++;
            }

            Console.ReadLine();
        }


        //CASO AS CARTAS FOREM IGUAIS

        if (cartasIguais == 2) // Se todas as cartas forem iguais
        {
            int valorCartaRepetida = cartasJogador[0]; 

            switch (valorCartaRepetida)
            {
                case 1:
                    Console.WriteLine("GOL - 3 pontos");
                    return 3;
                case 2:
                    Console.WriteLine("Pênalti - 2 pontos");

                     Console.WriteLine("PENALTI!!!! ESCOLHA O CANTO PARA BATER. (1-ESQUERDA 2-CENTRO 3-DIREITO) - " + jogadorNome);
                      int respPenalti = int.Parse(Console.ReadLine());

                 Random random = new Random();
                 int penalti = random.Next(1, 4);

                  if (respPenalti == penalti)
                    {
                     Console.WriteLine("GOL!!!! Você ganhou 3 pontos");
                 return 2;
                
                 }
                else
                {
                Console.WriteLine("ERROU!");
                return 0;
                }

                 
                case 3:
                    Console.WriteLine("Falta - 1 ponto");
                    return 1;
                case 4:
                    Console.WriteLine("Cartão Amarelo - 1 ponto");
                    return 1;
                case 5:
                    Console.WriteLine("Cartão Vermelho - 0 pontos");
                    return 0;
                case 6:
                    Console.WriteLine("Energia - 2 energias");
                    energia += 2;
                    return 2;
                default:
                    Console.WriteLine("Carta desconhecida");
                    return 0;
            }
        }
        else
        {
            Console.WriteLine("Cartas diferentes, nenhum ponto é repassado");
            return 0;
        }
    }
}

class Jogador
{
    public string Nome { get; set; }
}

class Computador
{
    public string Nome { get; set; } = "Computador";
    public int Energia { get; set; } = 10;
}
