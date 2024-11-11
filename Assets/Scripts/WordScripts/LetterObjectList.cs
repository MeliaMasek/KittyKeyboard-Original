using UnityEngine;

//Code borrowed and modified from https://github.com/anthonyromrell/ArtisanDream.Experimental/tree/master/Words

[CreateAssetMenu(menuName = "Words/Letter Objects List")]
public class LetterObjectList : ScriptableObject
{
    public LetterObjects[] letter;
}