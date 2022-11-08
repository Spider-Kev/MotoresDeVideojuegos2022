using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastController : MonoBehaviour
{
    public LineRenderer lineaRender;

    Ray rayo;
    RaycastHit choque;
    public GameObject decalBala;


    private void FixedUpdate()
    {
        rayo.origin = transform.position;
        rayo.direction = transform.forward;

        if (Physics.Raycast(rayo, out choque))
        {
            lineaRender.SetPosition(0, rayo.origin);
            lineaRender.SetPosition(1, choque.point);
            Debug.DrawLine(rayo.origin, choque.point,Color.red);
            //Debug.DrawRay(rayo.origin, rayo.direction * 10);
            Debug.Log("El rayo entro en colision " + choque.collider.transform.position);
            if (Input.GetMouseButtonDown(0))
            {
                GameObject pivoteObjeto = Instantiate(decalBala, choque.point,Quaternion.identity);
                pivoteObjeto.transform.forward = -choque.normal;
            }
        }
        else
        {
            lineaRender.SetPosition(0, rayo.origin);
            lineaRender.SetPosition(1, rayo.origin + rayo.direction * 10);
            Debug.DrawRay(rayo.origin, rayo.direction * 10, Color.blue);
        }
    }
}
