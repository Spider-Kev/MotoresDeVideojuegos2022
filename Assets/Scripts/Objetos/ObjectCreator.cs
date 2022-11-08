using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCreator : MonoBehaviour
{
    public Transform puntoDeInstancia;
    public GameObject objetoACrear;
    public bool juegoEnEjecucion = true;

    public List<GameObject> objetosCreados;

    public int maxObjetos = 5;

    private void Start()
    {
        objetosCreados = new List<GameObject>();
        StartCoroutine(RutinaInstanciarObjeto());
    }

    

    IEnumerator RutinaInstanciarObjeto()
    {
        float tiempoTranscurrido = 0;
        while (juegoEnEjecucion)
        {
            yield return new WaitForSeconds(2);
            tiempoTranscurrido += Time.deltaTime;

            bool hayObjetosDesactivadosEnLaLista = false;

            for (int i = 0; i < objetosCreados.Count;i++)
            {
                if (!objetosCreados[i].activeInHierarchy)
                {
                    objetosCreados[i].SetActive(true);
                    hayObjetosDesactivadosEnLaLista = true;
                    break;
                }
            }

            if (!hayObjetosDesactivadosEnLaLista && objetosCreados.Count<maxObjetos)
                objetosCreados.Add(Instantiate(objetoACrear,puntoDeInstancia.position,Quaternion.identity));

            
        }
        
    }
}
