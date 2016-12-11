using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    public bool jumpToScene;
    public int startingLevel;
    
    private static GameManager instance;
	// Use this for initialization
	void Start () {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            GameObject.DontDestroyOnLoad(gameObject);
            instance = this;
        }

        if (jumpToScene)
        {
            LevelManager.SetFirstLevel(startingLevel);
        }
	}
}
