using BAAS.Model;
using System.Collections.Generic;

namespace BAAS.Services
{
    // The view-model is talking to our database through the service. The service
    public class SubmarineService
    {
        public List<Submarine> GetSubmarines()
        {
            return new List<Submarine>
            {
                new Submarine
                {
                    Id = 1,
                    Name = "Poseidon's Pride",
                    Color = "Blue"
                },
                new Submarine
                {
                    Id = 2,
                    Name = "Neptune's Discovery",
                    Color = "Yellow"
                },
                new Submarine
                {
                    Id = 3,
                    Name = "Oceania's Majestic Aquatic Voyager  ",
                    Color = "Red"
                }               
                //new Submarine
                //{
                //    Id = 4,
                //    Name = "Test 4",
                //    Color = "Blue"
                //},
                //new Submarine
                //{
                //    Id = 5,
                //    Name = "Test 5",
                //    Color = "Yellow"
                //},
                //new Submarine
                //{
                //    Id = 6,
                //    Name = "Test 6",
                //    Color = "Red"
                //},                
                //new Submarine
                //{
                //    Id = 7,
                //    Name = "Test 7",
                //    Color = "Blue"
                //},
                //new Submarine
                //{
                //    Id = 8,
                //    Name = "Test 8",
                //    Color = "Yellow"
                //},
                //new Submarine
                //{
                //    Id = 9,
                //    Name = "Test 9",
                //    Color = "Red"
                //},                
                //new Submarine
                //{
                //    Id = 10,
                //    Name = "Test 10",
                //    Color = "Blue"
                //},
                //new Submarine
                //{
                //    Id = 11,
                //    Name = "Test 11",
                //    Color = "Yellow"
                //},
                //new Submarine
                //{
                //    Id = 12,
                //    Name = "Test 12",
                //    Color = "Red"
                //}
            };
        }
    }
}
