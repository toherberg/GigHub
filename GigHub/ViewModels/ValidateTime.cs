﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace GigHub.ViewModels
{
    public class ValidateTime : ValidationAttribute
    {



        public override bool IsValid(object value)
        {
            DateTime dateTime;
            var isValid = DateTime.TryParseExact(Convert.ToString(value), "t",
                 CultureInfo.CurrentCulture,
                 DateTimeStyles.None,
                 out dateTime);

            return isValid;
        }
    }
}
