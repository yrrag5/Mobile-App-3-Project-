using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	// Variables for player movement
	public float mSpeed = 200;
	public GameObject character;

	
	private Rigidbody2D characterBody;
	private float ScreenWidth;

	// Use this for initialization
	void Start () {
		ScreenWidth = Screen.width;
		characterBody = character.GetComponent<Rigidbody2D> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		int i = 0;

		while(i < Input.touchCount) {

            // Move right 
			if(Input.GetTouch (i).position.x > ScreenWidth /2){
				RunCharacter(1.0f);
			}

            // Move left 
			else if(Input.GetTouch (i).position.x < ScreenWidth /2){
				RunCharacter(-1.0f);
			}
			i++;
		}	
	}

    // Character direction
    private void RunCharacter(float HorizontalInput){
        characterBody.AddForce(new Vector2(HorizontalInput* mSpeed * Time.deltaTime, 0));
    }
}
