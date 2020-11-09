using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TestLoadSceneController : MonoBehaviour
{
    public void Push_Return()
    {
        SceneManager.LoadScene("Title");
    }
}
