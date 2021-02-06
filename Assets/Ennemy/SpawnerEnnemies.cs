using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerEnnemies : MonoBehaviour
{
    public GameObject ennemy;
    public int xPos;
    public int zPos;
    public int ennemyCount;

    void Start()
    {
        StartCoroutine(EnnemyDrop());
    }

  IEnumerator EnnemyDrop()
  {
      while(ennemyCount<10)
      {
          xPos = Random.Range(29,-9);
          zPos = Random.Range(27,-8);
          Instantiate(ennemy,new Vector3(xPos,1,zPos),Quaternion.identity);
          yield return new WaitForSeconds (0.1f);
          ennemyCount +=1;
      }
  }


}
