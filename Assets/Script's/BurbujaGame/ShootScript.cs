using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShootScript : MonoBehaviour
{


    Ray ray;

    public GameObject arCamera;
    public GameObject smoke;

    public int puntaje = 0;
    public Text score, score2;

    public GameObject Contenedor, Bien, Mal;

    private void Start()
    {
        Contenedor.SetActive(false);
        Bien.SetActive(false);
        Mal.SetActive(false);
    }

    /*
    //metodo de disparo//
    public void Shoot()
    {
        RaycastHit hit;

        if (Physics.Raycast(arCamera.transform.position, arCamera.transform.forward, out hit))
         {
            

             if (hit.transform.name == "Sphere (1) 1(Clone)" || hit.transform.name == "Sphere (1)(Clone)" || hit.transform.name == "Sphere (Clone)"
                 || hit.transform.name == "Sphere 1(Clone)" || hit.transform.name == "Sphere(1)" || hit.transform.name == "Sphere")
             {
                 //Debug.Log("Shoot");
                 Destroy(hit.transform.gameObject);

                 Instantiate(smoke, hit.point, Quaternion.LookRotation(hit.normal));

                 puntaje = puntaje + 1;

                 score.text = puntaje.ToString();
                 score2.text ="Puntuacion: "+ puntaje.ToString();
             }
         }
    }
    //metodo de disparo//
    */

    void Update()
    {
        RaycastHit hit;


        ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log("mi esfera es: " + " " + hit.transform.name);
                if (hit.transform.name == "Sphere (1) 1(Clone)" || hit.transform.name == "Sphere (1)(Clone)" || hit.transform.name == "Sphere(1) 1(Clone)"
                    || hit.transform.name == "Sphere (1) 2(Clone)")
                {
                    //Debug.Log("Shoot");
                    

                    Instantiate(smoke, hit.point, Quaternion.LookRotation(hit.normal));

                    Destroy(hit.transform.gameObject);
                    puntaje = puntaje + 1;

                    score.text = puntaje.ToString();
                    score2.text = "Puntuacion: " + puntaje.ToString();


                    SfxManager.sfxInstance.Audio.PlayOneShot(SfxManager.sfxInstance.Correcto);
                    Contenedor.SetActive(true);
                    Bien.SetActive(true);
                    Mal.SetActive(false);

                }
                if (hit.transform.name == "Sphere(Clone)" || hit.transform.name == "Sphere 1(Clone)" || hit.transform.name == "Sphere(1)" || hit.transform.name == "Sphere 2(Clone)" 
                    || hit.transform.name == "Sphere 3(Clone)")
                {
                    //Debug.Log("Shoot");
                   

                    Instantiate(smoke, hit.point, Quaternion.LookRotation(hit.normal));

                    Destroy(hit.transform.gameObject);
                    if (puntaje > 0)
                    {
                        puntaje = puntaje - 1;
                    }
                    else
                    {
                        puntaje = 0;
                    }
                    

                    score.text = puntaje.ToString();
                    score2.text = "Puntuacion: " + puntaje.ToString();

                    SfxManager.sfxInstance.Audio.PlayOneShot(SfxManager.sfxInstance.incorrecto);
                    Contenedor.SetActive(true);
                    Bien.SetActive(false);
                    Mal.SetActive(true);
                }
            }
        }
        
    }
    public void ResetPuntos()
    {
        puntaje = 0;
        score.text = puntaje.ToString();
        score2.text = "Puntuacion: " + puntaje.ToString();
        
    }

    public void resume()
    {
        Time.timeScale = 1f;
    }

    public void Pause()
    {
        Time.timeScale = 0f;

    }
    


}
