using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ContaTempo
{
    public class ContadorPeriodo
    {
        QualificadorData qData = new QualificadorData();
        public int AnosPassados(DateTime dataInformada)
        {
            int anosContados = 0;
            int anoAnterior = dataInformada.Year;
            int anoAtual = DateTime.Now.Year;
            int mesAnterior = dataInformada.Month;
            int mesAtual = DateTime.Now.Month;
            int diaAnterior = dataInformada.Day;
            int diaAtual = DateTime.Now.Day;

            if (anoAtual == anoAnterior)
                anosContados = 0;

            else if (anoAtual > anoAnterior)
            {
                anosContados = anoAtual - anoAnterior;
                if (mesAtual == mesAnterior)
                {
                    if (diaAtual < diaAnterior)
                        anosContados--;
                   
                }
                else if(mesAtual < mesAnterior)
                    anosContados--;
            }
            return anosContados;
        }
        public string AnosPassadosPorEscrito(DateTime dataInformada)
        {
            string anosPorEscrito = "";
            int quantidadeAnos = AnosPassados(dataInformada);
            if (quantidadeAnos == 0)
                return anosPorEscrito;
            anosPorEscrito = qData.EscrevePeriodo(quantidadeAnos,true);
            
            if (quantidadeAnos == 1)
                return anosPorEscrito = anosPorEscrito+" ano";
            else if(quantidadeAnos > 1)
                return anosPorEscrito = anosPorEscrito + " anos";
            return anosPorEscrito;
        }
        public int MesPassados(DateTime dataInformada)
        {
            int mesContados = 0;
            int anoAnterior = dataInformada.Year;
            int anoAtual = DateTime.Now.Year;
            int mesAnterior = dataInformada.Month;
            int mesAtual = DateTime.Now.Month;
            int diaAnterior = dataInformada.Day;
            int diaAtual = DateTime.Now.Day;

            if (anoAtual == anoAnterior)
                mesContados = mesAtual - mesAnterior;
            if (mesAtual == mesAnterior)
            {
                if (diaAtual < diaAnterior)
                {
                    mesContados++;
                }
            }
                if (mesAtual < mesAnterior)
            {
                mesAtual += 11;
                mesContados = mesAtual - mesAnterior;
            }
            
            return mesContados;
        }
        public string MesPassadosPorEscrito(DateTime dataInformada)
        {
            string anosPorEscrito = "";
            int quantidadeAnos = AnosPassados(dataInformada);
            if (quantidadeAnos == 0)
                return anosPorEscrito;
            anosPorEscrito = qData.EscrevePeriodo(quantidadeAnos, true);

            if (quantidadeAnos == 1)
                return anosPorEscrito = anosPorEscrito + " ano";
            else if (quantidadeAnos > 1)
                return anosPorEscrito = anosPorEscrito + " anos";
            return anosPorEscrito;
        }
    }
}
