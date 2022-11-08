using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolingMonedas : ObjectPoolingManager
{
    public Vector2 limiteLargo;
    public Vector2 limiteAncho;

    private void Start()
    {
        StartCoroutine(RoutineCrearMoneda());
    }

    IEnumerator RoutineCrearMoneda()
    {
        while (true)
        {
            yield return new WaitForSeconds(4);
            CrearObjeto(
                new Vector3(
                    Random.Range(limiteLargo.x, limiteLargo.y)
                    ,0,
                    Random.Range(limiteAncho.x,limiteAncho.y) ));
        }
    }
}
