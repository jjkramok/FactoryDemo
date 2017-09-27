namespace FactoryDemo
{
    public class EarthDog : Dog
    {
        public string Name { get; set; }
        
        public void Cry()
        {
            throw new System.NotImplementedException();
        }

        public override string ToString()
        {
            throw new System.NotImplementedException();
        }
    }
}