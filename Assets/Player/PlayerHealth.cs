 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth;
    public int currentHealth;
    public  Slider slider ;
    


    public void SetMaxHealth()
    {
        slider.maxValue = maxHealth;
        slider.value = maxHealth ;  

    }
public void SetHealth (int maxHealth)
{
    slider.value=maxHealth;
}
}
