﻿using Catrobat_Player.NativeComponent;
using System.Xml.Serialization;

namespace Catrobat.Models.v098
{
    partial class UserVariable : IUserVariable
    {
        #region NativeComponent
        [XmlIgnore]
        public string Name
        {
            get
            {
                return this.Value;
            }
            set { }
        }
        #endregion

    }
}
