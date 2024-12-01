﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryModels.DtoModels.Screen
{
    public class UpdateScreenDto
    {
        public string Name { get; set; }
        public int? DepartmentId { get; set; }
        public int? LocationId { get; set; }
        public string ScreenType { get; set; }
        public bool IsOnline { get; set; }
        public string StatusMessage { get; set; }
    }
}

