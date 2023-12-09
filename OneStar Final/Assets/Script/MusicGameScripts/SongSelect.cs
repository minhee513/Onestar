using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SongSelect : MonoBehaviour
{
    public void Song1()
    {
        SceneManager.LoadScene("Music2");
    }
    public void Song2()
    {
        SceneManager.LoadScene("Music1");
    }
}
