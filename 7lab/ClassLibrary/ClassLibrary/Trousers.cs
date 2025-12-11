namespace ClassLibrary
{
    public class Trousers : Cloth
    {
        public const ClothType clothType = ClothType.Trousers;
        public bool HasPockets { get; private set; }
        
        public Trousers(Gender Gender, int Height, int Width, FabricType fabricType, string Color, bool HasPockets) : base(Gender, Height, Width, fabricType, Color)
        {

            this.HasPockets = HasPockets;
        
        }
    }
}
