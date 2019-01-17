﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SrTest.Web.Models
{
    [Serializable]
    public class Employee
    {
        [Display(Name = "ID")]
        public int Id { get; set; }
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Display(Name = "Contract Type Name")]
        public string ContractTypeName { get; set; }
        [Display(Name = "Role Id")]
        public int RoleId { get; set; }
        [Display(Name = "Role Name")]
        public string RoleName { get; set; }
        [Display(Name = "Role Description")]
        public string RoleDescription { get; set; }
        [Display(Name = "Annual Salary")]
        public string AnnualSalary { get; set; }
    }
}