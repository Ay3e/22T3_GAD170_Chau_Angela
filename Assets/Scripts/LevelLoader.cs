using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace AngelaChau { }

public class LevelLoader : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            Loadlevel("WeekTwoActivities");
        }
    }
    /// <summary>
    /// This will load a different scene.
    /// </summary>
    public void Loadlevel(string sceneToLoad)
    {
        SceneManager.LoadScene(sceneToLoad);
    }

}
