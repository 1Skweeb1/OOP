namespace ClassLibrary
{
    public class Costume
    {
        public Coat Coat { get; private set; }
        public Skirt Skirt { get; private set; }
        public Trousers Trousers { get; private set; }
        
        public Costume(Coat Coat, Skirt Skirt)
        {
            if (Coat.Gender != Skirt.Gender && Coat.Gender != Gender.MaleAndFemale && Skirt.Gender != Gender.MaleAndFemale)
            {
                throw new Exception("гендер у одежды должен быть одинаковый");
            }
            if(Skirt.Gender != Gender.MaleAndFemale)
            {
                Coat.Gender = Skirt.Gender;
            }

            this.Coat = Coat;
            this.Skirt = Skirt;
            
        }

        public Costume(Coat Coat, Trousers Trousers)
        {
            if (Coat.Gender != Trousers.Gender && Coat.Gender != Gender.MaleAndFemale && Trousers.Gender != Gender.MaleAndFemale)
            {
                throw new Exception("гендер у одежды должен быть одинаковый");
            }
            if(Trousers.Gender != Gender.MaleAndFemale)
            {
                Coat.Gender = Trousers.Gender;
            }
            this.Coat = Coat;
            this.Trousers = Trousers;
            
        }
    }
}
