using ECommerce.API.Models.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ECommerce.API.Utils
{
    public static class SeedData
    {
        public static List<Order> SeedOrders()
        {
            var fileName = "orders.json";
            var orders = Seed<Order>(fileName);

            var deliveryTeams = SeedDeliveryTeams();
            var random = new Random();

            foreach(var order in orders)
            {
                var deliveryTeamIndex = random.Next(0, deliveryTeams.Count - 1);

                order.DeliveryTeamId = deliveryTeams[deliveryTeamIndex].Id;
            }

            return orders;
        }

        public static List<Product> SeedProducts()
        {
            var fileName = "products.json";
            var products = Seed<Product>(fileName);

            return products;
        }

        public static List<DeliveryTeam> SeedDeliveryTeams()
        {
            var fileName = "deliveryTeams.json";
            var deliveryTeams = Seed<DeliveryTeam>(fileName);

            return deliveryTeams;
        }
        public static List<OrderProduct> SeedOrderProduct()
        {
            var products = SeedProducts();
            var orders = SeedOrders();

            var orderProducts = new List<OrderProduct>();
            var random = new Random();

            foreach(var order in orders)
            {
                var prdCount = random.Next(1, 4);
                var prdSample = products.OrderBy(x=> random.Next()).Take(prdCount).ToList();

                foreach(var prd in prdSample)
                {
                    orderProducts.Add(new OrderProduct { OrderId = order.Id, ProductId = prd.Id });
                }
            
            }
            return orderProducts;
        }
        private static List<T> Seed<T>(string fileName)
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            string path = "Utils";
            string fullPath = Path.Combine(currentDirectory, path, fileName);

            var result = new List<T>();
            using (StreamReader reader = new StreamReader(fullPath,Encoding.UTF7))
            {
                string json = reader.ReadToEnd();
                result = JsonConvert.DeserializeObject<List<T>>(json);
            }

            return result;
        }
    }
}
