﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.Domain
{       
    public class Note
        {
            public Guid UserId { get; set; }
            public Guid Id { get; set; }
            public string Details { get; set; }
            public string Title { get; set; }
            public DateTime CreatedDate { get; set; }
            public DateTime? UpdatedDate { get; set; }
        }
   
}