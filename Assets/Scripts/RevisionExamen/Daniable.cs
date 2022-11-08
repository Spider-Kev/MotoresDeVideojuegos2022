using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Daniable : ObjectoColleccionable
{
    public override void EntroEnTrigger(Collider elOtroObjetoQueEntroEnTrigger)
    {
        elOtroObjetoQueEntroEnTrigger.GetComponent<IDamagableExam>().RecibirDanio();
    }
}
