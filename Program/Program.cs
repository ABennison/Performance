using DataSql;
using DataSql.Classes;

using DataContext db = new DataContext();

// Note: This sample requires the database to be created before running.
Console.WriteLine($"Database path: {db.DbPath}");

// Create
Instrument newInstrument = new Instrument() { InstrumentIdentifier = "TSLA", InstrumentType = "Equity" };

//db.Instruments.Add(newInstrument);

db.SaveChanges();



// Read
var list = db.Instruments.ToList();


// Update

db.SaveChanges();

// Delete
db.Instruments.Remove(newInstrument);

db.SaveChanges();