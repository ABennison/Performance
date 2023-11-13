using PnLCalculator.DataClasses;

public static class UsdCashflowCalculator
{
    public static void CalculateUsdCashflows(List<Transaction> transactions)
    {
        foreach (Transaction transaction in transactions)
        {
            FxRate rate = transaction.Instrument.Currency.FxRates.Where(x => x.PriceDate < transaction.TradeDate).OrderByDescending(x => x.PriceDate)
                .FirstOrDefault();
            
            transaction.CashFlowUSD = transaction.CashFlow/(rate?.Rate ?? 1);
        }
    }
}