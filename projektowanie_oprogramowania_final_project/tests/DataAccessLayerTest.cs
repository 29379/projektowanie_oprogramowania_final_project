using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Xunit;
using projektowanie_oprogramowania_final_project.Models;
using System;

namespace projektowanie_oprogramowania_final_project.tests
{
    public class DataAccessLayerTest
    { 
        [Fact]
        public async Task GetFilmsAsync_FilmsAreReturned()
        {
            using var db = new CinemaDbContext(Utilities.TestDbContextOptions());
            // Arrange
            var expectedFilms = db.Films;
            await db.AddRangeAsync(expectedFilms);
            await db.SaveChangesAsync();

            // Act
            var result = db.Films.ToList();

            // Assert
            var actualFilms = Assert.IsAssignableFrom<List<Film>>(result);
            Assert.Equal(
                expectedFilms.OrderBy(m => m.FilmId).Select(m => m.Title),
                actualFilms.OrderBy(m => m.FilmId).Select(m => m.Title));
        }

        [Fact]
        public async Task AddFilmAsync_FilmIsAdded()
        {
            using var db = new CinemaDbContext(Utilities.TestDbContextOptions());
            // Arrange
            var recId = 1000;
            var expectedMessage = new Film() { FilmId = recId, Title = "Test", Director = "Jane Doe", RunningTime = new TimeSpan(3, 0, 0) };

            // Act
            db.Films.Add(expectedMessage);
            await db.SaveChangesAsync();

            // Assert
            var actualMessage = await db.FindAsync<Film>(recId);
            Assert.Equal(expectedMessage, actualMessage);
        }

        [Fact]
        public async Task DeleteFilmAsync_FilmIsDeleted_WhenFilmIsFound()
        {
            using var db = new CinemaDbContext(Utilities.TestDbContextOptions());
            // Arrange
            var seedFilms = db.Films.ToList();
            await db.AddRangeAsync(seedFilms);
            await db.SaveChangesAsync();

            var recId = 1;
            var expectedFilms =
                seedFilms.Where(film => film.FilmId != recId).ToList();

            foreach (var elem in seedFilms)
            {
                if (elem.FilmId == recId)
                {
                    db.Films.Remove(elem);
                    await db.SaveChangesAsync();
                    break;
                }
            }

            // Assert
            var actualFilms = await db.Films.AsNoTracking().ToListAsync();
            Assert.Equal(
                expectedFilms.OrderBy(m => m.FilmId).Select(m => m.Title),
                actualFilms.OrderBy(m => m.FilmId).Select(m => m.Title));
        }

        [Fact]
        public async Task DeleteFilmAsync_NoFilmIsDeleted_WhenFilmIsNotFound()
        {
            using var db = new CinemaDbContext(Utilities.TestDbContextOptions());
            // Arrange
            var expectedFilms = db.Films;
            await db.AddRangeAsync(expectedFilms);
            await db.SaveChangesAsync();
            var recId = 999;

            foreach (var elem in db.Films.ToList())
            {
                if (elem.FilmId == recId)
                {
                    db.Films.Remove(elem);
                    await db.SaveChangesAsync();
                    break;
                }
            }

            // Assert
            var actualMessages = await db.Films.AsNoTracking().ToListAsync();
            Assert.Equal(
                expectedFilms.OrderBy(m => m.FilmId).Select(m => m.Title),
            actualMessages.OrderBy(m => m.FilmId).Select(m => m.Title));
        }

        [Fact]
        public async Task DeleteAllFilmsAsync_FilmsAreDeleted()
        {
            using var db = new CinemaDbContext(Utilities.TestDbContextOptions());
            var seedFilms = db.Films.ToList();
            await db.AddRangeAsync(seedFilms);
            await db.SaveChangesAsync();

            foreach (var elem in seedFilms)
            {
                db.Remove(elem);
                await db.SaveChangesAsync();
            }

            Assert.Empty(
                await db.Films.AsNoTracking().ToListAsync()
                );
        }
        
    }
}
