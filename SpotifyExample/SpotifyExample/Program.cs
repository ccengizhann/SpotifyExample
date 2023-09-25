
using SpotifyExample.Entities;
using SpotifyExample.Services;
using System.ComponentModel;


var song1 = new Song("Nothing Else Matters", "Metallica", "Heavy metal", 1991);
var song2 = new Song("Soldier of Fortune", "Deep Purple", "Blues rock,", 1974);
var song3 = new Song("Another Love", "Tom Odell", "Indie rock", 2013);
var song4 = new Song("Desert Rose", "Sting", " Pop", 1999);
var song5 = new Song("Nobody", "Mitski", "Alternative/Indie", 2018);

var playlist1 = new Playlist(song1);
playlist1.AddSong(song2);
playlist1.AddSong(song3);
playlist1.AddSong(song4);
playlist1.AddSong(song5);

Console.WriteLine("Before shuffle");
Console.WriteLine(playlist1.GetSongs());

playlist1.ShuffleSongs();


Console.WriteLine("\n\n After shuffle");
Console.WriteLine(playlist1.GetSongs());

NotepadServices notepadServices = new();
notepadServices.PlaylistToNotepad(playlist1);