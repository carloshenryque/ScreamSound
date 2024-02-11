using OpenAI_API;

internal class MenuRegistrarBanda : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibirLogo();
        ExibirTituloDaOpcao("Registro das bandas");
        Console.Write("Digite o nome da banda que deseja registrar: ");
        string nomeDaBanda = Console.ReadLine()!;
        Banda banda = new Banda(nomeDaBanda);
        bandasRegistradas.Add(nomeDaBanda, banda);


        //var client = new OpenAIAPI("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");

       // var chat = client.Chat.CreateConversation();

        //chat.AppendSystemMessage($"resuma {nomeDaBanda} em um parágrafo, adote um estilo informal");

        //string resposta = chat.GetResponseFromChatbotAsync().GetAwaiter().GetResult();
       // banda.Resumo = resposta;


        Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
        Console.WriteLine("\nDigite uma tecla para votar ao menu principal");
        Console.ReadKey();
        Console.Clear();

    }
}


