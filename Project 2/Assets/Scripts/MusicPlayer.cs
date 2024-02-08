using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    public SettingsController Settings;
    public AudioSource Music;
    public AudioClip MusicClip;
    // Start is called before the first frame update
    void Start()
    {
        Music.clip = MusicClip;

        if (SettingsController.IsMusicOn())
        {
            Music.loop = true;
            Music.Play();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
