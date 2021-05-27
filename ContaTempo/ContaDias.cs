using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ContaTempo
{

    public class ContaDias
    {

        public int DiasPassados(DateTime dataInformada)
        {
            TimeSpan diasEmAberto = DateTime.Now - dataInformada;
            return diasEmAberto.Days;
        }
        public int SemanasPassados(DateTime dataInformada)
        {
            TimeSpan diasEmAberto = DateTime.Now - dataInformada;
            int semana = diasEmAberto.Days % 7;

            return semana;
        }

        public int AnosPassados(DateTime dataInformada)
        {
            TimeSpan diasEmAberto = DateTime.Now - dataInformada;
            int anos = diasEmAberto.Days / 365;
            return anos;
        }
        public int RestoDeAnosPassados(DateTime dataInformada)
        {
            TimeSpan diasEmAberto = DateTime.Now - dataInformada;
            int restoDeAnos = diasEmAberto.Days % 365;
            return restoDeAnos;
        }

        public int MesesPassados(DateTime dataInformada)
        {
            //TimeSpan diasEmAberto = DateTime.Now - dataInformada;
            int mesAtual = DateTime.Now.Month;
            int mesAnterior = dataInformada.Month;
            int numeroDeMeses = 0;
            if(mesAtual-mesAnterior<0)
            {
                mesAtual += 12;
                numeroDeMeses = mesAtual - mesAnterior;
            }
            
            return numeroDeMeses;
        }
        public int RestoDeMeses(int restoDeAno)
        {
            int meses = restoDeAno / 30;
            return meses;
        }
        public string EscreveE()
        {
            return "e";
        }
        public string NumerosPorEscrito(int numero)
        {
            string numeroEscrito = "";
            if (numero == 1)
                numeroEscrito = " Um ";
            else if (numero == 2)
                numeroEscrito = " Dois ";
            else if (numero == 3)
                numeroEscrito = " Três ";
            else if (numero == 4)
                numeroEscrito = " Quatro ";
            else if (numero == 5)
                numeroEscrito = " cinco ";
            else if (numero == 6)
                numeroEscrito = " seis ";
            else if (numero == 7)
                numeroEscrito = " sete ";
            else if (numero == 8)
                numeroEscrito = " oito ";
            else if (numero == 9)
                numeroEscrito = " nove ";
            else if (numero == 10)
                numeroEscrito = " Dez ";
            else if (numero == 11)
                numeroEscrito = " Onze ";
            else if (numero == 12)
                numeroEscrito = " Doze ";
            else if (numero == 13)
                numeroEscrito = " Treze ";
            else if (numero == 14)
                numeroEscrito = " Quatorze ";
            else if (numero == 15)
                numeroEscrito = " Quinze ";
            else if (numero == 16)
                numeroEscrito = " Desesseis ";
            else if (numero == 17)
                numeroEscrito = " Desessete ";
            else if (numero == 18)
                numeroEscrito = " Dezoito ";
            else if (numero == 19)
                numeroEscrito = " Dezenove ";
            else if (numero == 20)
                numeroEscrito = " vinte ";
            else if (numero == 21)
                numeroEscrito = "vinte e um";
            else if (numero == 22)
                numeroEscrito = "vinte e dois";
            else if (numero == 23)
                numeroEscrito = "vinte e três";
            else if (numero == 24)
                numeroEscrito = "vinte e quatro";
            else if (numero == 25)
                numeroEscrito = "vinte e cinco";
            else if (numero == 26)
                numeroEscrito = "vinte e seis";
            else if (numero == 27)
                numeroEscrito = "vinte e sete";
            else if (numero == 28)
                numeroEscrito = "vinte e oito";
            else if (numero == 29)
                numeroEscrito = "vinte e nove";
            else if (numero == 30)
                numeroEscrito = "trinta";
            else if (numero == 31)
                numeroEscrito = "trinta e um";

            return numeroEscrito;
        }
        public string escreveData(DateTime dataInformada)
        {
            string dataEscrita = "";
            int quantidadeAnos = AnosPassados(dataInformada);
            int restoDeAnos = RestoDeAnosPassados(dataInformada);
            if (quantidadeAnos > 0)
            {
                if(quantidadeAnos == 1)
                    dataEscrita = NumerosPorEscrito(quantidadeAnos) + " ano ";
                else
                    dataEscrita = NumerosPorEscrito(quantidadeAnos) + " anos ";
            }
            if (restoDeAnos > 0)
            {
                dataEscrita += EscreveE();
                if(restoDeAnos > 30)
                {
                    if (restoDeAnos == 1)
                        dataEscrita += NumerosPorEscrito(quantidadeAnos) + " mês ";
                    else
                        dataEscrita += NumerosPorEscrito(quantidadeAnos) + " meses ";
                }


            }

            return dataEscrita;
        }
    }
}
