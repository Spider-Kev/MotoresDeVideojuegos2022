using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// AQUI ESTA EL EJEMPLO DEL SINGLETON Y DE LOS DELEGATE
public class MainPlayer : MonoBehaviour, IDamagable
{
    public float speed = 2f;
    public Script_HUD referenciaQueYA_NO_DEBEN_TENER;
    public static MainPlayer instance;
    public float speedRotate = 3f;
    public float salud = 100;

    public delegate void DanioRecibido(float vidaActual);
    public DanioRecibido onDanioRecibido;

    private void OnEnable()
    {
        if (instance == null)
            instance = this;
    }

    private void Awake()
    {
        instance = this;
    }

    void Update()
    {
        MoverPersonaje();
    }



    public void MoverPersonaje()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed * ManejadorInput.EjeVertical());
        
        transform.Rotate(Vector3.up * Time.deltaTime * speedRotate * ManejadorInput.EjeHorizontal());
    }

    public void RecibirDanio()
    {
        salud -= 20;
        HUD_Examen.instance.ActualizarVida(salud);

        if (salud < 0)
            HUD_Examen.instance.MostarPantallaGameOver();
    }
}



