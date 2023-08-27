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
                    MaxSpeedKmPerHour = 50,
                    MaxDepthM = 260,
                    Description = "Descend into the depths of the ocean with Poseidon's Pride, the epitome of sub-aquatic exploration. This cutting-edge, fictive submarine combines state-of-the-art technology with unparalleled luxury. With a sleek, titanium alloy hull designed for both speed and durability, Poseidon's Pride can dive to the deepest trenches while offering a smooth and comfortable ride."
                },
                new Submarine
                {
                    Id = 2,
                    Name = "Neptune's Discovery",
                    MaxSpeedKmPerHour = 40,
                    MaxDepthM = 300,
                    Description = "Powered by state-of-the-art technology, this vessel allows you to embark on a scientific odyssey, equipped with advanced research instruments and laboratories to study the marine ecosystem. Whether you're a marine biologist, an oceanographer, or simply an adventurer, Neptune's Discovery offers an unmatched platform for deep-sea investigation."
                },
                new Submarine
                {
                    Id = 3,
                    Name = "Oceania's Majestic Aquatic Voyager",
                    MaxSpeedKmPerHour = 60,
                    MaxDepthM = 210,
                    Description="With its graceful, hydrodynamic form and advanced propulsion system, this submarine effortlessly glides through the ocean's realms, ensuring you witness the wonders of aquatic life like never before. Immerse yourself in the tranquility of the abyss, surrounded by panoramic windows that reveal a world teeming with vibrant marine flora and fauna. Oceania's Majestic Aquatic Voyager is your portal to the mysteries of the deep, promising an unforgettable adventure in the heart of the ocean."
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
