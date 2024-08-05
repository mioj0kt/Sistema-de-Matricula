using System;
using System.Collections.Generic;

public class Aluno
{
    public string nome;
    public int matricula;
}

class Program
{

    public static void Menu()//função para gerar o menu principal no console
    {
        Console.WriteLine("Selecione uma opção:");
        Console.WriteLine("1. Cadastrar novo aluno");
        Console.WriteLine("2. Pesquisar aluno");
        Console.WriteLine("3. Mostrar todos alunos cadastrados");
        Console.WriteLine("4. Encerrar programa");
    }


    public static void Main(string[] args)
    {
        Menu();
        List<Aluno> alunos = new List<Aluno>(); 
      /*
      por meio de using System.Collections.Generic; é possivel 
      criar um "array" que aloca uma coleção dinâmica que cresce
      ou diminui de acordo com o necessario, por meio da "list"
      */
        int opt = Convert.ToInt32(Console.ReadLine()); //converter para inteiro o valor lido
        while (opt != 4)
        {
          switch (opt)
            {
            case 1: 
              Aluno temp = new Aluno();//classe temporária para ser adicionada ao valor final da list
              Console.WriteLine("Insira o nome do aluno:");
              temp.nome = Console.ReadLine();
              Console.WriteLine("Insira a matrícula do aluno:");
              temp.matricula = Convert.ToInt32(Console.ReadLine());//converter para inteiro o valor lido
              alunos.Add(temp);// adicionando a classe temporária para a lista final
              break;
            case 2:
              Console.WriteLine("Insira o número de matrícula do aluno:");
              int busca = Convert.ToInt32(Console.ReadLine());//var feita para armazenar a busca do usuario
              Aluno alunoEncontrado = alunos.Find(a => a.matricula == busca);//função find que utiliza var "busca"
              if (alunoEncontrado == null){//caso não exista
                Console.WriteLine("Aluno não encontrado!");
              }else{//caso exista
                Console.WriteLine("Aluno encontrado!");
                Console.WriteLine(alunoEncontrado.nome + " - " + alunoEncontrado.matricula);
              }
              break;
            case 3:
              Console.WriteLine("Lista de todos os alunos cadastrados:");
              foreach(var aluno in alunos){//foreach para imprimir todos os alunos dentro da classe "alunos"
                Console.WriteLine(aluno.nome + " - " + aluno.matricula);
              }
              break;
            }
          Console.WriteLine("Pressione qualquer botão para continuar...");
          Console.ReadKey();//deixar pausado a tela do console até que pressione uma tecla
          Console.Clear();//limpar a tela
          Menu();//imprimir o menu novamente
          opt = Convert.ToInt32(Console.ReadLine());//trocar de opção
        }
    }
}
//FIM DO ALGORITMO