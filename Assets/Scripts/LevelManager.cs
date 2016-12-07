using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LevelManager {

    //Index (in the build settings) of the main menu 
    private static int mainMenuScene = 0;

    //Total number of non-playable scenes used check for last scene
    private static int numMenuScenes = 1;

    //Index (in the build settings) of the level you would like to start at
    private static int startingLevel = 1;

    public static void GetNextLevel()
    {
        if (SceneManager.sceneCountInBuildSettings == SceneManager.GetActiveScene().buildIndex + numMenuScenes)
        {
            //TODO: Load end screen!
            LoadMainMenu();
            return;
        }
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public static void LoadFirstLevel()
    {
        SceneManager.LoadScene(startingLevel);
    }
    public static void LoadMainMenu()
    {
        SceneManager.LoadScene(mainMenuScene);
    }
    public static int GetCurrentLevelNumber()
    {
        return SceneManager.GetActiveScene().buildIndex;
    }

    public static void ResetCurrentLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
