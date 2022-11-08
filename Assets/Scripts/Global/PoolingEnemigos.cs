using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolingEnemigos : ObjectPoolingManager
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
            yield return new WaitForSeconds(6);

            int cantidadEnemigosActivos = 0;
            for (int i = 0; i < objetosCreados.Count;i++)
            {
                if (objetosCreados[i].activeInHierarchy)
                    cantidadEnemigosActivos++;
            }

            if (cantidadEnemigosActivos<4)
                CrearObjeto(
                    new Vector3(
                        Random.Range(limiteLargo.x, limiteLargo.y)
                        , 0,
                        Random.Range(limiteAncho.x, limiteAncho.y)));
        }
    }
}
