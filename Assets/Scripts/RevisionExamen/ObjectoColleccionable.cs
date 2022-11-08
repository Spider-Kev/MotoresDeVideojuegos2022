using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectoColleccionable : MonoBehaviour
{
    public AudioSource fuenteAudio;
    private void Start()
    {
        fuenteAudio = this.GetComponent < AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        EntroEnTrigger(other);
        fuenteAudio.Play();
    }

    public virtual void EntroEnTrigger(Collider elOtroObjetoQueEntroEnTrigger)
    {

    }
}
