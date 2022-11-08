using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManejadorInput : MonoBehaviour
{
    public static float EjeVertical()
    {
        
        return Input.GetAxis("Vertical");

    }

    public static float EjeHorizontal()
    {
        return Input.GetAxis("Horizontal");
    }

    
}
