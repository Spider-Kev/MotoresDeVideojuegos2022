using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Personaje : MonoBehaviour, IDamagable
{
    public float vida = 100;
    public float speed = 2f;
    
    public Gradient gradienteColor;
    public Image imageBar; 

    private void Start()
    {

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            StopAllCoroutines();
    }

    public virtual void MoverPersonaje()
    {

    }

    public void RecibirDanio()
    {
        StartCoroutine(RutinaRecibirDanio(vida, vida-0.1f ));
           
    }


    IEnumerator RutinaRecibirDanio(float valorInicial, float valorFinal)
    {
        
        float tiempoTranscurrido = 0;

        while (tiempoTranscurrido<3)
        {
            vida = Mathf.Lerp(valorInicial, valorFinal, tiempoTranscurrido / 3);
            imageBar.fillAmount = vida;
            imageBar.color = gradienteColor.Evaluate(1 - vida);
            tiempoTranscurrido += Time.deltaTime;
            
            yield return new WaitForEndOfFrame();
        }
        
    }
}




