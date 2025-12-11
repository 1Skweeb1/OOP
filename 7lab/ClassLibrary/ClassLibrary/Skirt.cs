namespace ClassLibrary
{
    public class Skirt : Cloth
    {
        public const ClothType clothType = ClothType.Skirt;
        public string Fasson { get; private set; }
        
        public Skirt(Gender Gender, int Height, int Width, FabricType fabricType, string Color, string Fasson) : base(Gender, Height, Width, fabricType, Color)
        {

            this.Fasson = Fasson;
        
        }
    }
}
