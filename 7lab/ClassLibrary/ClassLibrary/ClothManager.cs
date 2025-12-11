namespace ClassLibrary
{
    public class ClothManager
    {
        public List<Costume> GetCostumesByGender(Gender Gender, List<Costume> Costumes)
        {
            List<Costume> FinalCostumes = new List<Costume>();

            foreach (Costume costume in Costumes)
            {
                if (costume.Coat.Gender == Gender || costume.Coat.Gender == Gender.MaleAndFemale)
                {
                    FinalCostumes.Add(costume);
                }
            }

            return FinalCostumes;
        }

        public List<Costume> GetFemaleCostumesWithTrousers(List<Costume> Costumes)
        {
            List<Costume> FinalCostumes = new List<Costume>();

            foreach (Costume costume in Costumes)
            {
                if (costume.Coat.Gender == Gender.Female && costume.Trousers != null)
                {
                    FinalCostumes.Add(costume);
                }
            }

            return FinalCostumes;
        }

        public List<Trousers> GetRedTrousers(List<Trousers> Trousers)
        {
            List<Trousers> FinalTrousers = new List<Trousers>();
            foreach (Trousers t in Trousers)
            {
                if (t.Color.ToLower().Equals("red"))
                {
                    FinalTrousers.Add(t);
                }
            }
            return FinalTrousers; 
        }

        public Dictionary<ClothType,int> GetCountOfClothTypeByGender(List<Cloth> Clothes, Gender Gender) {
            
            Dictionary<ClothType, int> ClothesCount = new Dictionary<ClothType, int>();
            
            int CountTrousers = 0;
            int CountSkirts = 0;
            int CountCoats = 0;
            
            foreach (Trousers t in Clothes.OfType<Trousers>().ToList()) { 
                if(t.Gender == Gender || t.Gender == Gender.MaleAndFemale)
                {
                    CountTrousers++;
                }
            }
            
            foreach (Skirt s in Clothes.OfType<Skirt>().ToList()) { 
                if(s.Gender == Gender || s.Gender == Gender.MaleAndFemale)
                {
                    CountSkirts++;
                }
            }

            foreach (Coat c in Clothes.OfType<Coat>().ToList()) { 
                if(c.Gender == Gender || c.Gender == Gender.MaleAndFemale)
                {
                    CountCoats++;
                }
            }
            
            ClothesCount.Add(ClothType.Trousers, CountTrousers);
            ClothesCount.Add(ClothType.Skirt, CountSkirts);
            ClothesCount.Add(ClothType.Coat, CountCoats);

            return ClothesCount;
        }
    }
}
