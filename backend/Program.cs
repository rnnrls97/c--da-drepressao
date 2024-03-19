var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

List<Produto> produtos = new List<Produto>{
    new Produto("Café", "Quero cafééé"),
    new Produto("Iphone 15 Pro Max", "Chega quando o André voltar")
};

app.MapGet("/", () => "Hello World!");

app.MapGet("/api/produto", () => produtos);

app.MapPost("/api/produto", () => produtos.Add(new Produto("RTX 4090", "MSI")));

app.Run();

public record Produto(string Name, string Description);
