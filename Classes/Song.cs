
using System;

public class Song{
    private string songName;
    private string singer;
    private double length;

    public Song(){
        this.songName = "";
        this.singer = "";
        this.length = 0.0;
    }

    public Song(string songName, string singer, double length){
        this.songName = songName;
        this.singer = singer;
        this.length = length;
    }

    public Song(Song song){
        this.songName = song.GetSongName();
        this.singer = song.GetSinger();
        this.length = song.GetLength();
    }

    public string GetSongName(){ return this.songName; }
    public string GetSinger(){ return this.singer; }
    public double GetLength(){ return this.length; }

    public void SetSongName(string songName){ this.songName = songName; }
    public void SetSinger(string singer){ this.singer = singer; }
    public void SetLength(double length){ this.length = length; }
    
    public override string ToString()
    {
        return $"Song Name: {this.songName}\n" + 
        $"Singer Name: {this.singer}\n" + 
        $"Song Length: {this.length}\n";
    }
}