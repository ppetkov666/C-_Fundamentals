using System;
using System.Collections.Generic;
using System.Linq;

class StartUp
{
    static void Main()
    {
        var songs = GetSongs();
        PrintPlaylistSummary(songs);
    }

    private static void PrintPlaylistSummary(List<Song> playlist)
    {
        Console.WriteLine($"Songs added: {playlist.Count}");

        var totalSeconds = playlist.Select(s => s.Seconds).Sum();
        var secondsToMinutes = totalSeconds / 60;
        var seconds = totalSeconds % 60;

        var totalMinutes = playlist.Select(s => s.Minutes).Sum() + secondsToMinutes;
        var minutesToHours = totalMinutes / 60;
        var minutes = totalMinutes % 60;

        var hours = minutesToHours;

        Console.WriteLine($"Playlist length: {hours}h {minutes}m {seconds}s");
    }

    private static List<Song> GetSongs()
    {
        var numOfSongs = int.Parse(Console.ReadLine());
        var songs = new List<Song>(numOfSongs);

        for (int i = 0; i < numOfSongs; i++)
        {
            var songDetails = Console.ReadLine().Split(';');

            try
            {
                var indexOfMinuteSecondSeparation = songDetails[2].IndexOf(':');

                if (songDetails.Length < 3 || indexOfMinuteSecondSeparation < 1 ||
                    indexOfMinuteSecondSeparation > songDetails[2].Length - 1)
                {
                    throw new InvalidSongException();
                }

                var artist = songDetails[0];
                var songName = songDetails[1];
                var minutes = int.Parse
                    (songDetails[2].Substring(0, indexOfMinuteSecondSeparation));
                var seconds = int.Parse
                    (songDetails[2].Substring(indexOfMinuteSecondSeparation + 1));

                songs.Add(new Song(artist, songName, minutes, seconds));
                Console.WriteLine("Song added.");
            }
            catch (InvalidSongException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Invalid song length.");
            }
        }
        return songs;
    }
}

