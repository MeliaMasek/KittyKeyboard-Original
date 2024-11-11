using System.Collections;
using UnityEngine;
using UnityEngine.Events;

//Code borrowed and modified from https://github.com/anthonyromrell/ArtisanDream.Experimental/tree/master/Words

public class MatchId : MonoBehaviour
{
    public NameId ID;
    public UnityEvent OnMatch, NoMatch;
    public bool MatchMade { private get; set; }

    private void OnTriggerEnter(Collider other)
    {
        var otherId = other.GetComponent<MatchId>();
        
        if (otherId.ID == ID || otherId.MatchMade)
        {
            OnMatch.Invoke();
        }
        else
        {
            NoMatch.Invoke();
        }
    }
}