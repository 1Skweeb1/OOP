namespace ClassLibrary
{
    public class Cloth
    {
        public Gender Gender { get; set; }
        public int Height { get; private set; }
        public int Width { get; private set; }
        public FabricType FabricType { get; private set; }
        public string Color { get; private set; }
        public Cloth(Gender Gender, int Height, int Width, FabricType FabricType, string Color)
        {

            this.Gender = Gender;
            this.Height = Height;
            this.Width = Width;
            this.FabricType = FabricType;
            this.Color = Color;

        }
    }
}
