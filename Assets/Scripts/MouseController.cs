using UnityEngine;
using System.Collections;

public class MouseController : MonoBehaviour
{
    public GameObject spawnObject;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            if (LevelManager.GetCurrentLevelNumber() == 0)
            {
                LevelManager.LoadFirstLevel();
                return;
            }
            //Spawn Gravity Well
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePos.z = 1;
            var gravWell = Instantiate(spawnObject, mousePos, Quaternion.identity) as GameObject;
        }
    }
}
