namespace Kapselungen_Vererbungen
{
    class Tortoise
    {
        public string Name;
        public Tortoise(string name)
        {
            this.Name = name;
        }
    }

    class Creep
    {
        public List<Tortoise> tortoiseList;
    }
}
