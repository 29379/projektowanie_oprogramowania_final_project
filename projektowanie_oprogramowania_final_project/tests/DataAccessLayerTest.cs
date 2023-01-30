using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Xunit;
using projektowanie_oprogramowania_final_project.Models;
using System;
using projektowanie_oprogramowania_final_project.Migrations;

namespace projektowanie_oprogramowania_final_project.tests
{
    public class DataAccessLayerTest
    { 
        [Fact]
        public async Task GetMessagesAsync_MessagesAreReturned()
        {
            using (var db = new CinemaDbContext(Utilities.TestDbContextOptions()))
            {
                // Arrange
                var expectedFilms = db.Films;
                await db.AddRangeAsync(expectedFilms);
                await db.SaveChangesAsync();

                // Act
                var result = db.Films;

                // Assert
                var actualFilms = Assert.IsAssignableFrom<List<Film>>(result);
                Assert.Equal(
                    expectedFilms.OrderBy(m => m.FilmId).Select(m => m.Title),
                    actualFilms.OrderBy(m => m.FilmId).Select(m => m.Title));
            }
        }

        [Fact]
        public async Task AddMessageAsync_MessageIsAdded()
        {
            using (var db = new CinemaDbContext(Utilities.TestDbContextOptions()))
            {
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
        }

        [Fact]
        public async Task DeleteMessageAsync_MessageIsDeleted_WhenMessageIsFound()
        {
            using (var db = new CinemaDbContext(Utilities.TestDbContextOptions()))
            {
                // Arrange
                var seedFilms = db.Films;
                await db.AddRangeAsync(seedFilms);
                await db.SaveChangesAsync();
                var recId = 1;
                var expectedFilms =
                    seedFilms.Where(film => film.FilmId != recId).ToList();

                var removedFilm =
                    seedFilms.Where(film => film.FilmId == recId).First();

                // Act
                db.Films.Remove(removedFilm);
                await db.SaveChangesAsync();


                // Assert
                var actualFilms = await db.Films.AsNoTracking().ToListAsync();
                Assert.Equal(
                    expectedFilms.OrderBy(m => m.FilmId).Select(m => m.Title),
                    actualFilms.OrderBy(m => m.FilmId).Select(m => m.Title));
            }
        }

        [Fact]
        public async Task DeleteMessageAsync_NoMessageIsDeleted_WhenMessageIsNotFound()
        {
            using (var db = new CinemaDbContext(Utilities.TestDbContextOptions()))
            {
                // Arrange
                var expectedFilms = db.Films;
                await db.AddRangeAsync(expectedFilms);
                await db.SaveChangesAsync();
                var recId = 4;

                var removedFilm =
                    expectedFilms.Where(film => film.FilmId == recId).First();

                // Act
                db.Films.Remove(removedFilm);
                await db.SaveChangesAsync();

                // Assert
                var actualMessages = await db.Films.AsNoTracking().ToListAsync();
                Assert.Equal(
                    expectedFilms.OrderBy(m => m.FilmId).Select(m => m.Title),
                actualMessages.OrderBy(m => m.FilmId).Select(m => m.Title));
            }
        }
        
    }
}
