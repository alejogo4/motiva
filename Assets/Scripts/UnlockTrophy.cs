using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnlockTrophy : PlayerPrefsX
{
    public GameObject[] Medals;
    public Text Title;
    public Text Text;

    // The current mission of the application
    private bool[] currentMission;

    // Start is called before the first frame update
    void Start()
    {

        currentMission = PlayerPrefsX.GetBoolArray("missionsAccomplished", false, 1);
        for (int i = 0; i < currentMission.Length; i++)
        {
            if (currentMission[i] == true) {
                Medals[i].GetComponent<Animator>().SetBool("firstMission", true);
            }
        }
    }

    private void showMissionFinished(GameObject Medal)
    {
        Medal.GetComponent<Animator>().SetBool("showMission", true);
        Title.text = "Hello world";
        Text.text = "Hello world 2";
    }

}
