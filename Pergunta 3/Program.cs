using System;
using System.Xml;

class Program
{
    static void Main(string[] args)
    {

        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.Load("C:\\Users\\Pichau\\source\\repos\\Pergunta 2\\Pergunta 3\\faturamento.xml");

    
        XmlNodeList faturamentoNodes = xmlDoc.GetElementsByTagName("faturamento");

   
        decimal menorFaturamento = decimal.MaxValue;
        decimal maiorFaturamento = decimal.MinValue;

   
        decimal mediaMensal = 0;
        int numDiasComFaturamento = 0;
        foreach (XmlNode faturamentoNode in faturamentoNodes)
        {
            decimal faturamento = decimal.Parse(faturamentoNode.InnerText);
            if (faturamento < menorFaturamento)
            {
                menorFaturamento = faturamento;
            }
            if (faturamento > maiorFaturamento)
            {
                maiorFaturamento = faturamento;
            }
            if (faturamento > 0)
            {
                mediaMensal += faturamento;
                numDiasComFaturamento++;
            }
        }
        mediaMensal /= numDiasComFaturamento;

       
        int numDiasAcimaMedia = 0;
        foreach (XmlNode faturamentoNode in faturamentoNodes)
        {
            decimal faturamento = decimal.Parse(faturamentoNode.InnerText);
            if (faturamento > mediaMensal)
            {
                numDiasAcimaMedia++;
            }
        }

       
        Console.WriteLine("Menor faturamento diário: " + menorFaturamento);
        Console.WriteLine("Maior faturamento diário: " + maiorFaturamento);
        Console.WriteLine("Número de dias com faturamento acima da média mensal: " + numDiasAcimaMedia);
    }
}
