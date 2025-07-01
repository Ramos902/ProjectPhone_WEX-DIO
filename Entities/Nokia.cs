using ProjectPhone.Entities.Abstract;

namespace ProjectPhone.Entities
{
    class Nokia : Smartphone
    {
        public Nokia(string number, string model, string imei, int memory) : base(number, model, imei, memory)
        {
            
        }
        public override void InstallApp(string name)
        {
            System.Console.WriteLine($"Aplicativo {name} Instalado no Nokia");
        }
    }
}