using UnityEngine;
using System.Collections;

public class CharacterMover : MonoBehaviour 
{
	public Sprite charFront ;
	public Sprite charBack ;
	public Sprite charRight ;
	public Sprite charLeft ;
	public Sprite char45 ;
	public Sprite char135 ;
	public Sprite char225 ;
	public Sprite char315 ;

	public int mod = 0;

	//0정보수집 1연설준비 2연설 3토론

	public float characterSpeed = 1;

	void Start () 
	{
	
	}
	

	void Update () 
	{
		if (mod == 0) {
			float dirX = Input.GetAxis ("Horizontal");
			float dirY = Input.GetAxis ("Vertical");

			Vector2 movement = new Vector2 (dirX, dirY);

			if (dirX > 0) {
				if (dirY > 0) {
					GetComponent<SpriteRenderer> ().sprite = char45;
				} else if (dirY < 0) {
					GetComponent<SpriteRenderer> ().sprite = char315;
				} else {
					GetComponent<SpriteRenderer> ().sprite = charRight;
				}
			} else if (dirX < 0) {
				if (dirY > 0) {
					GetComponent<SpriteRenderer> ().sprite = char135;
				} else if (dirY < 0) {
					GetComponent<SpriteRenderer> ().sprite = char225;
				} else {
					GetComponent<SpriteRenderer> ().sprite = charLeft;
				}
			} else {
				if (dirY > 0) {
					GetComponent<SpriteRenderer> ().sprite = charBack;
				} else if (dirY < 0) {
					GetComponent<SpriteRenderer> ().sprite = charFront;
				} else {
				
				}
			}

			GetComponent<Rigidbody2D> ().velocity = movement * characterSpeed;
		} 
		else if (mod == 1) 
		{

		}
	}
}
