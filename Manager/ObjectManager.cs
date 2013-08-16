using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Magic;

namespace Wowapp.Manager
{
    /// <summary>
    /// Gestion des objets du jeu
    /// </summary>
    static class ObjectManager
    {
        /// <summary>
        /// Classe pour la lecture en mémoire
        /// </summary>
        public static BlackMagic Wow = new BlackMagic();

        /// <summary>
        /// Le processus et ouvert et pret pour l'operation
        /// </summary>
        public static bool processOpen
        {
            get
            {
                try
                {
                    if (Wow.OpenProcessAndThread(SProcess.GetProcessFromProcessName("Wow")))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch
                {
                    return false;
                }
            }
        }

        /// <summary>
        /// ObjectManager du jeu
        /// </summary>
        public static uint objMgr
        {
            get
            {
                try
                {
                    return Wow.ReadUInt(Wow.ReadUInt((uint)wowBaseAddress + (uint)Offsets.ObjectManager.clientConnection) + (uint)Offsets.ObjectManager.objectManager);
                }
                catch
                {
                    return 0;
                }
            }
        }

        /// <summary>
        /// Premier objet présent de le manager
        /// </summary>
        public static uint firstObj
        {
            get
            {
                try
                {
                    return Wow.ReadUInt(objMgr + (uint)Offsets.ObjectManager.firstObject);
                }
                catch
                {
                    return 0;
                }
            }
        }

        /// <summary>
        /// Adresse de départ du module (Wow)
        /// </summary>
        public static IntPtr wowBaseAddress 
        { 
            get
            { 
                try 
                {
                    return Wow.MainModule.BaseAddress;
                }
                catch
                {
                    return new IntPtr(0);
                }
            }
        }

        /// <summary>
        /// GUID du joueur
        /// </summary>
        public static uint playerGuid { get { return Wow.ReadUInt((uint)objMgr + (uint)Offsets.ObjectManager.localGUID); } }

        /// <summary>
        /// Initie la classe
        /// </summary>
        public static void init()
        {
            while (!processOpen)
            {
                Console.Clear();
                Console.WriteLine("Impossible de trouver la fênetre du jeu");
                System.Threading.Thread.Sleep(50);
            }
        }

        /// <summary>
        /// Retourne l'empalecement mémoire du GUID fournis
        /// </summary>
        /// <param name="guid">GUID de l'objet</param>
        /// <returns>Adresse mémoire de l'objet</returns>
        public static uint getMemoryLocationByGuid(uint guid)
        {
            if (!processOpen)
                return 0;

            uint curObj = firstObj;
            uint objType = Wow.ReadUInt(curObj + (uint)Offsets.Object.type);
            while (objType <= 7 && objType > 0)
            {
                uint curGuid = Wow.ReadUInt(curObj + (uint)Offsets.Object.guid);
                if (curGuid == guid)
                {
                    return curObj;
                }
                else
                {
                    uint nextObj = Wow.ReadUInt(curObj + (uint)Offsets.ObjectManager.nextObject);
                    curObj = nextObj;
                }
            }
            return 0;
        }

        /// <summary>
        /// Obtiens le type d'objet en fonction du GUID
        /// </summary>
        /// <param name="guid">GUID de l'objet dont il faut obtenir le type</param>
        /// <returns>Adresse mémoire de l'objet trouvé</returns>
        public static uint getObjectTypeByGuid(uint guid)
        {
            uint curObj = firstObj;
            uint objType = Wow.ReadUInt(curObj + (uint)Offsets.Object.type);
            while (Wow.ReadUInt(curObj + (uint)Offsets.Object.guid) != guid)
            {
                uint nextObj = Wow.ReadUInt(curObj + (uint)Offsets.ObjectManager.nextObject);
                curObj = nextObj;
            }
            return curObj;
        }
    }
}
