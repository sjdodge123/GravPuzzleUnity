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
        Rigidbody2D otherbody = collision.GetComponent<Rigidbody2D>();
        if (otherbody == null || otherbody == mybody)
        {
            return;
        }
        if (otherbody.gameObject.CompareTag("FriendBall"))
        {
            //Victory!
            Debug.Log("Victory!");
        }
    }
}
