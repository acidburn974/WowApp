using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wowapp.Manager;

namespace Wowapp
{
    class Program
    {
        static void Main(string[] args)
        {
            ObjectManager.init();
            Player Me = new Player(ObjectManager.getMemoryLocationByGuid(ObjectManager.playerGuid));
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Nom: " + Me.Name);
                Console.WriteLine("Pourcentage de vie: " + Me.getHealthPercent());
                Console.WriteLine("Vie du joueur: " + Me.Health + "/" + Me.MaxHealth);
                Console.WriteLine("Niveau: " + Me.Level);
                Console.WriteLine("GUID du joueur: " + Me.localGuid);
                Console.WriteLine("GUID de la cible: " + Me.TargetGuid);
                Console.WriteLine("Position X: " + Me.X);
                Console.WriteLine("Position Y: " + Me.Y);
                Console.WriteLine("Position Z: " + Me.Z);
                System.Threading.Thread.Sleep(50);
            }
        }
    }
}
