using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Npc1Conversationer : MonoBehaviour 
{
	private GameObject character;
	private CharacterConversationer characterConversationer;

	private Npc1Conversationer thisScript;

	public GameObject dialogueBox;
	public GameObject personName;
	public GameObject dialogue;

	private int bottonCount = 0 ;

	public void Start () 
	{
		character = GameObject.Find ("Character");
		characterConversationer = character.GetComponent<CharacterConversationer>();

		thisScript = gameObject.GetComponent<Npc1Conversationer>();
	}

	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.Z)) 
		{
			bottonCount++;
		}

		dialogueBox.SetActive(true);

		if (bottonCount == 1) 
		{ 
			Debug.Log ("Npc1Event");
			personName.GetComponent<Text> ().text = "Character";
			dialogue.GetComponent<Text> ().text = "정보 주세요!";

		}
		if (bottonCount == 2) 
		{
			personName.GetComponent<Text>().text = "Npc1";
			dialogue.GetComponent<Text>().text = "정보1을 드리죠!";

			characterConversationer.informationHave[0] = true;
		}
		if (bottonCount == 3) 
		{
			personName.GetComponent<Text>().text = "";
			dialogue.GetComponent<Text>().text = "";
			bottonCount = 0;
			thisScript.enabled = false;
			dialogueBox.SetActive(false);
		}
	}
}
