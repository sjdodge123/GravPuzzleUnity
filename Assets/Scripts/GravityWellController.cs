using UnityEngine;
using System.Collections;

public class GravityWellController : MonoBehaviour
{
    public float gravityRadius;
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

    //Make physics happen
    public void FixedUpdate()
    {
        Collider2D[] collisions = Physics2D.OverlapCircleAll(transform.position, gravityRadius);
        foreach (Collider2D collision in collisions)
        {
            Rigidbody2D otherbody = collision.GetComponent<Rigidbody2D>();
            if (otherbody == null || otherbody == mybody)
            {
                continue;
            }
            Vector3 distance = otherbody.transform.position - transform.position;
            if (distance.sqrMagnitude > 0)
            {
                float force = -GameVars.GravityConstant * otherbody.mass * mybody.mass / distance.sqrMagnitude;
                otherbody.AddForce(distance.normalized * force);
            }
        }
    }
}
