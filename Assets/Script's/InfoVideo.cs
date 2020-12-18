using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoVideo : MonoBehaviour
{
    public GameObject cargandoVideo;
    // Start is called before the first frame update
    void Start()
    {
        cargandoVideo.SetActive(false);
    }

    public void CargandoVideo()
    {
        StartCoroutine(Esperar());
    }

    IEnumerator Esperar()
    {
        cargandoVideo.SetActive(true);
        yield return new WaitForSeconds(2);
        cargandoVideo.SetActive(false);
    }
}
