﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArchitecture.Web.BindingModels
{
    public class UpdateTodoListItemBindingModel
    {
        [Required]
        public Guid? TodoListItemId { get; set; }
        [Required]
        public bool? IsDone { get; set; }
    }
}
