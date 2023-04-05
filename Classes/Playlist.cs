using System;

public class Playlist{
    // Properties
    private Song[] songList;
    private Song currentSong;
    private int songsCounter;
    private double playlistTime;
    private double currentPlayTime; // Current Song stopped time
    private bool shuffle;
    private string playlistCreator;
    private string playlistName;
    private Date creationDate;


    // Methods
    // Constructors
    public Playlist(string playlistCreator, string playlistName){
        this.songList = new Song[] {};
        this.currentSong = new Song();
        this.songsCounter = 0;
        this.playlistTime = 0.0;
        this.currentPlayTime = 0.0;
        this.shuffle = false;
        this.playlistCreator = playlistCreator;
        this.creationDate = new Date();
        this.playlistName = playlistName;
    }

    public Playlist(Song[] list, string playlistCreator, string playlistName, bool shuffle = false){
        this.songList = CopyArr(list);
        this.currentSong = new Song();
        this.songsCounter = this.songList.Length;
        this.playlistTime = CalculatePlaylistTime();
        this.currentPlayTime = 0.0;
        this.shuffle = shuffle;
        this.playlistCreator = playlistCreator;
        this.creationDate = new Date();
        this.playlistName = playlistName;
    }

    public Playlist(Song[] list, string playlistCreator, string playlistName, Song currentSong, double currentTime, bool shuffle = false){
        this.songList = CopyArr(list);
        this.currentSong = new Song(currentSong);
        this.songsCounter = this.songList.Length;
        this.playlistTime = CalculatePlaylistTime();
        this.currentPlayTime = currentTime;
        this.shuffle = shuffle;
        this.playlistCreator = playlistCreator;
        this.creationDate = new Date();
        this.playlistName = playlistName;
    }

    public Playlist(Playlist playlist){
        this.songList = CopyArr(playlist.GetSongList());
        this.currentSong = new Song(playlist.GetCurrentSong());
        this.songsCounter = playlist.GetSongsCounter();
        this.playlistTime = playlist.GetPlaylistTime();
        this.currentPlayTime = playlist.GetCurrentPlayTime();
        this.shuffle = playlist.IsShuffle();
        this.playlistCreator = playlist.GetPlaylistCreator();
        this.creationDate = new Date(playlist.GetCreationDate());
        this.playlistName = playlist.GetPlaylistName();
    }

    // Getters
    public Song[] GetSongList(){ return this.songList; }
    public string GetSongListString(){
        string retVal = "[";
        int length = this.songList.Length;

        for (int i = 0; i < length; i++)
        {
            if (i == length - 1)
                retVal += $"{this.songList[i]}";
            else
                retVal += $"{this.songList[i]}, ";
        }

        return (retVal + "]"); 
    }
    public Song GetCurrentSong(){ return this.currentSong; }
    public int GetSongsCounter(){ return this.songsCounter; }
    public double GetPlaylistTime(){ return this.playlistTime; }
    public double GetCurrentPlayTime(){ return this.currentPlayTime; }
    public string GetPlaylistCreator(){ return this.playlistCreator; }
    public string GetPlaylistName(){ return this.playlistName; }
    public Date GetCreationDate(){ return this.creationDate; }

    // Setters
    public void SetCurrentPlayTime(double time){ this.currentPlayTime = time; }
    public void SetCurrentPlayTime(string name){ this.playlistName = name; }
    public void SetCurrentSong(Song song){
        foreach (Song value in this.songList)
        {
            if(value.GetSongID() == song.GetSongID()){
                this.currentSong = value;
            }
        }
    }

    // Additional methods
    public T[] CopyArr<T> (T[] arr){
        T[] newArr = new T[arr.Length];

        for (int i = 0; i < arr.Length; i++){
            newArr[i] = arr[i];
        }
        return newArr; 
    }

    public Song[] AddSong (Song song){
        Song[] newPlaylist = new Song[this.songList.Length + 1];

        for (int i = 0; i < this.songList.Length; i++){
            if (i == this.songList.Length - 1){
                newPlaylist[i] = this.songList[i];
                newPlaylist[i + 1] = new Song(song);
            }
            else
                newPlaylist[i] = this.songList[i];
        }
        return newPlaylist; 
    }

    public Song[] DeleteSong (Song song){
        Song[] newPlaylist = new Song[this.songList.Length - 1];
        int deleteSongIndex = 0, counter = 0;
        bool flag = true;

        for (int i = 0; i < this.songList.Length; i++){
            if (song.GetSongID() == this.songList[i].GetSongID()){
                deleteSongIndex = i;
                if(i == this.songList.Length - 1){
                    for (int j = 0; j < newPlaylist.Length; j++)
                    {
                        newPlaylist[j] = this.songList[j];
                        return newPlaylist;
                    }
                }else{
                    while (flag){
                        if (deleteSongIndex == counter){
                            flag = false;
                        }
                        else{
                            newPlaylist[counter] = this.songList[counter];
                            counter ++;
                        }
                    }

                    for (int j = deleteSongIndex; j < newPlaylist.Length; j++)
                    {
                        newPlaylist[j] = this.songList[j + 1];
                    }
                    return newPlaylist;
                }
            }
        }
        return this.songList;
    }

    private double CalculatePlaylistTime(){
        double time = 0.0;

        foreach (Song song in this.songList)
        {
            time += song.GetLength();
        }

        return time;
    }

    public bool IsInPlaylist(Song song){
        foreach (Song value in this.songList)
        {
            if(value.GetSongID() == song.GetSongID()){
                return true;
            }
        }

        return false;
    }

    public bool IsShuffle(){ return (this.shuffle == true); }

    // ToString() method override
    public override string ToString(){
        string instance = $"Playlist: {this.playlistName}: \n" + 
        $"___________________\n" + 
        $"Made by: {this.playlistCreator}\n" +
        $"Creation Date: {this.creationDate}\n" +
        $"Playlist Total time: {this.playlistTime/60} hours\n" +
        $"Playlist Songs Amount: {this.songsCounter}\n" +
        $"Shuffle Play: {this.shuffle}\n" +
        $"Current Song: {this.currentSong.GetSongName()}\n" +
        $"Current Song Play Time: {this.currentPlayTime}\n" +
        $"Songs List: {this.GetSongListString()}\n";

        return instance;
    }
}