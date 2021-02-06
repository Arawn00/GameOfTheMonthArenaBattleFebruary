using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public float sphereRadius;
    public float maxDistance; 

    public LayerMask layerMask;
    public GameObject currentHitObject;

private Vector3 origin; 
private Vector3 direction; 
private float currentHitDistance;
    void Start()
    {
        
    }

    void Update()
    {
        origin = transform.position;
        direction = transform.forward;
        RaycastHit hit; 
        if (Physics.SphereCast(origin,sphereRadius,direction,out hit ,maxDistance,layerMask,QueryTriggerInteraction.UseGlobal))
        {
            currentHitObject = hit.transform.gameObject;
            currentHitDistance = hit.distance;
            Debug.Log (hit);
            
             if (Input.GetButtonDown("Fire1"))
                {
                currentHitObject.GetComponent<EnnemyHealth>().EnnemyHit(gameObject);
                }
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
}
