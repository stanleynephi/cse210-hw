using System;
public class Remove{
    public List<Scriptures> scriptures = new List<Scriptures>();

    // remove random words
    public void RemoveRandomWords(List<Scriptures>verses,int num)
    {
        Random newRandom = new Random();
        for(int i = 0; i<num; i++){
            if (verses.Count > 0)
            {
                // Generate a random index
                int randomIndex = newRandom.Next(0, verses.Count);

                // Remove the word at the random index
                verses.RemoveAt(randomIndex);
            }
        }
    }
}