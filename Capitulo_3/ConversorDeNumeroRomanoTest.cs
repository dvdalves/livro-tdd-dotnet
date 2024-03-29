﻿using NUnit.Framework;

namespace Capitulo_3
{
    [TestFixture]
    public class Testes
    {
        [Test]
        public void DeveEntenderOSimboloI()
        {
            ConversorDeNumeroRomano romano = new();
            int numero = romano.Converte("I");
            Assert.AreEqual(1, numero);
        }

        [Test]
        public void DeveEntenderOSimbolo()
        {
            ConversorDeNumeroRomano romano = new();
            int numero = romano.Converte("V");
            Assert.AreEqual(5, numero);
        }

        [Test]
        public void DeveEntenderDoisSimbolosComoII()
        {
            ConversorDeNumeroRomano romano = new();
            int numero = romano.Converte("II");
            Assert.AreEqual(2, numero);
        }

        [Test]
        public void DeveEntenderQuatroSimbolosDoisADoisComoXXII()
        {
            ConversorDeNumeroRomano romano = new();
            int numero = romano.Converte("XXII");
            Assert.AreEqual(22, numero);
        }

        [Test]
        public void DeveEntenderNumerosComoIX()
        {
            ConversorDeNumeroRomano romano = new();
            int numero = romano.Converte("IX");
            Assert.AreEqual(9, numero);
        }

        [Test]
        public void DeveEntenderNumerosComplexosComoXXIV()
        {
            ConversorDeNumeroRomano romano = new();
            int numero = romano.Converte("XXIV");
            Assert.AreEqual(24, numero);
        }
    }
}
