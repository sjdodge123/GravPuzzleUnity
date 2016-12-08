using UnityEngine;
using System.Collections;

public class Level3Rules : MonoBehaviour {

    public GameObject friendBall;
    private Rigidbody2D ballBody;
	// Use this for initialization
	void Start () {
        ballBody = friendBall.GetComponent<Rigidbody2D>();
        ballBody.velocity = new Vector2(1,0);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
