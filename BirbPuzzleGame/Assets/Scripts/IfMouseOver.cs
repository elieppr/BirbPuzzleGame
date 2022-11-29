using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfMouseOver : MonoBehaviour
{

    public bool ifMouseOver = false;
    public bool isMouseDown = false;
    public bool isMouseUp = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ifMouseOver)
        {
            if (Input.GetMouseButtonDown(0))
            {
                isMouseDown = true;
            }
            
        }
        if (isMouseDown)
        {
            if (Input.GetMouseButtonUp(0))
            {
                isMouseUp = true;
                isMouseDown = false;
            }
        }
        if (isMouseUp)
        {
            isMouseDown = false;
            ifMouseOver = false;
        }
    }
    void OnMouseOver()
    {
        Debug.Log("over");
        ifMouseOver = true;
    }
    void OnMouseExit()
    {
        ifMouseOver = false;
    }
    //void OnGUI()
    //{
    //    Event m_Event = Event.current;

    //    if (m_Event.type == EventType.MouseUp)
    //    {
    //        ifMouseOver = false;
    //    }
    //}
}





