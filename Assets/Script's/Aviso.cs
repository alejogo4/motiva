using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aviso : MonoBehaviour
{

    public GameObject Carga;

    // Start is called before the first frame update
    void Start()
    {
        Carga.SetActive(false);
    }

    public void Cargando()
    {
        Carga.SetActive(true);
    }
}
