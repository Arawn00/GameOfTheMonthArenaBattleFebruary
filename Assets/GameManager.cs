using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
public class GameManager : MonoBehaviour
{

public AudioClip punch;
public AudioClip dammagePlayer;
private AudioSource source; 


    void Start()
    {
       
       source = GetComponent<AudioSource>();
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SoundPunch()
    {
        source.clip = punch;
        source.Play();
        
    }
    public void SoundHit()
    {
        source.clip = dammagePlayer;
        source.Play();
    }
}
