using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemigoIA : MonoBehaviour
{
    
    public NavMeshAgent agenteNavegacion;
    public Transform[] puntosASeguir;
    public Transform puntoASeguir;
    public Camera mainCamera;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Ray rayo = mainCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit choque;
            if (Physics.Raycast(rayo, out choque))
            {
                Debug.LogError("El objeto con el que colisiono es: "
                    + choque.collider + " en el punto: " + choque.point);
                Debug.DrawRay(rayo.origin, rayo.direction*20, Color.red);

                
                SeguirPunto(choque.point);
            }
        }

        NavMeshHit choqueNavMesh;
        Debug.Log("El objeto esta cerca de un area de navegacion: " + NavMesh.SamplePosition(puntoASeguir.position, out choqueNavMesh, 1f, 1));
        
            //SeguirPunto();
    }

    /// <summary>
    /// Este metodo sigue el transform "punto A Seguir"
    /// </summary>
    public void SeguirPunto()
    {
        agenteNavegacion.SetDestination(puntoASeguir.position);
    }

    /// <summary>
    /// Este metodo sigue un vector3 que yo defina
    /// </summary>
    /// <param name="Este es el punto a seguir en el espacio"></param>
    public void SeguirPunto(Vector3 posicionASeguir)
    {
        agenteNavegacion.SetDestination(posicionASeguir);
    }
}
