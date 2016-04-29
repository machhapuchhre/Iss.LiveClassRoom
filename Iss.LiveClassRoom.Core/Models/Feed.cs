﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iss.LiveClassRoom.Core.Models
{
    public abstract class Feed : BaseEntity
    {
        public virtual ICollection<Comment> Comments { get; set; }

        public Feed() : base()
        {
            Comments = new HashSet<Comment>();
        }
    }
}
