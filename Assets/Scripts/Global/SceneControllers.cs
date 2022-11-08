using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneControllers : MonoBehaviour
{
    public Image progressBar;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void CargarNivel()
    {
        StartCoroutine(RoutineCargaNivel());
    }

    IEnumerator RoutineCargaNivel()
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(0,LoadSceneMode.Additive); 
        while (!operation.isDone)
        {
            progressBar.fillAmount = operation.progress;
            yield return new WaitForEndOfFrame();
        }

        
    }
}


