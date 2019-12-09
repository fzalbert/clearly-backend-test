﻿using ClearlyApi.Entities;
using ClearlyApi.Enums;

namespace clearlyApi.Dto.Response
{
    public class PackageDTOResponse
    {
        public PackageDTOResponse(Package package)
        {
            Id = package.Id;

            Title = package.Title.Ru;
            Description = package.Description.Ru;

            Price = package.Price;
            Type = package.Type;
        }

        public int Id { get; set; }
        public string Title { get; set; }

        public string Description { get; set; }

        public int Price { get; set; }

        public PackageType Type { get; set; }
    }
}
