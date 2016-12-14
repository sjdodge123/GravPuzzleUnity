using UnityEngine;
using System.Collections;

public class InputController : MonoBehaviour
{
    public GameObject spawnObject;
    public float touchLevelResetSeconds = 3.0f;
    
    private CircleCollider2D spawnCollider;
    private bool timerActive = false;
    private float remainingTime;

    // Use this for initialization
    void Start()
    {
        spawnCollider = spawnObject.GetComponent<CircleCollider2D>();
        remainingTime = touchLevelResetSeconds;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            LeftMousePressed();
        }
        if (Input.GetMouseButtonDown(1))
        {
            RightMousePressed();
        }
        if(Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if(touch.phase == TouchPhase.Began)
            {
                StartCountDownTimer();
            }
            if (touch.phase == TouchPhase.Ended)
            {
                CancelCountDownTimer();
            }
        }
        if (timerActive)
        {
            remainingTime -= Time.deltaTime;
            if(remainingTime <= 0.0f)
            {
                CancelCountDownTimer();
                LevelManager.ResetCurrentLevel();
            }
        }

    }

    private void LeftMousePressed()
    {
        if (LevelManager.GetCurrentLevelNumber() == LevelManager.GetMenuSceneNum())
        {
            LevelManager.LoadFirstLevel();
            return;
        }
        SpawnGravityWell();
    }

    private void RightMousePressed()
    {
        LevelManager.ResetCurrentLevel();
    }

    private void SpawnGravityWell()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 1;
        if (CollidesWithSpawnObject(mousePos, spawnCollider.radius))
        {
            return;
        }
        var gravWell = Instantiate(spawnObject, mousePos, Quaternion.identity) as GameObject;
        ScoreBoard.GravityWellSpawned();
    }

    private void StartCountDownTimer()
    {
        timerActive = true;
    }

    private void CancelCountDownTimer()
    {
        if (timerActive)
        {
            timerActive = false;
            remainingTime = touchLevelResetSeconds;
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
