using SpotifyExample.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyExample.Services
{
    internal class NotepadServices
    {
        public void PlaylistToNotepad(Playlist playlist)
        {
            
            string directory = $"{Directory.GetParent(Directory.GetCurrentDirectory()).Parent?.Parent?.FullName}\\Playlists";
            
          //string directory = @$"{Directory.GetParent(Directory.GetCurrentDirectory()).Parent?.Parent?.FullName}\Playlists"; @$ ve\ veya $ ve \\ aynı şeyi belirtir. 

            if (!File.Exists(directory))
            {
                Directory.CreateDirectory(directory);
           
            }
            
            string saveFile = Path.Combine(directory, $"{playlist .Id}.txt");
         
            File.WriteAllText(saveFile, playlist.GetSongs());

            Console.WriteLine("Data succesfully saved to notepad.");
        }
    }
}
