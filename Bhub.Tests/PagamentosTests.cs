using Bhub.Api.Models;
using Bhub.Services;
using FluentAssertions;

namespace Bhub.Tests
{
    public class PagamentosTests
    {
        [Fact]
        public async Task GerarPagamento_Should_Return_Correct_Value()
        {
            var pagamentoService = new PagamentoService();

            var pagamento = await pagamentoService.GerarPagamento();

            pagamento.Data.Date.Should().Be(DateTime.Now.Date);
            pagamento.Valor.Should().Be(10);
        }

        [Fact]
        public async Task GerarPagamentoProdutoFisico_Should_Return_Correct_Value()
        {
            var pagamentoService = new PagamentoProdutoFisico();

            var pagamento = await pagamentoService.GerarPagamento();
            pagamento.Data.Date.Should().Be(DateTime.Now.Date);
            pagamento.Valor.Should().Be(10);

            var guiaRemessa = await pagamentoService.GerarGuiaDeRemessa();
            guiaRemessa.Count.Should().Be(1);
            guiaRemessa[0].Descricao.Should().Be("Gerando uma guia de remessa");
            guiaRemessa[0].Produto.Count.Should().Be(1);
            guiaRemessa[0].Produto[0].Nome.Should().Be("Produto Físico");

            var comissao = await pagamentoService.GerarComissão();
            comissao.Descricao.Should().Be("Gerando pagamento de comissão ao agente");
        }

        [Fact]
        public async Task GerarPagamentoLivro_Should_Return_Correct_Value()
        {
            var pagamentoService = new PagamentoLivro();

            var pagamento = await pagamentoService.GerarPagamento();
            pagamento.Data.Date.Should().Be(DateTime.Now.Date);
            pagamento.Valor.Should().Be(10);

            var guiaRemessa = await pagamentoService.GerarGuiaDeRemessa();

            guiaRemessa.Count.Should().Be(2);
            guiaRemessa[0].Descricao.Should().Be("Gerando uma guia de remessa duplicada");
            guiaRemessa[1].Descricao.Should().Be("Gerando uma guia de remessa duplicada");
            guiaRemessa[0].Produto.Count.Should().Be(1);
            guiaRemessa[0].Produto[0].Nome.Should().Be("Livro");

            var comissao = await pagamentoService.GerarComissão();
            comissao.Descricao.Should().Be("Gerando pagamento de comissão ao agente");
        }


        [Fact]
        public async Task GerarPagamentoVideo_Should_Return_Correct_Value()
        {
            var pagamentoService = new PagamentoVideoAprendendoEsquiar();

            var pagamento = await pagamentoService.GerarPagamento();
            pagamento.Data.Date.Should().Be(DateTime.Now.Date);
            pagamento.Valor.Should().Be(10);

            var guiaRemessa = await pagamentoService.GerarGuiaDeRemessa();

            guiaRemessa.Count.Should().Be(1);
            guiaRemessa[0].Descricao.Should().Be("Gerando uma guia de remessa");
            guiaRemessa[0].Produto.Count.Should().Be(2);
            guiaRemessa[0].Produto[0].Nome.Should().Be("Video Aprendendo Esquiar");
            guiaRemessa[0].Produto[1].Nome.Should().Be("Vídeo gratuíto de Primeiros Socorros");

            var comissao = await pagamentoService.GerarComissão();
            comissao.Descricao.Should().Be("Gerando pagamento de comissão ao agente");
        }

        [Fact]
        public async Task GerarPagamentoAssociacaoAtivar_Should_Return_Correct_Value()
        {
            var pagamentoAssociacao = new PagamentoAssociacao();

            var pagamento = await pagamentoAssociacao.GerarPagamento();
            pagamento.Data.Date.Should().Be(DateTime.Now.Date);
            pagamento.Valor.Should().Be(10);

            var associacao = await pagamentoAssociacao.Ativa();
            associacao.Descricao.Should().Be("Nova Associação - Level 1");
            
            var email = await pagamentoAssociacao.EnviarEmail(associacao);
            email.To.Should().Be("cliente@cliente.com");
            email.From.Should().Be("bhub@bhub.com");
            email.Subject.Should().Be(associacao.Descricao);
        }

        [Fact]
        public async Task GerarPagamentoAssociacaoUpgrade_Should_Return_Correct_Value()
        {
            var pagamentoAssociacao = new PagamentoAssociacao();

            var pagamento = await pagamentoAssociacao.GerarPagamento();
            pagamento.Data.Date.Should().Be(DateTime.Now.Date);
            pagamento.Valor.Should().Be(10);

            var associacao = await pagamentoAssociacao.Upgrade();
            associacao.Descricao.Should().Be("Upgrade Associação - Level 2");

            var email = await pagamentoAssociacao.EnviarEmail(associacao);
            email.To.Should().Be("cliente@cliente.com");
            email.From.Should().Be("bhub@bhub.com");
            email.Subject.Should().Be(associacao.Descricao);
        }
    }
}
