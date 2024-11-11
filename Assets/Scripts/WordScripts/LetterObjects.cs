using UnityEngine;

//Code borrowed and modified from https://github.com/anthonyromrell/ArtisanDream.Experimental/tree/master/Words

[CreateAssetMenu(menuName = "Words/Letter")]
public class LetterObjects : ScriptableObject
{
    public Sprite letterSprite;
    public NameId id;
    //public AiPatrol patrol;
}