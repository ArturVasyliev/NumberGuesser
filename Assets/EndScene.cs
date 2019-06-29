using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndScene : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneLoader sl = new SceneLoader();
            sl.LoadStartScene();
        }
        else if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneLoader sl = new SceneLoader();
            sl.QuitGame();
        }
    }
}
