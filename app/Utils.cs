using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.ML;
using Microsoft.ML.Data;

public class Utils {
        public static List<string> csvReader(string filePath){
            var records = new List<string>();
            MLContext mlContext = new MLContext();
            IDataView data = mlContext.Data.LoadFromTextFile<HousingData>(filePath, separatorChar: ',', hasHeader: true);
            return records;
        }
}