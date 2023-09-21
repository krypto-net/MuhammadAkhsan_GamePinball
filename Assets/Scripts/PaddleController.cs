using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    // Start is called before the first frame update

    public KeyCode input;
    public HingeJoint hinge;
    public float targetPressed;
    public float targetRelease;


    void Start()
    {
        hinge = GetComponent<HingeJoint>();
        targetPressed = hinge.limits.max;
        targetRelease = hinge.limits.min;
    }
    

    void Update()
    {
        ReadInput();
    }

    public void ReadInput()
    {
        JointSpring jointSpring = hinge.spring;

        if(Input.GetKey(input))
        {
            jointSpring.targetPosition = targetPressed;
        }

        else
        {
            jointSpring.targetPosition = targetRelease;
        }

        hinge.spring = jointSpring;
    }
}
