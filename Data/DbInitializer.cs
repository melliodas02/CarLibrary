using CarLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarLib.Data
{
    public class DbInitializer
    {
        public static void Initialize(CarLibContext context)
        {
            context.Database.EnsureCreated();

            if (context.Brands.Any())
            {
                return;
            }

            var brands = new Brand[]
            {
                new Brand { Name = "BMW", Active = true },
                new Brand { Name = "Audi", Active = true },
                new Brand { Name = "Ford", Active = true },
                new Brand { Name = "Honda", Active = true },
                new Brand { Name = "Kia", Active = true },
                new Brand { Name = "Lada", Active = true },
                new Brand { Name = "Mazda", Active = true },
                new Brand { Name = "Toyota", Active = true }
            };
            foreach (Brand b in brands)
            {
                context.Brands.Add(b);
            }
            context.SaveChanges();

            var models = new Model[]
            {
                // BMW
                new Model { Name = "M2", BrandId = 1, Active = true },
                new Model { Name = "8", BrandId = 1, Active = true },
                new Model { Name = "4", BrandId = 1, Active = true },

                // Audi
                new Model { Name = "A6", BrandId = 2, Active = true },
                new Model { Name = "A8", BrandId = 2, Active = true },
                new Model { Name = "A3", BrandId = 2, Active = true },
                new Model { Name = "90", BrandId = 2, Active = false },
                new Model { Name = "100", BrandId = 2, Active = false },

                // Ford
                new Model { Name = "Transit", BrandId = 3, Active = true },
                new Model { Name = "Bronco", BrandId = 3, Active = false },
                new Model { Name = "C-Max", BrandId = 3, Active = false },

                // Honda
                new Model { Name = "CR-V", BrandId = 4, Active = true },
                new Model { Name = "Pilot", BrandId = 4, Active = true },
                new Model { Name = "Capa", BrandId = 4, Active = false },
                new Model { Name = "Civic", BrandId = 4, Active = false },

                // Kia
                new Model { Name = "Creato", BrandId = 5, Active = true },
                new Model { Name = "Rio", BrandId = 5, Active = true },
                new Model { Name = "Besta", BrandId = 5, Active = false },

                // Lada
                new Model { Name = "Vesta", BrandId = 6, Active = true },
                new Model { Name = "Granta", BrandId = 6, Active = true },
                new Model { Name = "2105", BrandId = 6, Active = false },

                // Mazda 
                new Model { Name = "6", BrandId = 7, Active = true },
                new Model { Name = "CX-30", BrandId = 7, Active = true },
                new Model { Name = "3", BrandId = 7, Active = false },
                new Model { Name = "5", BrandId = 7, Active = false },

                // Toyota
                new Model { Name = "Supra", BrandId = 8, Active = true },
                new Model { Name = "Camry", BrandId = 8, Active = true },
                new Model { Name = "RAV4", BrandId = 8, Active = true },
                new Model { Name = "Aurion", BrandId = 8, Active = false }
            };
            foreach (Model m in models)
            {
                context.Models.Add(m);
            }
            context.SaveChanges();

            User users = new User { Email = "poseydonplay02@gmail.com", Password = "Gangsta14@. " };
            context.Users.Add(users);
            context.SaveChanges();
        }
    }
}
