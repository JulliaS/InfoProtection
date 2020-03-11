using System;
using System.Collections.Generic;
using System.IO;
using System.Net.WebSockets;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace XmlToJsonConverter
{
    public class ExtendedHierarchy
    {
        public string _id { get; set; }

        [JsonPropertyAttribute("regionName")]
        public string Region { get; set; }
        [JsonPropertyAttribute("assetName")]
        public string Field { get; set; }
        [JsonPropertyAttribute("longAssetName")]
        public string LongField { get; set; }
        [JsonPropertyAttribute("FsmAssetName")]
        public string FsmField { get; set; }
    }

    class Program
    {
        private const string FilePathToReadData = @"C:\Users\Yuliia_Stakhiv\Desktop\mappers\ExtendedHierarchy.json";
        private const string FilePathToWriteData = @"C:\Users\Yuliia_Stakhiv\Desktop\mappers\1\ExtendedHierarchy.json";
        private const string RootInXml = "AssetOveriewInformationForDFItemList";
        static void Main(string[] args)
        {
            //WorkOrdersList items;
            //using (var reader = new StreamReader(FilePathToReadData))
            //{
            //    XmlSerializer deserializer = new XmlSerializer(typeof(WorkOrdersList), new XmlRootAttribute(RootInXml));
            //    items = (WorkOrdersList)deserializer.Deserialize(reader);
            //}

            //foreach (var item in items.Items)
            //{
            //    item._id = Guid.NewGuid().ToString();
            //}

            //using (var sw = new StreamWriter(FilePathToWriteData))
            //{
            //    var jsonString = JsonConvert.SerializeObject(items.Items);
            //    sw.Write(jsonString);
            //}
            var results = new List<ExtendedHierarchy>();

            using (var reader = new StreamReader(FilePathToReadData))
            {
                var striReadToEnd = reader.ReadToEnd(); 
                results = JsonConvert.DeserializeObject<List<ExtendedHierarchy>>(striReadToEnd);

                foreach (var item in results)
                {
                    item._id = Guid.NewGuid().ToString();
                }

            }

            using (var sw = new StreamWriter(FilePathToWriteData))
            {
                var jsonString = JsonConvert.SerializeObject(results);
                sw.Write(jsonString);
            }
        }
    }
}
