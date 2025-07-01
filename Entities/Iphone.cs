using ProjectPhone.Entities.Abstract;

namespace ProjectPhone.Entities
{
    class Iphone : Smartphone
    {
        public Iphone(string number, string model, string imei, int memory) : base(number, model, imei, memory)
        {
            
        }
        public override void InstallApp(string name)
        {
            System.Console.WriteLine($"Aplicativo {name} Instalado no Iphone");
        }
    }
}