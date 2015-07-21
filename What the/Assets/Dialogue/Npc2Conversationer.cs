using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Npc2Conversationer : MonoBehaviour 
{
	private GameObject character;
	private CharacterConversationer characterConversationer;
	
	private Npc2Conversationer thisScript;
	
	public GameObject dialogueBox;
	public GameObject personName;
	public GameObject dialogue;
	
	int bottonCount = 0 ;
	
	public void Start () 
	{
		character = GameObject.Find ("Character");
		characterConversationer = character.GetComponent<CharacterConversationer>();
		
		thisScript = gameObject.GetComponent<Npc2Conversationer>();
	}
	
	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.Z)) 
		{
			bottonCount++;
		}
		
		dialogueBox.SetActive(true);

		if (characterConversationer.informationHave [0] == false && characterConversationer.informationHave [1] == false)
		{
			if (bottonCount == 1) 
			{ 
				personName.GetComponent<Text> ().text = "character";
				dialogue.GetComponent<Text> ().text = "정보를 주세요!";
			}
			
			if (bottonCount == 2) 
			{ 
				personName.GetComponent<Text> ().text = "Npc2";
				dialogue.GetComponent<Text> ().text = "정보1을 가지고 오세요!";
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

		else if (characterConversationer.informationHave [0] == true && characterConversationer.informationHave [1] == false) 
		{
			if (bottonCount == 1) 
			{ 
				Debug.Log ("Npc2Event");
				personName.GetComponent<Text> ().text = "Npc2";
				dialogue.GetComponent<Text> ().text = "정보1을 가지고오셨군요 정보2를 드리죠!";
				characterConversationer.informationHave [1] = true;
			}

			if (bottonCount == 2) 
			{ 
				personName.GetComponent<Text>().text = "";
				dialogue.GetComponent<Text>().text = "";
				bottonCount = 0;
				thisScript.enabled = false;
				dialogueBox.SetActive(false);
			}
		}
		else 
		{
			if (bottonCount == 1) 
			{ 
				personName.GetComponent<Text>().text = "Npc2";
				dialogue.GetComponent<Text>().text = "정보2는 유용한가요?";
			}
			
			if (bottonCount == 2) 
			{ 
				personName.GetComponent<Text>().text = "";
				dialogue.GetComponent<Text>().text = "";
				bottonCount = 0;
				thisScript.enabled = false;
				dialogueBox.SetActive(false);
			}
		}
	}
}