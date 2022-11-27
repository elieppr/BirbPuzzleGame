using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RESETBUTTONSCRIPT : MonoBehaviour
{
    public void ResetScene()
    {
        Debug.Log("sdfasdf");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}