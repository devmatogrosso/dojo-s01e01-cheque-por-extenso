using System.Collections.Generic;
using System;

namespace csharpDojo
{
    public static class HumanizeMoney
    {
        private static readonly Dictionary<int, string> numeros = new Dictionary<int, string>()
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
            {200, "duzentos"},
            {300, "trezentos"},
            {400, "quatrocentos"},
            {500, "quinhentos"},
            {600, "seiscentos"},
            {700, "setecentos"},
            {800, "oitocentos"},
            {900, "novecentos"}
        };
        
        private static string HumanizeCore(int valor)
        {
            var extenso = new List<string>();
            string extensoMilhar = "";

            if (valor / 1000 > 0)
            {
                int valorMilhar = valor;
                valor %= 1000;
                extensoMilhar = HumanizeCore(valorMilhar / 1000) + (valor > 0 ? " mil, " : " mil");
            }

            if (valor / 100 > 0)
            {
                int valorCentena = valor;
                valor %= 100;
                
                if (valorCentena == 100)
                {
                    extenso.Add("cem");
                }
                else
                {
                    extenso.Add(numeros[valorCentena - valor]);                   
                }
                
            }
            
            if (valor > 20)
            {
                int valorDezena = valor;
                valor %= 10;
                extenso.Add(numeros[valorDezena - valor]);
            }

            if (valor > 0)
                extenso.Add(numeros[valor]);

            return extensoMilhar + string.Join(" e ", extenso.ToArray());
        }
        
        public static string Humanize(decimal valor)
        {
            int valorInteiro = (int) Math.Truncate(valor);
            int valorCentavos = (int) Math.Truncate((valor - valorInteiro) * 100);
            
            string moeda = "reais";
            if (valorInteiro <= 1)
            {
                moeda = "real";
            }
            
            string numeroString = "";
            if (valorInteiro > 0)
                numeroString += HumanizeCore(valorInteiro) + " " + moeda;
            if (valorCentavos > 0)
                numeroString += (numeroString != "" ? " e " : "") + HumanizeCore(valorCentavos) + " centavos";

            return numeroString;
        }
    }
}