using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneMngr : MonoBehaviour
{
    public void LoadGroundMode()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }

    public void LoadMidAirMode()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(2);
    }
}
