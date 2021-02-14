 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 3;
    public int currentHealth;
    public Rigidbody rbPlayer;
    public float invicibilityFrame;
    public Text PlayerLifeText;
    public GameManager gm;
    [SerializeField] private Material Pmaterial;
        
    void Awake ()
    {
    currentHealth = maxHealth;
    rbPlayer = GetComponent<Rigidbody>();
    Pmaterial = GetComponent<Renderer>().material;
    PlayerLife();
    }

    public void LooseHealth (int dammage)
    {
            Debug.Log("LooseHP");
        if (currentHealth <=0)
        {
            DeathPlayer();
        }
        currentHealth -= dammage;
        InvincibilityFrame(); 
        PlayerLife();
        gm.SoundHit();

        
    }
    void DeathPlayer()
    {
        Debug.Log("je suis mort");
        SceneManager.LoadScene("DefeatScene");
        
    }
   

// test feedback dégats 
    public void InvincibilityFrame()
    {
    Pmaterial.color = Color.white;
    Invoke("InvincibilityFrameEnd", invicibilityFrame);
    Debug.Log("AIE");
    }

      public void InvincibilityFrameEnd()
    {
    Pmaterial.color = Color.blue;
    }
  public void PlayerLife()
    {
        PlayerLifeText.text =  currentHealth.ToString();

    }
}



