using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : ObjectoColleccionable
{
    public Animator animator;

    HUD_Examen hud;

    private void Awake()
    {
        hud = FindObjectOfType<HUD_Examen>();
    }

    void ElPersonajeRecibioDanio()
    {
        Debug.Log("El personaje recibio daniod esde moneda");
    }

    public override void EntroEnTrigger(Collider elOtroObjetoQueEntroEnTrigger)
    {
        //animator.SetTrigger("Collect");
        hud.ActualizarPuntos();
        gameObject.SetActive(false);
        
        //MainPlayer.instance.EsteMetodoEsDeEjemplo();
        
    }
}
