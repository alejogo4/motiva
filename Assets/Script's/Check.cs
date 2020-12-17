using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Check : MonoBehaviour
{
    private int firstTime, Net = 0;

    public GameObject panelFristTime, panelTieneRed, panelEncuesta ,panelCompleto, PanelComoJugar;

    void Start()
    {
       panelTieneRed.SetActive(false);
        PanelComoJugar.SetActive(false);
       panelEncuesta.SetActive(true);

        firstTime = PlayerPrefs.GetInt("valor", firstTime);
        ConfFirsTime();

    }

    // Update is called once per frame
    void Update()
    {
        if (firstTime == 1)
        {
            panelFristTime.SetActive(false);
        }
        else if (firstTime == 0)
        {
            panelFristTime.SetActive(true);
        }
    }

    public void ConfFirsTime()
    {
        if (firstTime == 1)
        {
            panelFristTime.SetActive(false);
            panelEncuesta.SetActive(false);
        }
    }

    public void FirstTimeY()
    {
        if (firstTime == 0)
        {
            firstTime = 1;
            PlayerPrefs.SetInt("valor", firstTime);
            panelFristTime.SetActive(false);
            panelEncuesta.SetActive(false);
            //panelTieneRed.SetActive(true);
        }       
              
    }
    public void ComoJugar()
    {
        PanelComoJugar.SetActive(true);
    }

    public void QuitComoJugar()
    {
        PanelComoJugar.SetActive(false);
    }


    public void FirstTimeN()
    {
        firstTime = 0;
        PlayerPrefs.SetInt("valor", firstTime);
    }

    public void NetY()
    {
        if (Net == 0)
        {
            Net = 1;
            //PlayerPrefs.SetInt("valor", firstTime);
            panelTieneRed.SetActive(false);
            panelCompleto.SetActive(false);
            panelEncuesta.SetActive(true);
        }

    }
    public void NetN()
    {
        Net = 0;
        //PlayerPrefs.SetInt("valor", firstTime);
        panelTieneRed.SetActive(false);
        panelCompleto.SetActive(false);
        panelEncuesta.SetActive(false);

    }
}
