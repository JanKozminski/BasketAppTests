﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketApp.Domain.Entities
{
    public class State
    {
        [Key]
        public required int Id { get; set; }
        public  string Name { get; set; } = default!;
    }
}