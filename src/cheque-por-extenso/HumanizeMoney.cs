using System.Collections.Generic;

namespace csharpDojo
{
    public class HumanizeMoney
    {
        
        public decimal valor;
        private Dictionary<int, string> numeros = new Dictionary<int, string>
        {
            {1, "um"},
            {2, "dois"},
            {3, "três"},
            {4, "quatro"},
            {5, "cinco"},
            {6, "seis"},
            {7, "sete"},
            {8, "oito"},
            {9, "nove"},
            {10, "dez"},
            {11, "onze"},
            {12, "doze"},
            {13, "treze"},
            {14, "quatorze"},
            {15, "quinze"},
            {16, "dezesseis"},
            {17, "dezessete"},
            {18, "dezoito"},
            {19, "dezenove"},
            {20, "vinte"},
            {30, "trinta"},
            {40, "quarenta"},
            {50, "cinquenta"},
            {60, "sessenta"},
            {70, "setenta"},
            {80, "oitenta"},
            {90, "noventa"},
            {100, "cento"},
            {200, "duzento"},
            {300, "cinco"},
            {400, "cinco"},
            {500, "cinco"},
            {1000, "cinco"}
        };
        
        public HumanizeMoney(decimal valor)
        {
            this.valor = valor;
        }
        
        public string Humanize()
        {
            var inteiro = (int)this.valor;

            if (inteiro < 1)
            {
                return "zero";
            }

            var moeda = "reais";

            if (valor <= 1)
            {
                moeda = "real";
            }


            var numeroString = "";
            
            // Nao o valor no dic
            var qtdeCasas = inteiro.ToString().Length;

            //if (inteiro >= 1000)
            //{
            //    int valorMilhar = inteiro / 1000;
            //}
                
            var milhar = inteiro % 1000;
            var dezena = (inteiro % 100);
            var unidade = inteiro % 10;

            if (milhar > 0)
            {
                if (inteiro == 100)
                {
                    numeroString = "cem";
                }
                else
                { 
                    numeroString += numeros[milhar];
                }
            }

            if (dezena > 0)
            {
                if (dezena <= 20)
                {
                    numeroString += numeros[dezena];
                }
                else
                {
                    var restoDaDezena = dezena % 10;
                 
                    numeroString += numeros[restoDaDezena];
                }
            }
            //else if(unidade > 0)
            //{
            //    numeroString += numeros[unidade];
            //}

            string retorno = numeroString + " " + moeda;
            return retorno;
            
        }
        public string parseNumber(int number)
        {
            return null;
        }
        
    }
}