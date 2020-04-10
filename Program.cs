using System;
using System.Collections.Generic;
using System.IO;
using Amazon;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DocumentModel;
using Newtonsoft.Json;

namespace AddItemsToDynamoDB
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var client = new AmazonDynamoDBClient(Environment.GetEnvironmentVariable("ACCESS_KEY_ID"), Environment.GetEnvironmentVariable("SECRET_ACCESS_KEY"), RegionEndpoint.USWest2);
            //var tables = client.GetItemAsync();
            var table = Table.LoadTable(client, "OpenBanking_MI");
            //Table table;
            //var tblLoad = Table.TryLoadTable(client, "OPenBanking_MI", out table);
            List<Class1> items;
            using (StreamReader r = new StreamReader("C:/Users/harendra/source/repos/AddItemsToDynamoDB/OpenBanking.json"))
            {
                string json = r.ReadToEnd();
                items = JsonConvert.DeserializeObject<List<Class1>>(json);

                foreach (var itm in items)
                {
                    var record = Document.FromJson(JsonConvert.SerializeObject(itm));
                    table.PutItemAsync(record);
                }
            }

        }
    }
}
// using Amazon.DynamoDBv2;
// using Amazon.DynamoDBv2.DocumentModel;

