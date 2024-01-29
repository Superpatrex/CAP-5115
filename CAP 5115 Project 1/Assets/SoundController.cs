using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    public AudioClip generalAudioClip;
    public AudioSource generalAudioSource;

    public AudioClip squirelAudioClip;
    public AudioSource squirelAudioSource;

    public AudioClip raccoonAudioClip;
    public AudioSource raccoonAudioSource;

    public AudioClip foxAudioClip;
    public AudioSource foxAudioSource;

    private float randomSquirelSoundTime;
    private float randomRaccoonSoundTime;
    private float randomFoxSoundTime;

    // Start is called before the first frame update
    void Start()
    {
        generalAudioSource.clip = generalAudioClip;
        generalAudioSource.loop = true;
        generalAudioSource.Play();

        squirelAudioSource.clip = squirelAudioClip;
        raccoonAudioSource.clip = raccoonAudioClip;

        randomSquirelSoundTime = Random.Range(20, 60);
        randomRaccoonSoundTime = Random.Range(20, 60);
        randomFoxSoundTime = Random.Range(20, 60);
    }

    // Update is called once per frame
    void Update()
    {
        randomSquirelSoundTime -= Time.deltaTime;
        randomRaccoonSoundTime -= Time.deltaTime;
        randomFoxSoundTime -= Time.deltaTime;

        if (randomSquirelSoundTime <= 0)
        {
            squirelAudioSource.Play();
            randomSquirelSoundTime = Random.Range(20, 60);
        }

        if (randomRaccoonSoundTime <= 0)
        {
            raccoonAudioSource.Play();
            randomRaccoonSoundTime = Random.Range(20, 60);
        }

        if (randomFoxSoundTime <= 0)
        {
            raccoonAudioSource.Play();
            randomFoxSoundTime = Random.Range(20, 60);
        }


    }
}
