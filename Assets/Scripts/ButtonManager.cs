using UnityEngine;
using System.Collections;

public class ButtonManager : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnReplayPress()
    {
        LevelManager.LoadPreviousScene();
    }
    public void onNextPress()
    {
        LevelManager.LoadNextLevel();
    }
}
