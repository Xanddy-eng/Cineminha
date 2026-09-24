using CinemaDomain;
using System.Diagnostics;
using System.Text.Json;
using static System.Net.WebRequestMethods;

namespace CinemaTeste
{
    [TestClass]
    public sealed class TestCinemaDomain
    {
        private JsonSerializerOptions OptionsJson()
        {
            return new JsonSerializerOptions { WriteIndented = true };
        }
        [TestMethod]
        public void TestGenero()
        {
            var genero = new Genero() { Id = 1, Nome = "Acao" };

            var generoJson = JsonSerializer.Serialize(genero, OptionsJson());
            Debug.WriteLine(generoJson);
            Assert.IsNotNull(generoJson);

        }
        [TestMethod]
        public void TestSessao()
        {
            var sala1 = new Sala() { Id = 1, Assentos = 10, Capacidade = 10 , Fileiras = "A", Numero = 5};
            var genero3 = new Genero() { Id = 3, Nome = "Ficcao Cientifica" };
            var filme1 = new Filme() { Id = 1, Nome = "Jurassic Park", Genero = genero3, Classificacao = "14", Duracao = 120 };
            var sessao = new Sessao() { Id = 1, Preco = 10.20M, Data = new DateTime (2026, 09, 24, 19, 30, 00), Filme = filme1, Sala = sala1 };

            var sessaoJson = JsonSerializer.Serialize(sessao, OptionsJson());
            Debug.WriteLine(sessaoJson);
            Assert.IsNotNull(sessaoJson);

        }
        [TestMethod]
        public void TestFilme()
        {
            var genero1 = new Genero() { Id = 1, Nome = "Acao" };
            var genero2 = new Genero() { Id = 2, Nome = "Comedia" };
            var genero3 = new Genero() { Id = 3, Nome = "Ficcao Cientifica" };
            var filme = new Filme() { Id = 1, Nome = "Jurassic Park", Genero = genero3, Classificacao = "14", Duracao = 120 };

            var filmeJson = JsonSerializer.Serialize(filme, OptionsJson());
            Debug.WriteLine(filmeJson);
            Assert.IsNotNull(filmeJson);

        }
        [TestMethod]
        public void TestSala()
        {
            var sala = new Sala() { Id = 1, Assentos = 10, Capacidade = 10, Fileiras = "A", Numero = 5 };

            var salaJson = JsonSerializer.Serialize(sala, OptionsJson());
            Debug.WriteLine(salaJson);
            Assert.IsNotNull(salaJson);

        }
        [TestMethod]
        public void TesteIngresso()
        {
            var ingressoItem = new IngressoItem() { Id = 1, Assento = 10, Fileira = "A", MeiaEntreda = false };
            var genero3 = new Genero() { Id = 3, Nome = "Ficcao Cientifica" };
            var filme = new Filme() { Id = 1, Nome = "Jurassic Park", Genero = genero3, Classificacao = "14", Duracao = 120 };
            var sala = new Sala() { Id = 1, Assentos = 10, Capacidade = 10, Fileiras = "A", Numero = 5 };
            var sessao = new Sessao() { Id = 1, Preco = 10.20M, Data = new DateTime(2026, 09, 24, 19, 30, 00), Filme = filme, Sala = sala };
            var ingresso = new Ingresso() { Id = 1, DataCompra = new DateTime(2026, 09, 24, 20, 00, 00), Documento = "123.123.123-12", FormaPagamento = "Debito", Sessao = sessao, ValorTotal = 20.00M };


            var ingressoJson = JsonSerializer.Serialize(ingresso, OptionsJson());
            Debug.WriteLine(ingressoJson);
            Assert.IsNotNull(ingressoJson);
        }

    }
}
