using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PollManager : MonoBehaviour
{

	public string[] questions;
	public Text question;
	public GameObject[] answers;
	public List<string> iList = new List<string>();
	private int question_index  = 0;
	public GameObject PanelPoll;
	public GameObject Convergete;
	public GameObject Asimilador;
	public GameObject Acomodador;
	public GameObject Divergente;
	public GameObject ContinueBtn;

	// Start is called before the first frame update
	void Start()
    {
		if (questions[question_index] != null)
		{
			answers[question_index].SetActive(true);
			question.text = questions[question_index];
		}
    }


	public void next()
	{
		question_index++;
		
		if (question_index >= questions.Length)
		{
			Debug.Log(iList[0]);
			PanelPoll.SetActive(false);
			if(iList[0] == "A" && iList[1] == "A")
			{
				Convergete.SetActive(true);
			}else if(iList[0] == "A" && iList[1] == "B")
			{
				Asimilador.SetActive(true);
			}
			else if (iList[0] == "B" && iList[1] == "A")
			{
				Acomodador.SetActive(true);
			}
			else
			{
				Divergente.SetActive(true);
			}

			ContinueBtn.SetActive(true);
		}
		else
		{
			answers[question_index].SetActive(true);
			question.text = questions[question_index];
		}
	}
}
