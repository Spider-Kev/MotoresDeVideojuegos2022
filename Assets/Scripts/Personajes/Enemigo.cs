using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour, IDamagable
{
    public MainPlayer personajePrincipal;
    public PoolingBalas poolingBalas;
    public Transform puntoDeSpawn;

    private void Awake()
    {
        poolingBalas = FindObjectOfType<PoolingBalas>();
        personajePrincipal = FindObjectOfType<MainPlayer>();
    }

    private void OnEnable()
    {
        StartCoroutine(RutinaCrearBala());
    }

    private void OnDisable()
    {
        StopAllCoroutines();
    }

    // Start is called before the first frame update
    void Update()
    {
        this.transform.LookAt(personajePrincipal.transform);
    }


    IEnumerator RutinaCrearBala()
    {
        while (true)
        {
            yield return new WaitForSeconds(2);
            poolingBalas.CrearObjeto(puntoDeSpawn.position, puntoDeSpawn.rotation);
            

        }
    }

    public void RecibirDanio()
    {
        gameObject.SetActive(false);
    }
}
