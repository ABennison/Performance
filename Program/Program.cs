using PnLCalculator;

using DataContext db = new DataContext();

Console.WriteLine($"Database path: {db.DbPath}");

var thingy = db.Instruments.ToList();
int sss = 5;

// Create
//Instrument newInstrument = new Instrument() { InstrumentIdentifier = "TSLA", InstrumentType = "Equity" };
//db.Instruments.Add(newInstrument);
//db.SaveChanges();


// Read
//List<Instrument> list = db.Instruments.ToList();


// Update
//MarketPrice marketPrice = db.MarketPrices.FirstOrDefault(x => x.Date == new DateTime(2023, 10, 15) && x.InstrumentIdentifier == "TEST");
//marketPrice.Price = 35;
//db.SaveChanges();


// Delete
//db.Instruments.Remove(newInstrument);
//db.SaveChanges();