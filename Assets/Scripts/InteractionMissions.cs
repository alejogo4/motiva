using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using System.IO;



[Serializable]
class MissionInformation
{
    public string[] missions;
    public string[] messages;
}

public class InteractionMissions : PlayerPrefsX
{
    public Text msgTxt;
    public Text currentObjective;
    private MissionInformation missions;
    private int currentMission;

    private bool[] missionsAccomplished;
    private List<bool> missionsList;
    // Start is called before the first frame update
    void Start()
    {
        missionsAccomplished = PlayerPrefsX.GetBoolArray("missionsAccomplished", false, 1);
        missionsList = new List<bool>(missionsAccomplished);
        currentMission = missionsAccomplished.Length - 1;
        

        TextAsset file = Resources.Load("missions") as TextAsset;
        string json = file.ToString();
        missions = JsonUtility.FromJson<MissionInformation>(json);
        currentObjective.text = missions.missions[currentMission];

    }

    public void MissionDone()
    {
        missionsList[missionsAccomplished.Length - 1] = true;
        missionsList.Add(false);
        PlayerPrefsX.SetBoolArray("missionsAccomplished", missionsList.ToArray());
    }

    public void showMissionMessage()
    {
        msgTxt.text = missions.messages[currentMission];
        MissionDone();
    }
}
