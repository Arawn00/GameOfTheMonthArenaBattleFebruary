using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemyAttack : MonoBehaviour
{
public float sphereRadius;
public float maxDistance; 

public LayerMask layerMask;
public GameObject currentHitObject;

private Vector3 origin; 
private Vector3 direction; 
private float currentHitDistance;

private float coolDownE; 
void Update()
{       
    coolDownE-=1;
    if (coolDownE<=0 && currentHitObject.CompareTag("Player"))
    {
        CollisionsCheck();
        currentHitObject.GetComponent<PlayerHealth>().LooseHealth(1);
         Debug.Log("My ennemy Hitting ") ; 
    }
        
    else
    {
        currentHitDistance = maxDistance;
        currentHitObject = null; 
    }
}

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Debug.DrawLine(origin,origin+direction*currentHitDistance);
        Gizmos.DrawWireSphere(origin+direction*currentHitDistance,sphereRadius);
    }

    public void CollisionsCheck ()
    {
        origin = transform.position;
        direction = transform.forward;
        RaycastHit hit; 
        if (Physics.SphereCast(origin,sphereRadius,direction,out hit ,maxDistance,layerMask,QueryTriggerInteraction.UseGlobal))
        {
            currentHitObject = hit.transform.gameObject;
            currentHitDistance = hit.distance;
             Debug.Log(currentHitObject);
        }
    }

}
