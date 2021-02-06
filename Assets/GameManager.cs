using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
public class GameManager : MonoBehaviour
{
public float health;
public int golds ; 
public Text goldsText;
public Text healthPlayer;
public AudioClip punch;
public AudioClip Hit;
private AudioSource source; 


    void Start()
    {
       golds = 100;
       goldsText.text= golds.ToString();
       
       health = 5;
       healthPlayer.text = health.ToString();
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
        source.clip = Hit;
        source.Play();
    }
}
