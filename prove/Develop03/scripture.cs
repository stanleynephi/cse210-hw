// using systems
using System;

public class Scriptures{
    // create a scripture list for scriptures
    private List<string> _refes;
    private List<string> _verses;

    public Scriptures(){
        _refes = new List<string>();
        _verses = new List<string>();

        _verses.Add("For God So Love The World That He Gave His Only Begotten Son That Who So Believes In Him Should Not Perish But Have Everlasting Life");
        _refes.Add("John 3:16");


    }

    // display the elements in the list
    public string Verse(){
        return  _refes[0] +_verses[0];
    }
    // remove words from the scripture

}