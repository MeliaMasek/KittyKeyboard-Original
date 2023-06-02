using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(LetterManager))]

//code borrowed and modified by Warped Imagination on youtube https://www.youtube.com/watch?v=wsWeI7APjAU
public class LetterEditor : Editor
{
    private string spoiler = null;
    
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        if (Application.isPlaying)
        {
            GUILayout.Space(20f);

            if (string.IsNullOrEmpty(spoiler))
            {
                if (GUILayout.Button("Spoiler"))
                {
                    spoiler = ((LetterManager)target).GetWord();
                }
                else
                {
                    GUILayout.Label(spoiler, EditorStyles.boldLabel);
                }
            }
        }
    }
}
