using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    public float velocidad;
    

    private void OnTriggerEnter(Collider other)
    {
        IDamagable damagable = other.GetComponent<IDamagable>();
        if (damagable != null)
            damagable.RecibirDanio();
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {  
        transform.Translate(Vector3.forward * velocidad * Time.deltaTime);
    }
}
