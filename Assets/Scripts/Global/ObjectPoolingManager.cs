using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPoolingManager : MonoBehaviour
{
    public GameObject prefabInstanciar;
    public List<GameObject> objetosCreados;

    private void Start()
    {
        objetosCreados = new List<GameObject>();
    }

    [ContextMenu("Simular crear objeto")]
    public void CrearObjeto(Vector3 posicion, Quaternion rotation = new Quaternion())
    {
        bool hayUnObjetoInactivo = false;
        for (int i = 0; i < objetosCreados.Count; i++)
        {
            if (!objetosCreados[i].activeInHierarchy)
            {
                hayUnObjetoInactivo = true;
                objetosCreados[i].transform.position = posicion;
                objetosCreados[i].SetActive(true);
                break;
            }        
        }

        if (!hayUnObjetoInactivo)
            objetosCreados.Add(Instantiate(prefabInstanciar, posicion, rotation));
    }
}
