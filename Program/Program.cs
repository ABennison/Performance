using DataSql;
using DataSql.Classes;

using DataContext db = new DataContext();

// Note: This sample requires the database to be created before running.
Console.WriteLine($"Database path: {db.DbPath}");

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