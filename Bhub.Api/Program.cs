using Bhub.Api.Interfaces;
using Bhub.Services;

public class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddControllers();
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        builder.Services.AddScoped<IPagamento, PagamentoService>();
        builder.Services.AddScoped<IPagamentoProdutoFisico, PagamentoProdutoFisico>();
        builder.Services.AddScoped<IPagamentoLivro, PagamentoLivro>();
        builder.Services.AddScoped<IPagamentoAssociacao, PagamentoAssociacao>();
        builder.Services.AddScoped<IPagamentoVideoAprendendoEsquiar, PagamentoVideoAprendendoEsquiar>();

        var app = builder.Build();

        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseCors(x => x.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}