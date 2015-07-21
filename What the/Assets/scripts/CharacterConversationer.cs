using UnityEngine;
using System.Collections;

public class CharacterConversationer : MonoBehaviour 
{
	public Collider2D lastContactNpc;
	public string lastContactNpcName;
	public float distance;
	bool conversationOn = false;

	public bool[] informationHave;
	public bool[] personKnow;
	public bool[] itemHave;

	public GameObject informationGiver;
	private Town1NpcConversationer startConverstation;


	void Start () 
	{
		informationGiver = GameObject.Find ("Town1InformationGiver");
	}
	

	void Update () 
	{
		if(conversationOn == true)
		{
			distance = Vector2.Distance(gameObject.transform.position, lastContactNpc.transform.position);

			if(distance >= 10)
			{
				conversationOn = false;
				Debug.Log (conversationOn);
			}
		}
	}

	void OnTriggerStay2D (Collider2D other)
	{

		if(Input.GetKeyDown(KeyCode.Z))
		{
			Debug.Log ("z");
			lastContactNpc = other;
			lastContactNpcName = other.name;
			conversationOn = true;
			Debug.Log (lastContactNpc);
			Debug.Log (conversationOn);

			startConverstation = informationGiver.GetComponent<Town1NpcConversationer>();
			startConverstation.Start();

		}
	}
}
