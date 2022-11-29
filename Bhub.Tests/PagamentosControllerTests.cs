using Bhub.Api.Models;
using Bhub.Api.ViewModels;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Newtonsoft.Json;
using System;
using System.Text;

namespace Bhub.Tests
{
    public class PagamentosControllerTests : IClassFixture<WebApplicationFactory<Program>>
    {
        private readonly WebApplicationFactory<Program> _factory;

        public PagamentosControllerTests(WebApplicationFactory<Program> factory)
        {
            _factory = factory;
        }

        [Fact]
        public async Task Pagamento_Should_Return_StatusCode_200()
        {
            // Arrange
            var client = _factory.CreateClient();

            // Act
            var response = await client.PostAsync("v1/pagamentos/simples", new StringContent("", Encoding.UTF8, "application/json"));

            // Assert
            response.EnsureSuccessStatusCode();
        }

        [Fact]
        public async Task PagamentoProdutoFisico_Should_Return_StatusCode_200()
        {
            // Arrange
            var client = _factory.CreateClient();

            // Act
            var response = await client.PostAsync("v1/pagamentos/ProdutoFisico", new StringContent("", Encoding.UTF8, "application/json"));

            // Assert
            response.EnsureSuccessStatusCode();
        }

        [Fact]
        public async Task PagamentoLivro_Should_Return_StatusCode_200()
        {
            // Arrange
            var client = _factory.CreateClient();

            // Act
            var response = await client.PostAsync("v1/pagamentos/Livro", new StringContent("", Encoding.UTF8, "application/json"));

            // Assert
            response.EnsureSuccessStatusCode();
        }

        [Fact]
        public async Task PagamentoVideo_Should_Return_StatusCode_200()
        {
            // Arrange
            var client = _factory.CreateClient();

            // Act
            var response = await client.PostAsync("v1/pagamentos/Video", new StringContent("", Encoding.UTF8, "application/json"));

            // Assert
            response.EnsureSuccessStatusCode();
        }

        [Fact]
        public async Task AssociacaoAtivar_Should_Return_StatusCode_200()
        {
            // Arrange
            var client = _factory.CreateClient();

            // Act
            var response = await client.PostAsync("v1/pagamentos/AtivarAssociacao", new StringContent("", Encoding.UTF8, "application/json"));

            // Assert
            response.EnsureSuccessStatusCode();
        }

        [Fact]
        public async Task UpgradeAssociacao_Should_Return_StatusCode_200()
        {
            // Arrange
            var client = _factory.CreateClient();

            // Act
            var response = await client.PostAsync("v1/pagamentos/UpgradeAssociacao", new StringContent("", Encoding.UTF8, "application/json"));

            // Assert
            response.EnsureSuccessStatusCode();
        }
    }
}