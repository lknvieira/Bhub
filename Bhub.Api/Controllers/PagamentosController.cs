using Bhub.Api.Interfaces;
using Bhub.Api.Models;
using Bhub.Api.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Bhub.Api.Controllers
{
    [Route("v1/[controller]")]
    [ApiController]
    public class PagamentosController : ControllerBase
    {
        private readonly IPagamento _pagamento;
        private readonly IPagamentoProdutoFisico _pagamentoProdutoFisico;
        private readonly IPagamentoLivro _pagamentoLivro;
        private readonly IPagamentoVideoAprendendoEsquiar _pagamentoVideo;
        private readonly IPagamentoAssociacao _pagamentoAssociacao;

        public PagamentosController(IPagamento pagamento, IPagamentoProdutoFisico pagamentoProdutoFisico,
            IPagamentoLivro pagamentoLivro, IPagamentoVideoAprendendoEsquiar pagamentoVideo, IPagamentoAssociacao pagamentoAssociacao)
        {
            _pagamento = pagamento ?? throw new ArgumentNullException(nameof(pagamento));
            _pagamentoProdutoFisico = pagamentoProdutoFisico ?? throw new ArgumentNullException(nameof(pagamentoProdutoFisico));
            _pagamentoLivro = pagamentoLivro ?? throw new ArgumentNullException(nameof(pagamentoLivro));
            _pagamentoVideo = pagamentoVideo ?? throw new ArgumentNullException(nameof(pagamentoVideo));
            _pagamentoAssociacao = pagamentoAssociacao ?? throw new ArgumentNullException(nameof(pagamentoVideo));
        }

        [HttpPost("simples")]
        [ProducesResponseType(typeof(PagamentoViewModel), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> Pagamento()
        {
            var result = new PagamentoViewModel
            {
                Pagamento = await _pagamento.GerarPagamento()
            };

            return Ok(result);
        }

        [HttpPost("ProdutoFisico")]
        [ProducesResponseType(typeof(PagamentoProdutoFisicoViewModel), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> PagamentoProdutoFisico()
        {
            var result = new PagamentoProdutoFisicoViewModel
            {
                Pagamento = await _pagamentoProdutoFisico.GerarPagamento(),
                GuiaRemessas = await _pagamentoProdutoFisico.GerarGuiaDeRemessa(),
                Comissao = await _pagamentoProdutoFisico.GerarComissão()
            };

            return Ok(result);
        }

        [HttpPost("Livro")]
        [ProducesResponseType(typeof(PagamentoProdutoFisicoViewModel), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> PagamentoLivro()
        {
            var result = new PagamentoProdutoFisicoViewModel
            {
                Pagamento = await _pagamentoLivro.GerarPagamento(),
                GuiaRemessas = await _pagamentoLivro.GerarGuiaDeRemessa(),
                Comissao = await _pagamentoLivro.GerarComissão()
            };

            return Ok(result);
        }

        [HttpPost("Video")]
        [ProducesResponseType(typeof(PagamentoViewModel), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> PagamentoVideo()
        {
            var result = new PagamentoVideoViewModel
            {
                Pagamento = await _pagamentoVideo.GerarPagamento(),
                GuiaRemessas = await _pagamentoVideo.GerarGuiaDeRemessa()
            };

            return Ok(result);
        }

        [HttpPost("AtivarAssociacao")]
        [ProducesResponseType(typeof(AssociacaoViewModel), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> AtivarAssociacao()
        {
            var associacao = await _pagamentoAssociacao.Ativa();

            var result = new AssociacaoViewModel
            {
                Pagamento = await _pagamentoVideo.GerarPagamento(),
                Associacao = associacao,
                Email = await _pagamentoAssociacao.EnviarEmail(associacao)
            };

            return Ok(result);
        }

        [HttpPost("UpgradeAssociacao")]
        [ProducesResponseType(typeof(AssociacaoViewModel), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> UpgradeAssociacao()
        {
            var associacao = await _pagamentoAssociacao.Upgrade();

            var result = new AssociacaoViewModel
            {
                Pagamento = await _pagamentoVideo.GerarPagamento(),
                Associacao = associacao,
                Email = await _pagamentoAssociacao.EnviarEmail(associacao)
            };

            return Ok(result);
        }
    }
}
