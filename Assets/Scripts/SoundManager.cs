using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField] public AudioClip background;
    [SerializeField] public AudioClip enemyattack;
    [SerializeField] public AudioClip Checkpoint;
    [SerializeField] public List<AudioClip> audioClips = new List<AudioClip>();
    public static SoundManager instance;
    // Start is called before the first frame update
    void Start()
    {
        if(instance == null)
        {
            instance= this;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
