using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraExamen : MonoBehaviour
{
    public Transform personaje;
    public Vector3 offsetPosition;
    public Vector3 offsetVista;

    // Update is called once per frame
    void Update()
    {
        transform.position = personaje.position + offsetPosition;
        transform.LookAt(personaje.position + offsetVista);
    }
}
