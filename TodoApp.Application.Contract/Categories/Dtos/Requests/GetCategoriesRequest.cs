﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp.Application.Contract.Categories.Dtos.Requests
{
    public class GetCategoriesRequest
    {
        public string FilterText { get; set; }
    }
}
