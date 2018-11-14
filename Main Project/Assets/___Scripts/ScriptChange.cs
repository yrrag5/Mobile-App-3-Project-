using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Used for changing scenes
using UnityEngine.SceneManagement;

public class ScriptChange : MonoBehaviour
{

    public void SceneChange(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
}
