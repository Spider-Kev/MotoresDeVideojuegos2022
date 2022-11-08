using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public string jsonEjemplo;   
    public ClaseOleadasEnemigos oleadas;
    public Settings configuraciones;

    [ContextMenu("Convertir a JSON")]
    public void ConvertirAJSON()
    {
        Debug.Log(JsonUtility.ToJson(oleadas, true));
    }

    [ContextMenu("Convertir desde JSON")]
    public void ConvertirDesdeJSON()
    {
        oleadas = JsonUtility.FromJson<ClaseOleadasEnemigos>(jsonEjemplo);
    }

    [ContextMenu("Crear oleada")]
    public void CrearOleada()
    {
        for (int i = 0; i < oleadas.referencia.Length;i++)
        {
            for (int j = 0; j < oleadas.referencia[i].cantidadEnemigo; j++)
                Instantiate(oleadas.referencia[i].prefabEnemigo);
        }

    }

    [ContextMenu("Guardar settings")]
    public void GuardarSettings()
    {

        string rutaArchivo = Path.Combine(Application.persistentDataPath, "settings");
        File.WriteAllText(rutaArchivo, JsonUtility.ToJson(configuraciones, true));
        Debug.Log(rutaArchivo);

    }

    [ContextMenu("Leer configuraciones")]
    public void LeerSettings()
    {
        string rutaArchivo = Path.Combine(Application.persistentDataPath, "settings");

        configuraciones = JsonUtility.FromJson<Settings>(File.ReadAllText(rutaArchivo));
    }
}



[System.Serializable]
public class ClaseOleadasEnemigos
{
    public EnemigoPorOleada[] referencia;
}

[System.Serializable]
public class EnemigoPorOleada
{
    public int cantidadEnemigo;
    public float vidaPorEnemigo;
    public GameObject prefabEnemigo;
}

[System.Serializable]
public class Settings
{
    public string userName;
    public float volumenAudio;
    public int nivelActual;
    public float brillo;
}