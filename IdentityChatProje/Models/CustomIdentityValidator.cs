﻿using Microsoft.AspNetCore.Identity;

namespace IdentityChatProje.Models
{
    public class CustomIdentityValidator :IdentityErrorDescriber
    {
        public override IdentityError PasswordRequiresUpper()
        {
            return new IdentityError()
            {
                Code = "PasswordRequiresUpper",
                Description = "Lütfen en az 1 tane büyük harf girişi yapınız"
            };
        }
        public override IdentityError PasswordRequiresLower()
        {
            return new IdentityError()
            {
                Code = "PasswordRequiresLower",
                Description = "Lütfen en az 1 tane büyük harf girişi yapınız"
            };
        }
        public override IdentityError PasswordRequiresDigit()
        {
            return new IdentityError()
            {
                Code = "PasswordRequiresDigit",
                Description = "Lütfen en az 1 rakam girişi yapınız"
            };
        }
        public override IdentityError PasswordRequiresNonAlphanumeric()
        {
            return new IdentityError()
            {
                Code = "PasswordRequiresNonAlphanumeric",
                Description = "Lütfen en az 1 tane sembol girşi yapınız"
            };
        }
        public override IdentityError PasswordTooShort(int length)
        {
            return new IdentityError()
            {
                Code = "PasswordTooShort",
                Description = $"Lütfen en az {length} karakter uzunluğunda şifre girişi yapınız !"
            };
        }
    }
}
//override 
//overload