using UnityEngine;
using System.Collections;

public class SpeechPrepareCheck : MonoBehaviour 
{
	public bool[] informationHave;

	GameObject character;
	private CharacterConversationer characterInformation;

	void Start () 
	{
		character = GameObject.Find("Character");
		characterInformation = character.GetComponent<CharacterConversationer>();
	}

	void Update () 
	{

		for (int n = 0;n <= 19;n++) 
		{
			if (characterInformation.informationHave [n] == true) 
			{	
				string informationHaveN = "informationHave"+" "+ n ;
				Transform infobool = gameObject.transform.FindChild(informationHaveN);
				infobool.gameObject.SetActive (true);
			}
		}
	}
}
