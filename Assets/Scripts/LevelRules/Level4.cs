using UnityEngine;
using System.Collections;

public class Level4 : RuleManager {

    public GameObject friendBall;
    private Rigidbody2D ballBody;
	// Use this for initialization
	void Start () {
        InitializeLevel();
        ballBody = friendBall.GetComponent<Rigidbody2D>();
        ballBody.velocity = new Vector2(0,1);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
