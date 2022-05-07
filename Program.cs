static void ReadEnvFile(string fileName) {
    try {
        StreamReader reader = new StreamReader(fileName);
        string line;
        while ((line = reader.ReadLine()) != null) {
            string[] parts = line.Split('=');
            if (parts.Length == 2) {
                Environment.SetEnvironmentVariable(parts[0], parts[1]);
            }
        }
        reader.Close();
    } catch (Exception e) {
        System.Console.WriteLine("The file could not be read:");
        System.Console.WriteLine(e.Message);
    }
}


ReadEnvFile(".env");
// var table = new Table()
//         .Centered()
//         .HeavyBorder()
//         .BorderColor(Color.Blue);

    // await AnsiConsole.Live(table).StartAsync(async ctx => {
    //     var client = new HttpClient();
    //     // access microsoft cognitive services speech api
    //     var result = await client.GetStringAsync("https://westus.api.cognitive.microsoft.com/sts/v1.0/issueToken");
    //     var token = result.Trim();

    //     try {
    //         var response = await client.GetAsync("");
    //         var content = response.Content.ReadAsStringAsync().Result;

    //         table.AddColumn(new TableColumn("[magenta on green]Title[/]").Centered())
    //              .AddRow($"{content}");
    //     } catch (HttpRequestException e) {
    //         AnsiConsole.Markup($"[red bold]Error ✗: {e}[/]");
    //     }

    //     ctx.Refresh();
    //     await Task.Delay(1000);
    // }
    //             );
