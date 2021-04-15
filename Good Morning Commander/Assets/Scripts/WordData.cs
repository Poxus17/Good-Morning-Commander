using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class WordData : MonoBehaviour
{
    [SerializeField]
    private Word[] words;
    public Word Get(string LinkId)
    {
        return words.FirstOrDefault(word => word.LinkId == LinkId);
    }
}
[System.Serializable]
public struct Word
{
    public string LinkId;
    public string Name;
    public string Description;
    public Sprite Sprite;
}


