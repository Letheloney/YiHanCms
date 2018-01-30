﻿using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;

namespace YiHan.Cms.Authorization.Users.Profile.Dto
{
    public class UpdateProfilePictureInput
    {
        [Required]
        [MaxLength(400)]
        public string FileName { get; set; }

        public int X { get; set; }

        public int Y { get; set; }

        public int Width { get; set; }

        public int Height { get; set; }
    }
}