using UnityEngine;
using System.Collections;

public class GUIInformationShower : MonoBehaviour 
{
	GameObject character;
	CharacterConversationer characterInformation;

	void Update() 
	{
		character = GameObject.Find ("Character");
		characterInformation = character.GetComponent<CharacterConversationer>();
		
		for (int n = 0;n<=19;n++) 
		{
			if (characterInformation.informationHave [n] == true) 
			{	
				string informationN = "information"+" "+ n ;
				Transform infobool = gameObject.transform.FindChild (informationN);
				infobool.gameObject.SetActive (true);
			}
		}
	}
}
