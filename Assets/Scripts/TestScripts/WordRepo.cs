using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

//code borrowed and modified by Warped Imagination on youtube https://www.youtube.com/watch?v=wsWeI7APjAU
//code borrowed and modified by Zigurous on youtube https://www.youtube.com/watch?v=Tbcgqz5lM38

public class WordRepo : MonoBehaviour
{
    [SerializeField] [Tooltip("Word text files")]
    
    private string[] solutionsWords;
    private string[] validWords;
    private string word;
    private void Start()
    {
        LoadData();
        SetRandomWord();
    }

    private void LoadData()
    {
        TextAsset textFile = Resources.Load("All_Words") as TextAsset;
        validWords = textFile.text.Split('\n');
        
        textFile = Resources.Load("All_Words") as TextAsset;
        solutionsWords = textFile.text.Split('\n');
    }

    private void SetRandomWord()
    { 
        word = solutionsWords[Random.Range(0, solutionsWords.Length)];
        word = word.ToUpper().Trim();
    }

    
    
    
    
    
    
    /*
    private TextAsset wordlist = null;
    
    private List<string> words = null;

    private void Awake()
    {
        words = new List<string>(wordlist.text.Split(new char[] {',', ' ', '\n', '\r' }, System.StringSplitOptions.RemoveEmptyEntries));
    }

    public string RandomWord()
    {
        return words[Random.Range(0, words.Count)];
    }

    public bool CheckWord(string word)
    {
        return words.Contains(word);
    }
    */
}
