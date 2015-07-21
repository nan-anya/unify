using UnityEngine;
using System.Collections;

public class Town1NpcConversationer : MonoBehaviour 
{

	public string nameOfNpc;

	public GameObject character;
	public CharacterConversationer characterConversationer;

   	public GameObject npc;

	public void Start () 
	{
		character = GameObject.Find ("Character");
		characterConversationer = character.GetComponent<CharacterConversationer>();
		nameOfNpc = characterConversationer.lastContactNpcName;
		Conversationer ();

	}

	void Update () 
	{
	
	}

	public void Conversationer()
	{

		switch(nameOfNpc)
		{
			case "Npc1" :

			npc = GameObject.Find("Npc1");
			Npc1Conversationer dialogue1 = npc.GetComponent<Npc1Conversationer>();
			dialogue1.enabled = true;
			dialogue1.Start();
			break;

			case "Npc2" :
			npc = GameObject.Find("Npc2");
			Npc2Conversationer dialogue2 = npc.GetComponent<Npc2Conversationer>();
			dialogue2.enabled = true;
			dialogue2.Start();
			break;

			case "door1" :

			characterConversationer.transform.position = new Vector2(280,150);

			break;

			case "Npc4" :
			
			break;

			default : 

			break;
		}
	}
}
