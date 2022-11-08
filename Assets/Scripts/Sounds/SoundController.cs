using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

[RequireComponent(typeof(AudioSource))]
public class SoundController : MonoBehaviour
{
    public AudioClip[] clipSonido;
    public AudioSource audioSource;

    public float volumenMusica;
    public AudioMixer mixer;

  

    private void OnDisable()
    {
        MainPlayer.instance.onDanioRecibido -= FuncionAEjecutar;        
    }

    private void FuncionAEjecutar(float p)
    {
        Debug.Log("El personaje recibio danio desde Sound Controller");
        ReproducirSonido(0);
    }

    // Start is called before the first frame update
    void Start()
    {
        volumenMusica = 0;
        audioSource = GetComponent<AudioSource>();
        MainPlayer.instance.onDanioRecibido += FuncionAEjecutar;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ReproducirSonido(0);
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
            SubirVolumen();
    }

    public void ReproducirSonido(int indiceDeClips)
    {
        audioSource.PlayOneShot(clipSonido[indiceDeClips]);
    }

    public void SubirVolumen()
    {
        volumenMusica += 5;
        mixer.SetFloat("VolumenMusica",volumenMusica);
    }

    public void AsignarVolumen(float numero)
    {
        mixer.SetFloat("VolumenMusica", numero);
        //Debug.Log("Estoy cambiando el volumen a "+ numero);
    }
}
