using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMove : MonoBehaviour {

    protected Vector3 direction;
    protected Vector3 destination;
    protected float distanceToDestination;

    public float speed = 0.5f;
    public float angularSpeed = 0.02f;
    public bool debug = true;

    protected void Update()
    {
        goToDirection();
    }

    void goToDirection()
    {
        distanceToDestination = (destination - transform.position).magnitude;
        direction = (destination - transform.position).normalized;
        Quaternion rotDirection = Quaternion.LookRotation(direction, Vector3.up);
        float angleToDirection = Quaternion.Angle(transform.rotation, rotDirection);

        //On le fait tourner
        transform.rotation = Quaternion.RotateTowards(transform.rotation, rotDirection, 360 * angularSpeed * Time.deltaTime);

        if (debug)
            Debug.DrawLine(transform.position, destination);

        //On le fait avancer
        if (distanceToDestination > 0.1 && angleToDirection < 20)
            transform.position += direction * speed * Time.deltaTime;
    }
}
