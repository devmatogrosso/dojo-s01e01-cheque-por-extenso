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
        public HumanizeMoneyTest()
        {
        }


        [Fact]
        public void TestCom1()
        {
            var humanizeMoney = new HumanizeMoney(1);
            Assert.Equal("um real", humanizeMoney.Humanize());

        }

        [Fact]
        public void TestCom10()
        {
            var humanizeMoney = new HumanizeMoney(10);
            Assert.Equal("dez reais", humanizeMoney.Humanize()); 
             
        }

        [Fact]
        public void TestCom21()
        {
            var humanizeMoney = new HumanizeMoney(21);
            Assert.Equal("vinte e um reais", humanizeMoney.Humanize());

        }

        [Fact]
        public void testcom100()
        {
            var humanizemoney = new HumanizeMoney(100);
            Assert.Equal("cem reais", humanizemoney.Humanize());

        }

        [Fact]
        public void testcom101()
        {
            var humanizemoney = new HumanizeMoney(101);
            Assert.Equal(humanizemoney.Humanize(), "cento e um reais");

        }

    }
}
