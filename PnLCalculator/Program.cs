using CsvHelper;
using PnLCalculator;
using System.Globalization;

// Get filename for results csv, and delete if existing 
var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
var resultsPath = Path.Combine(documentsPath, "Performance.csv");
if (File.Exists(resultsPath)) { File.Delete(resultsPath); }

using (var db = new DataContext())
{
    db.InitialiseDatabase();

    // YOUR CODE OR ENTRY TO YOUR CODE HERE 


    // LINQ to SQL example: Read with WHERE clause 
    // List<MarketPrices> instrumentOnePrices = db.MarketPrices.Where(x => x.InstrumentID = 1).ToList();

};

// Write results object to CSV (we haven't created this object in the template given to you)
using (var writer = new StreamWriter(resultsPath)) 
{ 
    using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture)) 
    {
        //csv.WriteRecords(YOUR_RESULTS_LIST_OBJECT);
    }
}
