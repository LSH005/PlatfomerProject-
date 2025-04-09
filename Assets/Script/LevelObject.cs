using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelObject : MonoBehaviour
{
    public string NextLevel;

    public void MoveToNextLevel()
    {
        SceneManager.LoadScene(NextLevel);
    }


}
