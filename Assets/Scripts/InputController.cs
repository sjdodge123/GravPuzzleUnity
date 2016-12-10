using UnityEngine;
using System.Collections;

public class InputController : MonoBehaviour
{
    public GameObject spawnObject;
    public bool jumpToScene;
    public int levelInd;
    private CircleCollider2D spawnCollider;
    // Use this for initialization
    void Start()
    {
        spawnCollider = spawnObject.GetComponent<CircleCollider2D>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            if (LevelManager.GetCurrentLevelNumber() == 0)
            {
                if (jumpToScene)
                {
                    LevelManager.LoadLevelByIndex(levelInd);
                }
                else
                {
                    LevelManager.LoadFirstLevel();
                }
                return;
            }
            //Spawn Gravity Well
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePos.z = 1;
            if (CollidesWithSpawnObject(mousePos, spawnCollider.radius))
            {
                return;
            }
            var gravWell = Instantiate(spawnObject, mousePos, Quaternion.identity) as GameObject;
        }
        if (Input.GetMouseButtonUp(1))
        {
            LevelManager.ResetCurrentLevel();
        }
    }
    private bool CollidesWithSpawnObject(Vector3 pos,float radius)
    {
        Collider2D[] collisions = Physics2D.OverlapCircleAll(pos, radius);
        if (collisions.Length > 0)
        {
            foreach (Collider2D collision in collisions)
            {
                if (collision.gameObject.CompareTag(spawnObject.tag))
                {
                    Destroy(collision.gameObject);
                }
            }
            return true;
        }
        return false;
    }
}
