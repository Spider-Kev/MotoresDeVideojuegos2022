using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomba : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<IDamagable>()!=null)
            other.GetComponent<IDamagable>().RecibirDanio();
    }
}
