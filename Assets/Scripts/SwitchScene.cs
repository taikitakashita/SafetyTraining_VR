using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour
{
    public void SwitchHomeScene()
    {
        SceneManager.LoadScene("HomeScene");
    }

    public void SwitchContentsScene1()
    {
        SceneManager.LoadScene("ContentsScene1");
    }

    public void SwitchContentsScene2()
    {
        SceneManager.LoadScene("ContentsScene2");
    }
}