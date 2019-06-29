using UnityEngine;

public class StartScene : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneLoader sl = new SceneLoader();
            sl.LoadNextScene();
        }
        else if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneLoader sl = new SceneLoader();
            sl.QuitGame();
        }
    }
}
