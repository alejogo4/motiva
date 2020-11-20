using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLayGame : MonoBehaviour
{

    public GameObject Btn_Play, Ball;
    // Start is called before the first frame update
    void Start()
    {
        Btn_Play.SetActive(true);
        Ball.SetActive(false);
    }

   public void CzarGame()
    {
        Btn_Play.SetActive(false);
        Ball.SetActive(true);

    }
}
