using UnityEngine;
using System.Collections;

public class RuleManager : MonoBehaviour
{
    public GameObject friendBall;
    internal Rigidbody2D ballBody;
    
    // Use this for initialization
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void InitializeLevel()
    {
        if (!GameManager.GetMenuLoaded())
        {
            GameManager.SetMenuLoaded(true);
            var currentLevel = LevelManager.GetCurrentLevelNumber();
            if (currentLevel != LevelManager.GetMenuSceneNum() && currentLevel != LevelManager.GetScoreScreenNum())
            {
                LevelManager.SetFirstLevel(LevelManager.GetCurrentLevelNumber());
            }
            LevelManager.LoadMainMenu();
        }
        ballBody = friendBall.GetComponent<Rigidbody2D>();
    }

    
}
        