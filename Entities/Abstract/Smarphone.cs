namespace ProjectPhone.Entities.Abstract
{
    public abstract class Smartphone
    {
        public string Number { get; set; }
        protected string Model { get; set; }
        protected string Imei { get; set; }
        protected int Memory { get; set; }

        public Smartphone(string number, string model, string imei, int memory)
        {
            Number = number;
            Model = model;
            Imei = imei;
            Memory = memory;
        }
        public void TurnOn()
        {
            System.Console.WriteLine($"Smartphone {Model} turned on");
        }
        public void Call()
        {
            System.Console.WriteLine($"Smartphone {Model}, someone is calling");
        }
        public abstract void InstallApp(string nome);
        
    }
}