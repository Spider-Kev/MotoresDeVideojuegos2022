using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Script_HUD : MonoBehaviour
{
    public Image barraVida;

    Color colorMuestra;
    [SerializeField]
    Gradient gradient;

    private void OnEnable()
    {
        GameObject.FindObjectOfType<MainPlayer>().onDanioRecibido += ModificarBarraVida;
    }

    private void OnDisable()
    {
        GameObject.FindObjectOfType<MainPlayer>().onDanioRecibido -= ModificarBarraVida;
    }

    private void Start()
    {
        colorMuestra = new Color(1, 1, 0, 1);
    }

    public void ModificarBarraVida(float nuevoValor)
    {
        Debug.Log("Desde el HUD el personaje recibio danio");
        //barraVida.color = gradient.Evaluate(MainPlayer.instance.vida/ 100f);
        barraVida.fillAmount = nuevoValor / 100f;

    }
}
