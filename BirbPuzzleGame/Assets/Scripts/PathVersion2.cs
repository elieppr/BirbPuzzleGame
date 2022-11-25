using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathVersion2 : MonoBehaviour
{
    public bool canTravel;
    public DrawManager script;
    private bool firstRun = true;
    public float moveSpeed = 20f;
    private int waypointIndex = 0;
    private LineRenderer waypoints_;
    private Vector3[] waypoints;
    // Start is called before the first frame update
    void Start()
    {
        canTravel = script.canTravel;
        
        
    }
    // Update is called once per frame
    void Update()
    {
        canTravel = script.canTravel;
        if (canTravel)
        {
            if (firstRun)
            {
                waypoints_ = GetComponentInChildren<LineRenderer>(true);
                transform.position = waypoints_.GetPosition(1);
                waypoints = new Vector3[waypoints_.positionCount];
                waypoints_.GetPositions(waypoints);
                firstRun = false;
            }
            Move(moveSpeed, waypoints);
        }
    }

    private void Move(float moveSpeedway, Vector3[] waypoints)
    {
        
        
        

        if (waypointIndex < waypoints.Length)
        {
            Vector2 target = new Vector2(waypoints[waypointIndex].x, waypoints[waypointIndex].y);
            transform.position = Vector2.MoveTowards(transform.position, target, moveSpeed * Time.deltaTime);

            if (transform.position.x == waypoints[waypointIndex].x && transform.position.y == waypoints[waypointIndex].y)
            {
                waypointIndex += 1;
            }
        }
    }

}
