
        decimal spFaturamento = 67836.43m;
        decimal rjFaturamento = 36678.66m;
        decimal mgFaturamento = 29229.88m;
        decimal esFaturamento = 27165.48m;
        decimal outrosFaturamento = 19849.53m;

        decimal faturamentoTotal = spFaturamento + rjFaturamento + mgFaturamento + esFaturamento + outrosFaturamento;


        decimal spPercentual = (spFaturamento / faturamentoTotal) * 100;
        decimal rjPercentual = (rjFaturamento / faturamentoTotal) * 100;
        decimal mgPercentual = (mgFaturamento / faturamentoTotal) * 100;
        decimal esPercentual = (esFaturamento / faturamentoTotal) * 100;
        decimal outrosPercentual = (outrosFaturamento / faturamentoTotal) * 100;


        Console.WriteLine("Percentual de representação do faturamento mensal por estado:");
        Console.WriteLine($"SP: {Decimal.Round(spPercentual,2)}%");
        Console.WriteLine($"RJ: {Decimal.Round(rjPercentual, 2)}%");
        Console.WriteLine($"MG: {Decimal.Round(mgPercentual,2)}%");
        Console.WriteLine($"ES: {Decimal.Round(esPercentual,2)}%");
        Console.WriteLine($"Outros: {outrosPercentual}%");


