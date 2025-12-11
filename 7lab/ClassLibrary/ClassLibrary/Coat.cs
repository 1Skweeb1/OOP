namespace ClassLibrary
{
    public class Coat : Cloth
    {
        public const ClothType clothType = ClothType.Skirt;
        public int ButtonCount { get; private set; }
        
        public Coat(Gender Gender, int Height, int Width, FabricType fabricType, string Color, int ButtonCount) : base(Gender, Height, Width, fabricType, Color)
        {

            this.ButtonCount = ButtonCount;
        
        }
    }
}
