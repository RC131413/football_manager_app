using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballClubsApp
{
    public static class Database
    {

        private static string connectionString = @"Data Source=D:\Microsoft Visual Studio\FootballClubsApp\football.db";

        public static List<Club> GetClubs()
        {
            var clubs = new List<Club>();

            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = "SELECT Id, Name, City, Stadium, FoundedDate FROM Clubs";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        clubs.Add(new Club
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            City = reader.GetString(2),
                            Stadium = reader.GetString(3),
                            FoundedDate = reader.GetString(4)
                        });
                    }
                }
            }
            return clubs;
        }

        public static Club GetClubWithPlayers(int clubId)
        {
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = @"
            SELECT Id, Name, City, Stadium, FoundedDate FROM Clubs WHERE Id = @id;
            SELECT Id, FirstName, LastName, Position, Number FROM Players WHERE ClubId = @id;
        ";
                command.Parameters.AddWithValue("@id", clubId);

                using (var reader = command.ExecuteReader())
                {
                    // Pobierz klub
                    if (!reader.Read()) return null;
                    var club = new Club
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        City = reader.GetString(2),
                        Stadium = reader.GetString(3),
                        FoundedDate = reader.GetString(4)
                    };

                    // Pobierz zawodników
                    reader.NextResult();
                    club.Players = new List<Player>();
                    while (reader.Read())
                    {
                        club.Players.Add(new Player
                        {
                            Id = reader.GetInt32(0),
                            FirstName = reader.GetString(1),
                            LastName = reader.GetString(2),
                            Position = reader.GetString(3),
                            Number = reader.GetInt32(4)
                        });
                    }

                    return club;
                }
            }
        }

        public static List<Match> GetMatches()
        {
            var matches = new List<Match>();

            // Pobierz kluby i rozgrywki do mapowania po Id
            var clubs = GetClubs();
            var competitions = GetCompetitions();

            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = @"SELECT Id, Date, HomeClubId, AwayClubId, HomeScore, AwayScore, CompetitionId FROM Matches";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int homeClubId = reader.GetInt32(2);
                        int awayClubId = reader.GetInt32(3);
                        int competitionId = reader.GetInt32(6);

                        var match = new Match
                        {
                            Id = reader.GetInt32(0),
                            Date = DateTime.Parse(reader.GetString(1)),
                            HomeClub = clubs.FirstOrDefault(c => c.Id == homeClubId),
                            AwayClub = clubs.FirstOrDefault(c => c.Id == awayClubId),
                            HomeScore = reader.IsDBNull(4) ? 0 : reader.GetInt32(4),
                            AwayScore = reader.IsDBNull(5) ? 0 : reader.GetInt32(5),
                            Competition = competitions.FirstOrDefault(c => c.Id == competitionId)
                        };
                        matches.Add(match);
                    }
                }
            }
            return matches;
        }

        public static List<Player> GetPlayers()
        {
            var players = new List<Player>();
            var clubs = GetClubs(); // Pobierz kluby do mapowania ClubId → Club

            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = "SELECT Id, FirstName, LastName, Position, Number, ClubId FROM Players";

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        players.Add(new Player
                        {
                            Id = reader.GetInt32(0),
                            FirstName = reader.GetString(1),
                            LastName = reader.GetString(2),
                            Position = reader.IsDBNull(3) ? "" : reader.GetString(3),
                            Number = reader.GetInt32(4),
                            ClubId = reader.GetInt32(5),
                            Club = clubs.FirstOrDefault(c => c.Id == reader.GetInt32(5))
                        });
                    }
                }
            }
            return players;
        }

        public static List<Competition> GetCompetitions()
        {
            var competitions = new List<Competition>();

            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = "SELECT Id, Name, Season FROM Competitions";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        competitions.Add(new Competition
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Season = reader.GetString(2)
                        });
                    }
                }
            }
            return competitions;
        }

        public static List<MatchEvent> GetMatchEvents(int matchId)
        {
            var events = new List<MatchEvent>();

            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = @"
            SELECT 
                me.Id, 
                me.Minute, 
                p.FirstName || ' ' || p.LastName AS PlayerName, 
                me.EventType,
                me.PlayerId
            FROM MatchEvents me
            INNER JOIN Players p ON me.PlayerId = p.Id
            WHERE me.MatchId = @matchId
            ORDER BY me.Minute";
                command.Parameters.AddWithValue("@matchId", matchId);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        events.Add(new MatchEvent
                        {
                            // Pobierz indeksy kolumn przez nazwy
                            Id = reader.GetInt32(reader.GetOrdinal("Id")),
                            Minute = reader.GetInt32(reader.GetOrdinal("Minute")),
                            PlayerName = reader.GetString(reader.GetOrdinal("PlayerName")),
                            EventType = reader.GetString(reader.GetOrdinal("EventType")),
                            PlayerId = reader.GetInt32(reader.GetOrdinal("PlayerId"))
                        });
                    }
                }
            }

            return events;
        }

        public static void UpdateMatchEvent(MatchEvent matchEvent)
        {
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = @"
            UPDATE MatchEvents
            SET Minute = @minute,
                PlayerId = @playerId,
                EventType = @eventType
            WHERE Id = @id";
                command.Parameters.AddWithValue("@minute", matchEvent.Minute);
                command.Parameters.AddWithValue("@playerId", matchEvent.PlayerId);
                command.Parameters.AddWithValue("@eventType", matchEvent.EventType);
                command.Parameters.AddWithValue("@id", matchEvent.Id);
                command.ExecuteNonQuery();
            }
        }


        public static void SaveMatch(Match match)
        {
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = @"INSERT INTO Matches (Date, HomeClubId, AwayClubId, HomeScore, AwayScore, CompetitionId)
                                VALUES (@date, @home, @away, @homeScore, @awayScore, @competition)";
                command.Parameters.AddWithValue("@date", match.Date.ToString("yyyy-MM-dd"));
                command.Parameters.AddWithValue("@home", match.HomeClub.Id);
                command.Parameters.AddWithValue("@away", match.AwayClub.Id);
                command.Parameters.AddWithValue("@homeScore", match.HomeScore);
                command.Parameters.AddWithValue("@awayScore", match.AwayScore);
                command.Parameters.AddWithValue("@competition", match.Competition.Id);
                command.ExecuteNonQuery();
            }
            MessageBox.Show("Mecz zapisany!");
        }
        public static void UpdateMatch(Match match)
        {
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = @"
            UPDATE Matches
            SET Date = @date,
                HomeClubId = @homeClubId,
                AwayClubId = @awayClubId,
                HomeScore = @homeScore,
                AwayScore = @awayScore,
                CompetitionId = @competitionId
            WHERE Id = @id";
                command.Parameters.AddWithValue("@date", match.Date); // DateTime
                command.Parameters.AddWithValue("@homeClubId", match.HomeClub.Id); // int
                command.Parameters.AddWithValue("@awayClubId", match.AwayClub.Id); // int
                command.Parameters.AddWithValue("@homeScore", match.HomeScore); // int
                command.Parameters.AddWithValue("@awayScore", match.AwayScore); // int
                command.Parameters.AddWithValue("@competitionId", match.Competition.Id); // int
                command.Parameters.AddWithValue("@id", match.Id); // int
                command.ExecuteNonQuery();
            }
        }


        public static void DeleteMatch(int matchId)
        {
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = "DELETE FROM Matches WHERE Id = @id";
                command.Parameters.AddWithValue("@id", matchId);
                command.ExecuteNonQuery();
            }
        }

        public static void SaveMatchEvent(int matchId, MatchEvent matchEvent)
        {
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = @"
            INSERT INTO MatchEvents (MatchId, Minute, PlayerId, EventType)
            VALUES (@matchId, @minute, @playerId, @eventType)
        ";
                command.Parameters.AddWithValue("@matchId", matchId);
                command.Parameters.AddWithValue("@minute", matchEvent.Minute);
                command.Parameters.AddWithValue("@playerId", matchEvent.PlayerId); 
                command.Parameters.AddWithValue("@eventType", matchEvent.EventType);
                command.ExecuteNonQuery();
            }
        }

        public static void DeleteMatchEvent(int eventId)
        {
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = "DELETE FROM MatchEvents WHERE Id = @id";
                command.Parameters.AddWithValue("@id", eventId);
                command.ExecuteNonQuery();
            }
        }

        public static void SavePlayer(Player player)
        {
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = @"
            INSERT INTO Players (FirstName, LastName, Position, Number, ClubId)
            VALUES (@firstName, @lastName, @position, @number, @clubId)";

                command.Parameters.AddWithValue("@firstName", player.FirstName);
                command.Parameters.AddWithValue("@lastName", player.LastName);
                command.Parameters.AddWithValue("@position", player.Position ?? "");
                command.Parameters.AddWithValue("@number", player.Number);
                command.Parameters.AddWithValue("@clubId", player.ClubId);

                command.ExecuteNonQuery();
            }
        }

        public static void UpdatePlayer(Player player)
        {
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = @"
            UPDATE Players
            SET FirstName = @firstName,
                LastName = @lastName,
                Position = @position,
                Number = @number,
                ClubId = @clubId
            WHERE Id = @id";
                command.Parameters.AddWithValue("@firstName", player.FirstName);
                command.Parameters.AddWithValue("@lastName", player.LastName);
                command.Parameters.AddWithValue("@position", player.Position ?? "");
                command.Parameters.AddWithValue("@number", player.Number);
                command.Parameters.AddWithValue("@clubId", player.ClubId);
                command.Parameters.AddWithValue("@id", player.Id);

                command.ExecuteNonQuery();
            }
        }


        public static void DeletePlayer(int playerId)
        {
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = "DELETE FROM Players WHERE Id = @id";
                command.Parameters.AddWithValue("@id", playerId);
                command.ExecuteNonQuery();
            }
        }
        public static void SaveCompetition(Competition competition)
        {
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = @"
            INSERT INTO Competitions (Name, Season)
            VALUES (@name, @season)";
                command.Parameters.AddWithValue("@name", competition.Name);
                command.Parameters.AddWithValue("@season", competition.Season);
                command.ExecuteNonQuery();
            }
        }
        public static void UpdateCompetition(Competition competition)
        {
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = @"
            UPDATE Competitions
            SET Name = @name,
                Season = @season
            WHERE Id = @id";
                command.Parameters.AddWithValue("@name", competition.Name);
                command.Parameters.AddWithValue("@season", competition.Season);
                command.Parameters.AddWithValue("@id", competition.Id);
                command.ExecuteNonQuery();
            }
        }

        public static void DeleteCompetition(int competitionId)
        {
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = "DELETE FROM Competitions WHERE Id = @id";
                command.Parameters.AddWithValue("@id", competitionId);
                command.ExecuteNonQuery();
            }
        }
        public static void SaveClub(Club club)
        {
            if (club == null)
            {
                throw new ArgumentNullException(nameof(club), "Obiekt klubu nie może być null!");
            }

            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = @"
            INSERT INTO Clubs (Name, City, Stadium, FoundedDate)
            VALUES (@name, @city, @stadium, @foundedDate)";

                command.Parameters.AddWithValue("@name", club.Name ?? "");
                command.Parameters.AddWithValue("@city", club.City ?? "");
                command.Parameters.AddWithValue("@stadium", club.Stadium ?? "");
                command.Parameters.AddWithValue("@foundedDate", club.FoundedDate ?? "");

                command.ExecuteNonQuery();
            }
        }

        public static void UpdateClub(Club club)
        {
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = @"
            UPDATE Clubs
            SET Name = @name,
                City = @city,
                Stadium = @stadium,
                FoundedDate = @foundedDate
            WHERE Id = @id";
                command.Parameters.AddWithValue("@name", club.Name);
                command.Parameters.AddWithValue("@city", club.City);
                command.Parameters.AddWithValue("@stadium", club.Stadium);
                command.Parameters.AddWithValue("@foundedDate", club.FoundedDate);
                command.Parameters.AddWithValue("@id", club.Id);
                command.ExecuteNonQuery();
            }
        }

        public static void DeleteClub(int clubId)
        {
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = "DELETE FROM Clubs WHERE Id = @id";
                command.Parameters.AddWithValue("@id", clubId);
                command.ExecuteNonQuery();
            }
        }
        public static int GetMatchesCount()
        {
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = "SELECT COUNT(*) FROM Matches";
                return Convert.ToInt32(command.ExecuteScalar());
            }
        }

        public static int GetClubsCount()
        {
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = "SELECT COUNT(*) FROM Clubs";
                return Convert.ToInt32(command.ExecuteScalar());
            }
        }

        public static int GetCompetitionsCount()
        {
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = "SELECT COUNT(*) FROM Competitions";
                return Convert.ToInt32(command.ExecuteScalar());
            }
        }

        public static void SeedDatabase()
        {
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();

                // Sprawdź, czy baza jest już wypełniona
                var checkClubs = connection.CreateCommand();
                checkClubs.CommandText = "SELECT COUNT(*) FROM Clubs";
                long clubsCount = (long)checkClubs.ExecuteScalar();

                if (clubsCount == 0)
                {
                    // 1. Dodaj kluby
                    var insertClubs = connection.CreateCommand();
                    insertClubs.CommandText = @"
                INSERT INTO Clubs (Name, City, Stadium, FoundedDate) VALUES 
                ('FC Przykład', 'Warszawa', 'Stadion Narodowy', '1920-05-01'),
                ('KS Test', 'Kraków', 'Stadion Miejski', '1945-03-15'),
                ('Lech Poznań', 'Poznań', 'Stadion Lecha', '1922-03-19'),
                ('Górnik Zabrze', 'Zabrze', 'Arena Zabrze', '1948-12-14'),
                ('Pogoń Szczecin', 'Szczecin', 'Stadion Pogoni', '1948-04-21'),
                ('Śląsk Wrocław', 'Wrocław', 'Stadion Wrocław', '1947-06-18');
            ";
                    insertClubs.ExecuteNonQuery();

                    // 2. Dodaj rozgrywki
                    var insertCompetitions = connection.CreateCommand();
                    insertCompetitions.CommandText = @"
                INSERT INTO Competitions (Name, Season) VALUES 
                ('Ekstraklasa', '2024/2025'),
                ('Puchar Polski', '2024/2025'),
                ('I Liga', '2024/2025'),
                ('Superpuchar', '2024/2025');
            ";
                    insertCompetitions.ExecuteNonQuery();

                    // 3. Dodaj zawodników
                    var insertPlayers = connection.CreateCommand();
                    insertPlayers.CommandText = @"
                INSERT INTO Players (FirstName, LastName, Position, Number, ClubId) VALUES 
                ('Jan', 'Kowalski', 'Obrońca', 5, 1),
                ('Adam', 'Nowak', 'Napastnik', 9, 1),
                ('Piotr', 'Zieliński', 'Pomocnik', 8, 2),
                ('Marcin', 'Lewandowski', 'Bramkarz', 1, 2),
                ('Kamil', 'Kamiński', 'Obrońca', 4, 3),
                ('Paweł', 'Bąk', 'Napastnik', 11, 3),
                ('Tomasz', 'Szczęsny', 'Pomocnik', 7, 4),
                ('Marek', 'Nowicki', 'Bramkarz', 12, 4),
                ('Michał', 'Kowalczyk', 'Obrońca', 3, 5),
                ('Grzegorz', 'Lis', 'Napastnik', 10, 5),
                ('Rafał', 'Wójcik', 'Pomocnik', 6, 6),
                ('Łukasz', 'Kaczmarek', 'Bramkarz', 13, 6);
            ";
                    insertPlayers.ExecuteNonQuery();

                    // 4. Dodaj mecze
                    var insertMatches = connection.CreateCommand();
                    insertMatches.CommandText = @"
                INSERT INTO Matches (Date, HomeClubId, AwayClubId, HomeScore, AwayScore, CompetitionId) VALUES 
                ('2024-05-10', 1, 2, 2, 1, 1),
                ('2024-05-17', 3, 4, 1, 1, 2),
                ('2024-05-24', 5, 6, 3, 2, 3);
            ";
                    insertMatches.ExecuteNonQuery();

                    // 5. Dodaj zdarzenia meczowe
                    var insertMatchEvents = connection.CreateCommand();
                    insertMatchEvents.CommandText = @"
                INSERT INTO MatchEvents (MatchId, Minute, PlayerId, EventType) VALUES 
                (1, 15, 2, 'Gol'),
                (1, 42, 3, 'Żółta kartka'),
                (1, 70, 1, 'Gol'),
                (2, 23, 6, 'Gol'),
                (2, 55, 7, 'Czerwona kartka'),
                (2, 8, 5, 'Gol'),
                (3, 12, 9, 'Gol'),
                (3, 44, 10, 'Gol'),
                (3, 67, 11, 'Gol'),
                (1, 13, 2, 'Faul'),
                (1, 12, 4, 'Żółta kartka');
            ";
                    insertMatchEvents.ExecuteNonQuery();
                }
            }
        }


    }
}
