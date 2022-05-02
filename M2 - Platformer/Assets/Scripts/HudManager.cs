using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HudManager : MonoBehaviour {

    // score text label
    public Text scoreLabel;

	// Use this for initialization
	void Start () {
        // start with the correct score
        ResetHud();
    }

    // Show up to date stats of the player
    public void ResetHud()
    {
        scoreLabel.text = "Score: " + GameManager.instance.score.ToString();
        // Bug 5 Found, reference was missing here to score variable located within GameManager 
        // Added and pulled in as string to display on HUD 
        
    }
	
	
}
