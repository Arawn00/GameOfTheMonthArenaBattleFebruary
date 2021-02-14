using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemyHealth : MonoBehaviour
{
  public float ennemyHp;
  public Rigidbody rbEnnemy;
  public float thrust;
  public GameManager gm;
  [SerializeField] private Material Ematerial;
  public float invicibilityFrame;
  public GameObject Fx_Punch; 

  void Awake ()
  {
    rbEnnemy = GetComponent<Rigidbody>();
    Ematerial = GetComponent<Renderer>().material; 
  }
  
  void Update()
  {
      if (ennemyHp<=0)
      {
      Instantiate(Fx_Punch,transform.position,Quaternion.identity);
      Destroy(gameObject);
      GameObject.Find("GameManager").GetComponent<Score>().PlayerScore(1);

      }  
  }

     public void EnnemyHit(GameObject dammageInstigator)
   {
     
      ennemyHp --;
     //rbEnnemy.AddForce(0, 0, thrust, ForceMode.Impulse); // envoit en Z seulement // 
     rbEnnemy.AddForce(dammageInstigator.transform.forward * thrust);
      //sound when hit  
      gm.SoundHit();
      // change material when hit
      InvincibilityFrame();
   }


    public void InvincibilityFrame()
      {
        Ematerial.color = Color.white;
        Invoke("InvincibilityFrameEnd", invicibilityFrame);
      }

      public void InvincibilityFrameEnd()
      {
        Ematerial.color = Color.red;
      }
}
