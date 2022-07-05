
namespace Patterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Singleton pattern
            Console.WriteLine("Singleton pattern: \n");
            Singleton s1 = Singleton.Initialize();
            Console.WriteLine(s1.GetHashCode());

            Singleton s2 = Singleton.Initialize();
            Console.WriteLine(s2.GetHashCode()+"\n");
            #endregion

            #region Command pattern
            Console.WriteLine("Command pattern: \n");
            Conveyor conveyor = new Conveyor();
            Multipult multipult = new Multipult();

            multipult.SetCommand(0,new ConveyorWorkCommand(conveyor));
            multipult.SetCommand(1, new ConveyorAdjustCommand(conveyor));

            multipult.PressOn(0);
            multipult.PressOn(1);
            multipult.PressCancel();
            multipult.PressCancel();
            #endregion
        }
    }
}