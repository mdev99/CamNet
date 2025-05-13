using System;

namespace Core.Entities;

public class Product : BaseEntity
{
    public required string CBrand { get; set; }
    public required string CModel { get; set; }
    public required string CType { get; set; }
    public required string Description { get; set; }
    public required string PictureUrl { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
}
