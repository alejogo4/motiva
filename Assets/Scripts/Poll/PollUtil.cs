using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PollUtil : MonoBehaviour
{
	PollManager PM;
    // Start is called before the first frame update
    void Start()
    {
		PM = GameObject.FindObjectOfType<PollManager>();
    }

	public void next(string letterSelected)
	{
		PM.iList.Add(letterSelected);
		Debug.Log(PM.iList);
		PM.next();

	}	
}
