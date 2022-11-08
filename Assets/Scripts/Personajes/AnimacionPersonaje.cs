using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimacionPersonaje : MonoBehaviour
{
    public Animator animator;
    public Transform puntoAObservar;
    [Range(0,1)]
    public float pesoDeObservacion;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Entre al trigger");
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Sali del trigger");
    }

    // Start is called before the first frame update
    void Start()
    {
        pesoDeObservacion = 0;
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("Walk", Input.GetAxis("Vertical")); // GetAxis -1  0  1

        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger("Attack");
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            animator.SetLayerWeight(1, 1f);
        }
    }

    public void AnimacionPersonajeFuncion(float variable)
    {
        Debug.Log("Entro a funcion y recibi la variable: " + variable );
    }

    private void OnAnimatorIK(int layerIndex)
    {
        animator.SetLookAtWeight(pesoDeObservacion);
        animator.SetLookAtPosition(puntoAObservar.position);

        animator.SetIKPositionWeight(AvatarIKGoal.LeftFoot, pesoDeObservacion);
        animator.SetIKPosition(AvatarIKGoal.LeftFoot, puntoAObservar.position);
        
    }
}
