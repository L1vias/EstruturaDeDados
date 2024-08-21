using System.ComponentModel.Design;

internal class Program
{
    private static void Main(string[] args)
    {

        //TRABALHANDO COM LISTA (LIST)//
        /* Criando uma lista */
        List<string> frutas = new List<string>();

        /*Adicionar itens na lista*/
        frutas.Add("Morango");
        frutas.Add("Manga");
        frutas.Add("Goiaba");
        frutas.Add("Uva");

        /* Imprimir os Itens da Lista */
        Console.WriteLine("Minha Lista de Frutas");

        frutas.ForEach(Console.WriteLine);

        Console.WriteLine(); //Pula linha em branco //

        /*Imprimir elemento na posição especifica */
        Console.WriteLine("Fruta na indice 2:" + frutas[2]);

        //inserir um elemnto no indice especifico//
        frutas.Insert(1, "Maracuja");

        Console.WriteLine();
        //Imprimindo a lista novamente//
        Console.WriteLine("Minha Lista de Frutas");
        frutas.ForEach(Console.WriteLine);
        Console.WriteLine();

        //Alterar um elemento no indice especifico//
        frutas[4] = "Pera";
        Console.WriteLine("Minha lista de frutas : ");
        frutas.ForEach(Console.WriteLine);

        Console.WriteLine();

        //Remover elementos ds lista no indice especifico//
        frutas.RemoveAt(3);


        //Remover elementos pelo valor do conteúdo //
        frutas.Remove("Morango");

        //Imprimindo a lista novamente //
        Console.WriteLine(); //pula linha em branco//
        Console.WriteLine("Minha Lista de Frutas");
        frutas.ForEach(Console.WriteLine);

        //Apagar todos os elementos da lista //
        frutas.Clear();

        //TRABALHANDO COM DICIONARIO ( DICTIONARY)//

        //criando um dicionario de dados //
        Dictionary<int, string> carros = new Dictionary<int, string>();
        //adicionar dados a um dicionario //
        carros.Add(5, "Gol");
        carros.Add(10, "SW4");
        carros.Add(2, "Nivus");

        Console.WriteLine(); //pula linha  em branco //
        Console.WriteLine("===========================================================================================================");
        Console.WriteLine();
        Console.WriteLine("Meu dicionario de carros : ");

        // Imprimindo um dicionario de dados //
        foreach (var carro in carros)
        {
            Console.WriteLine($"{carro.Key} - {carro.Value}");
        }

        //TRABALHANDO COM FILA//
        //Criar um Fila (Queen)//
        Queue<string> FilaBanco = new Queue<string>();

        //Adicionar elementos em  uma fila//
        FilaBanco.Enqueue("André");
        FilaBanco.Enqueue("João");
        FilaBanco.Enqueue("Maria");
        FilaBanco.Enqueue("Bia");

        foreach (var pessoa in FilaBanco)
        {
            Console.WriteLine(pessoa);
        }

        //retirar o primeiro elemento de uma fila
        FilaBanco.Dequeue();

        Console.WriteLine(); //pula linha em branco
        Console.WriteLine("===================");
        Console.WriteLine(); //pula linha em branco
        foreach (var pessoa in FilaBanco)
        {
            Console.WriteLine(pessoa);
        }

        //verificar se existe um elemento na fila
        bool achou = FilaBanco.Contains("Manoel");

        if (achou == true)
        {
            Console.WriteLine("A Pessoa está na fila ");
        }
        else
        {
            Console.WriteLine("A pessoa NÃO está na fila!");
        }

        Console.WriteLine(); //pula linha em branco
        Console.WriteLine("===================");
        Console.WriteLine(); //pula linha em branco

        //TRABALHANDO COM PILHA (STACK)
        //Criando uma Pilha
        Stack<string> livros = new Stack<string>();

        //Adicionar elementos em uma pilha//
        livros.Push("Chapéuzinho vermelho");
        livros.Push("Branca de neve e os sete Anões");
        livros.Push("A Princesa e o Sapo");

        foreach (var livro in livros)
        {
            Console.WriteLine(livro);
        }

        Console.WriteLine(); //pula linha em branco
        Console.WriteLine("===================");
        Console.WriteLine(); //pula linha em branco

        //Remove o primeiro Elemento da pilha
        livros.Pop();
        foreach (var livro in livros)
        {
            Console.WriteLine(livro);
        }

        Console.WriteLine(); //pula linha em branco
        Console.WriteLine("===================");
        Console.WriteLine(); //pula linha em branco

    }
}