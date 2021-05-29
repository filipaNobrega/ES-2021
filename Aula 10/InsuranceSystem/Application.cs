namespace InsuranceSystem
{
    public class Application
    {
        private static int _id = 0; 
        public Application()
        {
            Id = _id;
            _id++;
        }

        public int Id { get; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public bool HasCancer { get; set; }
        public bool HasDiabetes { get; set; }
        public bool HasAcne { get; set; }
        public bool HasLupus { get; set; }
        public bool HasEpilepsy { get; set; }
    }
}