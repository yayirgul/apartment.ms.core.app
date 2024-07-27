﻿using ams.entity.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace ams.entity.DTOs
{
    public class DebitDTO
    {
        public class Add
        {
            public Guid ApartmentId { get; set; }
            public int Month { get; set; }
            public int Year { get; set; }
        }

        public class Table
        {
            public Guid Id { get; set; }
            public string? HousingName { get; set; }
            public string? HousingUser { get; set; }


            public int _Month { get; set; }
            public int _Year { get; set; }
            public decimal? Amount { get; set; }
            public string? _Amount { get; set; }
            public int Paid { get; set; }
            public int IsActive { get; set; }
            public int Queue { get; set; }


            public string? ExpenseCode { get; set; }
            public string? ExpenseDate { get; set; }
            public string? _CreateTime { get; set; }
            public DateTime CreateTime { get; set; }




            public Guid ApartmentId { get; set; }
            public Apartment? Apartment { get; set; }
            public Guid? HousingId { get; set; }
        





            public string? CreateUser { get; set; }
     

            public string? ModifiedUser { get; set; }
       
             
    
            public string? DebitUser { get; set; }
    






        }
    }
}
