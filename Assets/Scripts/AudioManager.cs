using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource[] soundEffects;
    public static AudioManager Instance;
    public AudioSource bgMusic;

    private void Awake()
    {
        Instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlaySfx(int soundToPlay)
    {
        soundEffects[soundToPlay].Play();
    }
}
