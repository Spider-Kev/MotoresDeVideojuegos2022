using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonajeDisparo : MonoBehaviour
{
    
    
    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray rayo = new Ray();
            RaycastHit choque;
            rayo.origin = transform.position;
            rayo.direction = transform.forward;
            Debug.DrawRay(rayo.origin, rayo.direction * 20);
            if (Physics.Raycast(rayo, out choque))
            {
                //choque.collider.gameObject.SetActive(false);
                
                IDamagable damagable;
                damagable = choque.collider.GetComponent<IDamagable>();
                if (damagable != null)
                    damagable.RecibirDanio();
                
            }
        }

       
    }
}
