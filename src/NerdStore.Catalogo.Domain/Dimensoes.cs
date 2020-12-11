﻿using NerdStore.Core.DomainObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace NerdStore.Catalogo.Domain
{
    public class Dimensoes : IValueObjetct
    {
        public decimal Altura { get; private set; }
        public decimal Largura { get; private set; }
        public decimal Profundidade { get; private set; }

        public Dimensoes( decimal altura, decimal largura, decimal profundidade)
        {

            Altura = altura;
            Largura = largura;
            Profundidade = profundidade;

            Validar();
        }

        public void Validar()
        {
            Validacoes.ValidarSeMenorIgualMinimo(Altura, 1,  "O campo Altura não pode ser menor ou igual a zero");
            Validacoes.ValidarSeMenorIgualMinimo(Largura, 1, "O campo Largura não pode ser menor ou igual a zero");
            Validacoes.ValidarSeMenorIgualMinimo(Profundidade, 1, "O campo Profundidade não pode ser menor ou igual a zero");
        }

        public string DescricaoFormatada()
        {
            return $"LxAxP: {Largura} x {Altura} x {Profundidade}";
        }

        public override string ToString()
        {
            return DescricaoFormatada();
        }
    }
}
