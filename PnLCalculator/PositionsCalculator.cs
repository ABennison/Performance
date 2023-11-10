using PnLCalculator;
using PnLCalculator.DataClasses;

public static class PositionsCalculator
{
    public static List<Position> CalculatePositions(DataContext db, Instrument instrument, DateTime startDate, DateTime endDate)
    {
        List<Position> positions = new List<Position>();
        DateTime currentDate = startDate;
        while (currentDate <= endDate) 
        {
            positions.Add(CalculatePositionForDate(db, instrument, currentDate));
            currentDate = currentDate.AddDays(1);
        }

        return positions;
    }

    private static Position CalculatePositionForDate(DataContext db, Instrument instrument, DateTime currentDate)
    {
        Position position = new Position()
        {
            PositionDate = currentDate,
            InstrumentID = instrument.ID,
            Quantity = instrument.Transactions.Where(x => x.TradeDate <= currentDate).Sum(x => x.Quantity),
            MarketPriceLC = instrument.MarketPrices.Where(x => x.PriceDate <= currentDate).OrderByDescending(x => x.PriceDate)
                .Select(x => x.Price).FirstOrDefault(),
            PnlLC  = instrument.Transactions.Where(x => x.TradeDate <= currentDate).Sum(x => x.CashFlow)
        };

        position.NavLC = position.MarketPriceLC * position.Quantity;
        position.PnlLC += position.NavLC;

        return position;
    }
}