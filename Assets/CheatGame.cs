using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheatGame : MonoBehaviour
{
    public void SelectScene(int index)
    {
        SceneManager.LoadScene(index);
    }
}
