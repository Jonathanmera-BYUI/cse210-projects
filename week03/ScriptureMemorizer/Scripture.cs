using System.Collections.Generic;

class Scripture 
{
private Reference _reference;
private List<Word> _words;

public Scripture(Reference reference, string text)
{
  _reference = reference; 
  _words = new List<Word>();

 string[] parts = text.Split(" ");

    foreach (string wordText in parts)
    {
        Word word = new Word(wordText);

        _words.Add(word);

    }
    
}

 public string GetDisplayText()
    {
        string displayText = _reference.GetDisplayText();

        foreach (Word word in _words)
        {
            displayText += " " + word.GetDisplayText();
        }

        return displayText.Trim();
    }
   public bool IsCompletelyHidden()
{
    foreach (Word word in _words)
    {
        if (!word.IsHidden())
        {
            return false;
        }
    }

    return true;
}
public void HideRandomWords()
{
    Random random = new Random();

    List<Word> visibleWords = new List<Word>();

    foreach (Word word in _words)
    {
        if (!word.IsHidden())
        {
            visibleWords.Add(word);
        }
    }

    if (visibleWords.Count == 0)
        return;

    int index = random.Next(visibleWords.Count);
    visibleWords[index].Hide();
}

}