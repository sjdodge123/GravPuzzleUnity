using UnityEngine;
using System.Collections;

public class RuleManager : MonoBehaviour
{
    private static bool menuLoaded = false;
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
        if (!menuLoaded)
        {
            menuLoaded = true;
            LevelManager.SetFirstLevel(LevelManager.GetCurrentLevelNumber());
            LevelManager.LoadMainMenu();
        }
    }
}
        