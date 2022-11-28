using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckComplete : MonoBehaviour
{
    public GameObject[] array;
    public string tag1;
    public string tag2;
    public string tag3;
    public string tag4;
    public string tag5;
    public int numOfDone;
    public string SceneName;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        numOfDone = 0;
        array = GameObject.FindGameObjectsWithTag(tag1);
        if (array.Length == 0) numOfDone += 1;
        array = GameObject.FindGameObjectsWithTag(tag2);
        if (array.Length == 0) numOfDone += 1;
        array = GameObject.FindGameObjectsWithTag(tag3);
        if (array.Length == 0) numOfDone += 1;
        array = GameObject.FindGameObjectsWithTag(tag4);
        if (array.Length == 0) numOfDone += 1;
        array = GameObject.FindGameObjectsWithTag(tag5);
        if (array.Length == 0) numOfDone += 1;
        
        if (numOfDone == 5)
        {
            SceneManager.LoadScene(SceneName);
            Debug.Log("sdafs");
        }
    }

}
