using UnityEngine;
using System.Collections;

public class Level3 : RuleManager {

	// Use this for initialization
	void Start () {
        InitializeLevel();
        ballBody.velocity = new Vector2(1,0);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
