﻿using Catrobat_Player.NativeComponent;
using System.Xml.Serialization;
using System;

namespace Catrobat.Models.v099
{
    partial class BroadcastBrick : IBroadcastBrick
    {
        #region NativeComponent
        [XmlIgnore]
        public string BroadcastMessage
        {
            get
            {
                return broadcastMessage;
            }
            set { }
        }
        #endregion
    }
}
