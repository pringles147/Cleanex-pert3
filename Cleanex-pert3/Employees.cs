//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cleanex_pert3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Employees
    {
        public int EmployeeID { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }
        public string JobTitle { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public string EmployPercentage { get; set; }
        public Nullable<bool> OnVacation { get; set; }
        public string Email { get; set; }
        public string Salary { get; set; }
        public Nullable<System.DateTime> Born { get; set; }
        public string Gender { get; set; }
        public string Photo { get; set; }
        public string Description { get; set; }
        public string Extra1 { get; set; }
        public string Extra2 { get; set; }
    }
}