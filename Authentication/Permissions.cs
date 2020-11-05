using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Authentication
{
    public enum Permissions : short
    {
        NotSet = 0, //error condition

        [Display(GroupName = "Users", Name = "Read", Description = "Permission to List & View Users")]
        UsersRead,
        [Display(GroupName = "Users", Name = "Manage", Description = "Permission to Add/Edit/Delete/Disable a User")]
        UsersManage,

        [Display(GroupName = "Workflow", Name = "Read", Description = "Permission to List & View Workflows")]
        WorkflowRead,
        [Display(GroupName = "Workflow", Name = "Manage", Description = "Permission to Add/Edit/Delete/Disable a User as Workflow")]
        WorkflowManage,

        [Display(GroupName = "Values", Name = "Read", Description = "Permission to View/List the Values")]
        ValuesRead,
        [Display(GroupName = "Values", Name = "Create", Description = "Permission to Add a Value")]
        ValuesCreate,
        [Display(GroupName = "Values", Name = "Update", Description = "Permission to Edit a Value")]
        ValuesUpdate,
        [Display(GroupName = "Values", Name = "Delete", Description = "Permission to Delete a Value")]
        ValuesDelete
    }
}
