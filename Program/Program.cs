using DataSql;
using System;
using System.Linq;
using System.Reflection.Metadata;

using DataContext db = new DataContext();

// Note: This sample requires the database to be created before running.
Console.WriteLine($"Database path: {db.DbPath}.");

// Create
Console.WriteLine("Inserting a new ...");
db.SaveChanges();

// Read
Console.WriteLine("Querying for a ...");

// Update
Console.WriteLine("Updating the ... and adding a ...");

db.SaveChanges();

// Delete
Console.WriteLine("Delete the ...");

db.SaveChanges();