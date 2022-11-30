using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawManager : MonoBehaviour
{
    public LineRenderer _renderer;
    public bool canTravel = false;
    private Camera cam;

    public const float RESOLUTION = 0.1f;
    public GameObject sprite;
    public GameObject lineObject;
    public bool isMouseOver;
    public bool isMouseUp;
    public bool isMouseDown;
    public IfMouseOver script;
    public bool canTravelBeTrue;

    // Start is called before the first frame update
    void Start()
    {
        isMouseOver = script.ifMouseOver;
        isMouseUp = script.isMouseUp;
        isMouseDown = script.isMouseDown;

        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {

        isMouseOver = script.ifMouseOver;
        isMouseUp = script.isMouseUp;
        isMouseDown = script.isMouseDown;

        if (!isMouseOver && isMouseDown) { canTravelBeTrue = true; }
        if (isMouseUp)
        {
            SetParent(sprite);
            if (_renderer.positionCount > 2) 
            {
                if (canTravelBeTrue)
                {
                    canTravel = true;
                }
                
            } else
            {
                Debug.Log("asdfasdfasdf");
                this.GetComponent<DrawManager>().enabled = false; //toggle this script to re-invoke it
                this.GetComponent<DrawManager>().enabled = true;

            

            isMouseOver = true;
            isMouseDown = true;
            }
        }

        if ((isMouseOver || isMouseDown) && !canTravel && !isMouseUp)
        {
            Vector2 mousePos = cam.ScreenToWorldPoint(Input.mousePosition);

            if (Input.GetMouseButtonDown(0)) lineObject = Instantiate(lineObject, mousePos, Quaternion.identity);

            if (Input.GetMouseButton(0)) SetPosition(mousePos);

        }

    }


    public void SetParent(GameObject newParent)
    {
        lineObject.transform.parent = newParent.transform;



    }
    public void SetPosition(Vector2 pos)
    {

        if (!CanAppend(pos)) return;

        _renderer.positionCount++;
        _renderer.SetPosition(_renderer.positionCount - 1, pos);

    }
    private bool CanAppend(Vector2 pos)
    {
        if (_renderer.positionCount == 0) return true;

        return Vector2.Distance(_renderer.GetPosition(_renderer.positionCount - 1), pos) > DrawManager.RESOLUTION;
    }
}



//private Camera cam;
//public Line line;
//private Line currentLine;
//public const float RESOLUTION = 0.1f;
//public GameObject whatisthis1;
//public GameObject lineObject;
////private IfMouseOver IfMouseOverRef;
//public bool isMouseOver;
//public bool isMouseUp;
//public IfMouseOver script;
//// Start is called before the first frame update
//void Start()
//{
//    whatisthis1 = GameObject.Find("whatisthis1");
//    lineObject = GameObject.Find("line");
//    //if (whatisthis1 == null) { Debug.Log("null"); }
//    script = GameObject.FindObjectOfType<IfMouseOver>();
//    //if (script == null) { Debug.Log("null"); }
//    isMouseOver = script.ifMouseOver;
//    Debug.Log("iadfs" + isMouseOver);

//    cam = Camera.main;
//}

//// Update is called once per frame
//void Update()
//{
//    isMouseOver = script.ifMouseOver;
//    if (isMouseOver)
//    {
//        Vector2 mousePos = cam.ScreenToWorldPoint(Input.mousePosition);

//        if (Input.GetMouseButtonDown(0)) currentLine = Instantiate(line, mousePos, Quaternion.identity);

//        if (Input.GetMouseButton(0)) currentLine.SetPosition(mousePos);
//        SetParent(whatisthis1);

//    }
//}


////Invoked when a button is pressed.
//public void SetParent(GameObject newParent)
//{
//    //Makes the GameObject "newParent" the parent of the GameObject "player".
//    lineObject.transform.parent = newParent.transform;

//    //Display the parent's name in the console.
//    Debug.Log("Player's Parent: " + lineObject.transform.parent.name);


//}
