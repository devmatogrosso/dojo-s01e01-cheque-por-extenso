using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

/*

Apesar de o volume de cheques emitidos tenha diminuído drásticamente nos últimos anos,
principalmente devido a popularização dos cartões de crédito e débito, eles ainda são
utilizados em muitas compras, especialmente a de valores altos. E para auxiliar no seu
preenchimento, vários estabelecimentos possuem máquinas que dado o valor da compra,
preenchem o cheque com o seu valor por extenso.
Desenvolva um programa que dado um valor monetário, seja retornado o valor em reais
por extenso.
Exemplo:
15415,16 -> quinze mil quatrocentos e quinze reais e dezesseis centavos
0,05 -> cinco centavos
2,25 -> dois reais e vinte e cinco centavos

*/

namespace csharpDojo
{
    public class HumanizeMoneyTest
    {
        [Theory]
        [InlineData(1, "um real")]
        [InlineData(10, "dez reais")]
        [InlineData(17, "dezessete reais")]
        [InlineData(25, "vinte e cinco reais")]
        [InlineData(100, "cem reais")]
        [InlineData(182, "cento e oitenta e dois reais")]
        [InlineData(587, "quinhentos e oitenta e sete reais")]
        [InlineData(3000, "três mil reais")]
        [InlineData(3250, "três mil, duzentos e cinquenta reais")]
        public void TesteSemCentavos(decimal valor, string expected)
        {
            Assert.Equal(expected, HumanizeMoney.Humanize(valor));
        }
        
        [Theory]
        [InlineData(0.33, "trinta e três centavos")]
        [InlineData(1.50, "um real e cinquenta centavos")]
        [InlineData(10.32, "dez reais e trinta e dois centavos")]
        [InlineData(182.28, "cento e oitenta e dois reais e vinte e oito centavos")]
        [InlineData(3000.21, "três mil reais e vinte e um centavos")]
        [InlineData(3250.36, "três mil, duzentos e cinquenta reais e trinta e seis centavos")]
        public void TesteComCentavos(decimal valor, string expected)
        {
            Assert.Equal(expected, HumanizeMoney.Humanize(valor));
        }
    }
}
