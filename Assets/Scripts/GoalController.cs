using UnityEngine;

using System.Collections;

public class GoalController : MonoBehaviour
{
    private Rigidbody2D mybody;
    // Use this for initialization
    void Start()
    {
        mybody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("FriendBall"))
        {
            ScoreBoard.CalculateScore();
            LevelManager.LoadScoreScreen();
        }
    }
}
