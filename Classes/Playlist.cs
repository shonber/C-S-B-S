using System;

public class Playlist{
    private Song[] list;
    private Song currentSong;
    private int songsCounter;
    private double playlistTime;
    private double currentPlayTime; // Current Song stopped time
    private bool shuffle;
    private string playlistCreator;
    private Date creationDate;
}