﻿
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace FYP2021.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Email cannot be empty!")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Enter the correct Email format!")]
        //[Remote(action: "ListEditStudentPost", controller: "Admin")]
        public string StudEmail { get; set; }


        //[Required(ErrorMessage = "Name cannot be empty!")]
        //[RegularExpression(@"[^0-9]*", ErrorMessage = "Name Cannot contain numbers!")]
        public string StudName { get; set; }

        //[RegularExpression(@"[0-9]{8}", ErrorMessage = "Phone Number must have 9 numbers!")]
        public int StudPhNum { get; set; }

        public string CardStatus { get; set; }

        //[DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}")]
        public string CardStatusDate { get; set; }

        public string PendingDate { get; set; }

        public string ReadyapplicationDate { get; set; }

        public string CardreadyDate { get; set; }

        public string CarddispatchedDate { get; set; }

        //[Required(ErrorMessage = "Attempts cannot be empty!")]
        public int StudAttempts { get; set; }

        public string OTP { get; set; }
    }
}
