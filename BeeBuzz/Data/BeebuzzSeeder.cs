using BeeBuzz.Data;
using BeeBuzz.Data.Entities;
using BeeBuzz.Models;
using Microsoft.AspNetCore.Identity;
using System.Text.Json;

namespace Dutch_Treat.Data
{
    public class BeebuzzSeeder
    {
        private readonly ApplicationDbContext _db;
        private readonly IWebHostEnvironment _hosting;
        private readonly RoleManager<IdentityRole<int>> _roleManager;

        public BeebuzzSeeder(
            ApplicationDbContext db,
            IWebHostEnvironment hosting,
            RoleManager<IdentityRole<int>> roleManager)
        {
            _db = db;
            _hosting = hosting;
            _roleManager = roleManager;
        }
        public async Task Seed()
        {
            //Verify that the database exists. Hover over the method and read the documentation. 
            _db.Database.EnsureCreated();
            //  Create roles
            await SeedRolesAsync();

            // Create org
            await SeedOrganizationAsync();
            

        }

        private async Task SeedRolesAsync()
        {
            string[] roles = { "Admin" };
            foreach (var roleName in roles)
            {
                if (!await _roleManager.RoleExistsAsync(roleName))
                {
                    await _roleManager.CreateAsync(new IdentityRole<int>(roleName));
                }
            }
        }

        private async Task SeedOrganizationAsync()
        {
            if (!_db.Orgnanization.Any())
            {

                //ContentRootPath is refering to the folders not related to wwwroot
                var file = Path.Combine(_hosting.ContentRootPath, "Data/organization.json");
                var json = File.ReadAllText(file);

                //Deserialise the json file into the List of Product class
                var orgnanizations = JsonSerializer.Deserialize<IEnumerable<Orgnanization>>(json);

                //Add the new list of products to the database
                _db.Orgnanization.AddRange(orgnanizations);

                _db.SaveChanges();  //commit changes to the database (make permanent) 
            }
        }


    }
}
