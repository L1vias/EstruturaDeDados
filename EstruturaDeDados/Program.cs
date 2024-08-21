internal class Program
{
    private static void Main(string[] args)
    {

        //TRABALHANDO COM LISTA (LIST)
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

        Console.WriteLine(); //Pula linha em branco 

        /*Imprimir elemento na posição especifica */
        Console.WriteLine("Fruta na indice 2:" + frutas[2]);

        //inserir um elemnto no indice especifico
        frutas.Insert(1, "Maracuja");

        Console.WriteLine();
        //Imprimindo a lista novamente
        Console.WriteLine("Minha Lista de Frutas");
        frutas.ForEach(Console.WriteLine);
        Console.WriteLine();

        //Alterar um elemento no indice especifico
        frutas[4] = "Pera";
        Console.WriteLine("Minha lista de frutas : ");
        frutas.ForEach(Console.WriteLine);

        Console.WriteLine();

        //Remover elementos ds lista no indice especifico
        frutas.RemoveAt(3);


        //Remover elementos pelo valor do conteúdo 
        frutas.Remove("Morango");

        //Imprimindo a lista novamente 
        Console.WriteLine(); //pula linha em branco
        Console.WriteLine("Minha Lista de Frutas");
        frutas.ForEach(Console.WriteLine);

        //Apagar todos os elementos da lista 
        frutas.Clear();


    }
}