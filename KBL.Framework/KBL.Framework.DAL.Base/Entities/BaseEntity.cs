﻿using KBL.Framework.DAL.Interfaces.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace KBL.Framework.DAL.Base.Entities
{
    public abstract class BaseEntity : IEntity
    {
        #region Properties
        public long ID { get; set; }
        public DateTime CreatedDateTime { get; set; }        
        public DateTime? ModifiedDateTime { get; set; }        
        public DateTime? DeletedDateTime { get; set; }        
        #endregion
    }

}
