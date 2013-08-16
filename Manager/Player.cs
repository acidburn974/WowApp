using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wowapp.Manager
{
    class Player : Object
    {

        /// <summary>
        /// Nom du joueur
        /// </summary>
        public string Name { get { return ObjectManager.Wow.ReadASCIIString((uint)ObjectManager.Wow.MainModule.BaseAddress + (uint)Offsets.Player.name, 32); } }

        /// <summary>
        /// Position X du joueur
        /// </summary>
        public float X { get { return ObjectManager.Wow.ReadFloat((uint)BaseAddress + (uint)Offsets.WowUnit.X); } }

        /// <summary>
        /// Position Y du joueur
        /// </summary>
        public float Y { get { return ObjectManager.Wow.ReadFloat((uint)BaseAddress + (uint)Offsets.WowUnit.Y); } }

        /// <summary>
        /// Position Z du joueur
        /// </summary>
        public float Z { get { return ObjectManager.Wow.ReadFloat((uint)BaseAddress + (uint)Offsets.WowUnit.Z); } }

        /// <summary>
        /// Vie du joueur
        /// </summary>
        public uint Health { get { return ObjectManager.Wow.ReadUInt((uint)DescriptorBase + (uint)Offsets.WowUnit.Health); } }

        /// <summary>
        /// Vie maximum du joueur
        /// </summary>
        public uint MaxHealth { get { return ObjectManager.Wow.ReadUInt((uint)DescriptorBase + (uint)Offsets.WowUnit.MaxHealth); } }

        /// <summary>
        /// Niveau du joueur
        /// </summary>
        public uint Level { get { return ObjectManager.Wow.ReadUInt((uint)DescriptorBase + (uint)Offsets.WowUnit.Level); } }

        /// <summary>
        /// GUID de la cible du joueur
        /// </summary>
        public uint TargetGuid { get { return ObjectManager.Wow.ReadUInt((uint)ObjectManager.wowBaseAddress + (uint)Offsets.Player.targetGuid); } }

        /// <summary>
        /// GUID sur lequel se trouve le curseur du joueur
        /// </summary>
        public uint MouseOverGuid { get { return ObjectManager.Wow.ReadUInt((uint)ObjectManager.wowBaseAddress + (uint)Offsets.Player.mouseOverGUID); } }

        /// <summary>
        /// Classe du joueur
        /// </summary>
        public WowClass Class { get { return (WowClass)ObjectManager.Wow.ReadUInt((uint)ObjectManager.wowBaseAddress + (uint)Offsets.Player.playerClass); } }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="BaseAddress">Adresse mémoire de l'objet ici celui du joueur</param>
        public Player(uint BaseAddress) : base(BaseAddress)
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public uint getHealthPercent()
        {
            return (Health * 100) / MaxHealth;
        }
    }
}
