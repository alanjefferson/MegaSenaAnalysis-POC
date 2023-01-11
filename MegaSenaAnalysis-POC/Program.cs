using HtmlAgilityPack;

HttpClient client = new HttpClient();

var response = await client.GetAsync("https://loterias.caixa.gov.br/Paginas/Download-Resultados.aspx");
var pageContents = await response.Content.ReadAsStringAsync();

HtmlDocument pageDocument = new HtmlDocument();
pageDocument.LoadHtml(pageContents);

var headlineText = pageDocument.DocumentNode.SelectSingleNode("(//div[contains(@class,'todosResultados')]//h3)[1]").InnerText;
Console.WriteLine(headlineText);
Console.ReadLine();