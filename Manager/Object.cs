using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wowapp.Manager
{
    class Object
    {
        /// <summary>
        /// Adresse memoire du joueur
        /// </summary>
        protected IntPtr BaseAddress;

        /// <summary>
        /// Adresse mémoire du descriptor de cette objet
        /// </summary>
        protected uint DescriptorBase { get { return ObjectManager.Wow.ReadUInt((uint)BaseAddress + (uint)Offsets.Descriptors.descriptor); } }

        /// <summary>
        /// GUID du joueur
        /// </summary>
        public uint localGuid { get { return ObjectManager.Wow.ReadUInt((uint)BaseAddress + (uint)Offsets.Object.guid); } }

        /// <summary>
        /// Type d'objet
        /// </summary>
        public uint Type { get { return ObjectManager.getObjectTypeByGuid(localGuid); } }

        public Object(uint BaseAddress)
        {
            this.BaseAddress = (IntPtr)BaseAddress;
        }
    }
}
