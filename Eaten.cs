using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace DietSentry;

public class Eaten
{
    [Key]
    public int EatenId { get; set; }
    public string? FoodDescription { get; set; }
    public float Energy { get; set; }
    public float Protein { get; set; }
    public float FatTotal { get; set; }
    public float SaturatedFat { get; set; }
    public float TransFat { get; set; }
    public float PolyunsaturatedFat { get; set; }
    public float MonounsaturatedFat { get; set; }
    public float Carbohydrate { get; set; }
    public float Sugars { get; set; }
    public float DietaryFibre { get; set; }
    public float SodiumNa { get; set; }
    public float CalciumCa { get; set; }
    public float PotassiumK { get; set; }
    public float ThiaminB1 { get; set; }
    public float RiboflavinB2 { get; set; }
    public float NiacinB3 { get; set; }
    public float Folate { get; set; }
    public float IronFe { get; set; }
    public float MagnesiumMg { get; set; }
    public float VitaminC { get; set; }
    public float Caffeine { get; set; }
    public float Cholesterol { get; set; }
    public float Alcohol { get; set; }
}