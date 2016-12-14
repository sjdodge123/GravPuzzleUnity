using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System;

public class LevelManager {

    //Index (in the build settings) of the main menu 
    private static int mainMenuScene = 0;

    //Index (in the build settings) of the score screen
    private static int scoreScreenScene = SceneManager.sceneCountInBuildSettings-1;

    //Total number of non-playable scenes used check for last scene
    private static int numMenuScenes = 2;

    //Index (in the build settings) of the level you would like to start at
    private static int startingLevel = 1;

    //Index of the current level. This must be updated anytime Loadscene is called.
    private static int currentLevel = 0;

    public static void LoadNextLevel()
    {
        if (SceneManager.GetActiveScene().buildIndex == scoreScreenScene && currentLevel+1 == scoreScreenScene)
        {
            //TODO: Load end screen!
            currentLevel = startingLevel;
            GameManager.SetMenuLoaded(false);
            LoadMainMenu();
            return;
        }
        currentLevel++;
        SceneManager.LoadScene(currentLevel);
    }

    public static void LoadScoreScreen()
    {
        currentLevel = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(scoreScreenScene);
    }

    public static void LoadLevelByIndex(int sceneIndex)
    {
        if (sceneIndex > mainMenuScene && sceneIndex < SceneManager.sceneCountInBuildSettings)
        {
            currentLevel = sceneIndex;
            SceneManager.LoadScene(sceneIndex);
        }
        else
        {
            Debug.LogError("Scene Index specified is out of scene range in build settings.");
        }
    }

    public static void LoadFirstLevel()
    {
        currentLevel = startingLevel;
        SceneManager.LoadScene(startingLevel);
    }

    public static void LoadMainMenu()
    {
        SceneManager.LoadScene(mainMenuScene);
        GameManager.SetMenuLoaded(true);
    }

    public static int GetCurrentLevelNumber()
    {
        return SceneManager.GetActiveScene().buildIndex;
    }

    public static void ResetCurrentLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public static void SetFirstLevel(int sceneIndex)
    {
        if (sceneIndex <= mainMenuScene || sceneIndex > SceneManager.sceneCountInBuildSettings - numMenuScenes)
        {
            Debug.LogError("Scene Index specified is out of scene range in build settings. A menu scene might be specified as well.");
            return;
        }
        startingLevel = sceneIndex;
    }

    public static void LoadPreviousScene()
    {
        SceneManager.LoadScene(currentLevel);
    }

    public static int GetMenuSceneNum()
    {
        return mainMenuScene;
    }
    public static int GetScoreScreenNum()
    {
        return scoreScreenScene;
    }

}
