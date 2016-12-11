using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{

    public bool jumpToScene;
    public int startingLevel;
    private static bool menuLoaded = false;

    private static GameManager instance;
    // Use this for initialization
    void Start()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            GameObject.DontDestroyOnLoad(gameObject);
            instance = this;
            SetMenuLoaded(true);
        }
        if (jumpToScene)
        {
            LevelManager.SetFirstLevel(startingLevel);
        }      
    }

    public static void SetMenuLoaded(bool value)
    {
        menuLoaded = value;
    }
    public static bool GetMenuLoaded()
    {
        return menuLoaded;
    }
}
