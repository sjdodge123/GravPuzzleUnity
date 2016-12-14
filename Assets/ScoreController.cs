using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour {

    public Text levelScore;
    public Text totalScore;
	// Use this for initialization
	void Start () {

        totalScore.text = "Total: " + ScoreBoard.GetTotalScore();
        levelScore.text = "Score: " + ScoreBoard.GetCurrentScore();
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
