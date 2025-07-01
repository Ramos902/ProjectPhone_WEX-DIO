using ProjectPhone.Entities;

namespace ProjectPhone
{
    class Program
    {
        public static void Main()
        {
            Iphone iphone1 = new("1543", "Iphone14", "45544234", 256);
            Iphone iphone2 = new("1543", "Iphone11", "45546576", 128);
            iphone1.TurnOn();
            iphone2.TurnOn();
            iphone1.Call();
            iphone2.Call();
            iphone1.InstallApp("Word");
            iphone2.InstallApp("Office");

            Nokia nokia1 = new("7856", "Nokia12", "67454543", 64);
            Nokia nokia2 = new("7858", "Nokia11", "67454756", 32);
        }
    }
}