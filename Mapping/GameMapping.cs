using Microsoft.EntityFrameworkCore;
using MyAspNetApp.Dtos;
using MyAspNetApp.Data;
using MyAspNetApp.Entities;

namespace MyAspNetApp.Mapping;

public static class GameMapping
{
    public static Game toEntity(this CreateGameDto game)
    {
        return new Game
        {
            Name = game.Name,
            GenreId = game.GenreId,
            Price = game.Price,
            ReleaseDate = game.ReleaseDate
        };
    }

    public static GameDto toDto(this Game game)
    {
        return new GameDto(
            game.Id,
            game.Name,
            game.Genre!.Name,
            game.Price,
            game.ReleaseDate
        );
    }
}
