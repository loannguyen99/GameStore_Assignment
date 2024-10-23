using System;
using GameStore.Api.Dtos;
using GameStore.Api.Endpoints;
using GameStore.Api.Entities;

namespace GameStore.Api.Mapping;

public static class GenreMapping
{
    public static GenreDto ToDto(this Gener gener)
    {
        return new GenreDto(gener.Id, gener.Name);
    }
}
