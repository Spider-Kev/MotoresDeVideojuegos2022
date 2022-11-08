using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoExamen : MonoBehaviour, IDamagableExam
{
    public float velocidad;
    public float velocidadGiro;

    public float vida = 100;

    // Update is called once per frame
    void Update()
    {

        if (vida <= 0)
            return;
        // GetAxis Vertical
        // S     -1
        // nada   0
        // w      1
        //transform.Translate(transform.forward * Time.deltaTime * velocidad * Input.GetAxis("Vertical"));
        //transform.Rotate(Vector3.right * velocidadGiro * Input.GetAxis("Horizontal"));

        Vector3 vectorMovimiento = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        // 0 , 0 , 1
        // 0 , 0 , -1
        // 1 , 0 , 1
        Debug.DrawRay(transform.position, vectorMovimiento * 5);
        transform.position += vectorMovimiento;
        transform.LookAt(transform.position + vectorMovimiento);
    }

    public void RecibirDanio()
    {
        vida -= 20;
    }
}


public interface IDamagableExam
{
    void RecibirDanio();
}