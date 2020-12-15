using NerdStore.Core.DomainObjects;
using System;
using Xunit;

namespace NerdStore.Catalogo.Domain.Tests
{
    public class ProdutoTests
    {
        [Fact]
        public void Produto_Validar_ValidacoesDevemRetornarExceptions()
        {
            // Arrange & Act & Assert
            var ex = Assert.Throws<DomainException>(() =>
           {
               new Produto(string.Empty, "Descri��o", false, 100, Guid.NewGuid(), DateTime.Now, "Imagem", new Dimensoes(2, 2, 2));
           });

            Assert.Equal("O campo Nome do produto n�o pode estar vazio", ex.Message);


            ex = Assert.Throws<DomainException>(() =>
            {
                new Produto("Nome", string.Empty, false, 100, Guid.NewGuid(), DateTime.Now, "Imagem", new Dimensoes(2, 2, 2));
            });

            Assert.Equal("O campo Descri��o do produto n�o pode estar vazio", ex.Message);


            ex = Assert.Throws<DomainException>(() =>
            {
                new Produto("Nome", "Descri��o", false, 0, Guid.NewGuid(), DateTime.Now, "Imagem",  new Dimensoes(2, 2, 2));
            });


            Assert.Equal("O campo Valor do produto n�o pode ser menor ou igual a zero", ex.Message);


            ex = Assert.Throws<DomainException>(() =>
            {
                new Produto("Nome", "Descri��o", false, 100, Guid.Empty, DateTime.Now, "Imagem", new Dimensoes(2, 2, 2));
            });


            Assert.Equal("O campo categoriaId do produto n�o pode estar vazio", ex.Message);

            ex = Assert.Throws<DomainException>(() =>
            {
                new Produto("Nome", "Descri��o", false, 100, Guid.NewGuid(), DateTime.Now, "", new Dimensoes(2, 2, 2));
            });


            Assert.Equal("O campo Imagem do produto n�o pode estar vazio", ex.Message);


            ex = Assert.Throws<DomainException>(() =>
            {
                new Produto("Nome", "Descri��o", false, 100, Guid.NewGuid(), DateTime.Now, "Imagem",  new Dimensoes(0, 1, 1));
            });


            Assert.Equal("O campo Altura n�o pode ser menor ou igual a zero", ex.Message);
        }
    }
}
