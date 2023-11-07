using DataSql;
using DataSql.Classes;
using System;
using System.Linq;
using System.Reflection.Metadata;

using DataContext db = new DataContext();

// Note: This sample requires the database to be created before running.
Console.WriteLine($"Database path: {db.DbPath}");

// Create
Console.WriteLine("Inserting a new ...");
Instrument newInstrument = new Instrument() { Identifier = "TSLA", InstrumentType = "Equity" };

//db.Instruments.Add(newInstrument);

db.SaveChanges();



// Read
Console.WriteLine("Querying for a ...");
var list = db.Instruments.ToList();


// Update
Console.WriteLine("Updating the ... and adding a ...");

db.SaveChanges();

// Delete
Console.WriteLine("Delete the ...");

db.SaveChanges();