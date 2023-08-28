using Microsoft.EntityFrameworkCore;

namespace DietSentryNew;

public class FoodsContext : DbContext
{
    public DbSet<Food> Foods { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite("Data Source=foods.db");
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Food>().HasData(
            new Food
            {
                FoodId = 1,
                FoodDescription = "Test 1",
                Energy = 1.0F,
                Protein = 2.1F,
                FatTotal = 3.0F,
                SaturatedFat = 4.0F,
                TransFat = 5.0F,
                PolyunsaturatedFat = 6.0F,
                MonounsaturatedFat = 7.0F,
                Carbohydrate = 8.0F,
                Sugars = 9.0F,
                DietaryFibre = 10.0F,
                SodiumNa = 11.0F,
                CalciumCa = 12.0F,
                PotassiumK = 13.0F,
                ThiaminB1 = 14.0F,
                RiboflavinB2 = 15.0F,
                NiacinB3 = 16.0F,
                Folate = 17.0F,
                IronFe = 18.0F,
                MagnesiumMg = 19.0F,
                VitaminC = 20.0F,
                Caffeine = 21.0F,
                Cholesterol = 22.0F,
                Alcohol = 23.0F
            },
            new Food
            {
                FoodId = 2,
                FoodDescription = "Test 2",
                Energy = 2.0F,
                Protein = 2.0F,
                FatTotal = 3.0F,
                SaturatedFat = 4.0F,
                TransFat = 5.0F,
                PolyunsaturatedFat = 6.0F,
                MonounsaturatedFat = 7.0F,
                Carbohydrate = 8.0F,
                Sugars = 9.0F,
                DietaryFibre = 10.0F,
                SodiumNa = 11.0F,
                CalciumCa = 12.0F,
                PotassiumK = 13.0F,
                ThiaminB1 = 14.0F,
                RiboflavinB2 = 15.0F,
                NiacinB3 = 16.0F,
                Folate = 17.0F,
                IronFe = 18.0F,
                MagnesiumMg = 19.0F,
                VitaminC = 20.0F,
                Caffeine = 21.0F,
                Cholesterol = 22.0F,
                Alcohol = 23.0F
            },
            new Food
            {
                FoodId = 3,
                FoodDescription = "Test 2",
                Energy = 1.0F,
                Protein = 2.0F,
                FatTotal = 3.0F,
                SaturatedFat = 4.0F,
                TransFat = 5.0F,
                PolyunsaturatedFat = 6.0F,
                MonounsaturatedFat = 7.0F,
                Carbohydrate = 8.0F,
                Sugars = 9.0F,
                DietaryFibre = 10.0F,
                SodiumNa = 11.0F,
                CalciumCa = 12.0F,
                PotassiumK = 13.0F,
                ThiaminB1 = 14.0F,
                RiboflavinB2 = 15.0F,
                NiacinB3 = 16.0F,
                Folate = 17.0F,
                IronFe = 18.0F,
                MagnesiumMg = 19.0F,
                VitaminC = 20.0F,
                Caffeine = 21.0F,
                Cholesterol = 22.0F,
                Alcohol = 23.0F
            }
        );
    }
}

