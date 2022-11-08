using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD_Examen : MonoBehaviour
{
    public static HUD_Examen instance;

    public Image imagenBarraVida;
    public Text textoPuntuacion;
    int puntuacion = 0;

    public Canvas gameOverPanel;

    private void Awake()
    {
        instance = this;
    }

    public void ActualizarVida(float vidaActual)
    {
        imagenBarraVida.fillAmount = vidaActual / 100;
    }

    public void ActualizarPuntos()
    {
        puntuacion++;
        textoPuntuacion.text = puntuacion.ToString();
    }

    public void MostarPantallaGameOver()
    {
        gameOverPanel.enabled = true;
    }
}
