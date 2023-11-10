using CsvHelper;
using PnLCalculator;
using PnLCalculator.DataClasses;
using System.Globalization;

var START_DATE = new DateTime(2023, 8, 1);
var END_DATE = new DateTime(2023, 10, 31);

// Get filename for results csv, and delete if existing 
var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
var resultsPath = Path.Combine(documentsPath, "Performance.csv");
if (File.Exists(resultsPath)) { File.Delete(resultsPath); }

List<Position> positions = new List<Position>();

using (var db = new DataContext())
{
    db.InitialiseDatabase();
    var instruments = db.Instruments.ToList();
    foreach (var instrument in instruments)
    {
        positions.AddRange(PositionsCalculator.CalculatePositions(db, instrument, START_DATE, END_DATE));
    }
};

// Write results object to CSV (we haven't created this object in the template given to you)
using (var writer = new StreamWriter(resultsPath)) 
{ 
    using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture)) 
    {
        csv.WriteRecords(positions.OrderBy(x => x.PositionDate).ThenBy(x => x.InstrumentID));
    }
}
