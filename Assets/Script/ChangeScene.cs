using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void changeSceneBtn() {
        SceneManager.LoadScene(sceneName:"Camera");
    }

    public void menuBtn() {
        SceneManager.LoadScene(sceneName:"Menu");
    }
}
