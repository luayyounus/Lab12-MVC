using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DontWineAboutIt.Models
{
    public class Csv
    {
        public static List<Wine> GetWineList()
        {
            List<Wine> myWine = new List<Wine>();
            string path = Environment.CurrentDirectory;
            string newPath = Path.GetFullPath(Path.Combine(path, "~/wine.csv"));
            using (StreamReader reader = new StreamReader(newPath))
            {
                int counter = 0;
                string line;

                //only grab the top 1000 wines. 
                while (((line = reader.ReadLine()) != null) && counter < 1001)
                {
                    Regex parser = new Regex(",(?=(?:[^\"]*\"[^\"]*\")*(?![^\"]*\"))");

                    //Separating columns to array
                    string[] wineList = parser.Split(line);

                    //Add new wine object to the list. 
                    myWine.Add(new Wine
                    {
                        Id = int.Parse(wineList[0]),
                        Country = wineList[1],
                        Description = wineList[2],
                        Designation = wineList[3],
                        Points = wineList[4],
                        Price = int.Parse(wineList[5]),
                        Region1 = wineList[6],
                        Region2 = wineList[7],
                        Variety = wineList[8],
                        Winery = wineList[9]

                    });

                    counter++;
                }
            }

            return myWine;
        }
    }
}
