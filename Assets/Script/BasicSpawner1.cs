using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicSpawner1 : BasicMove {

    void setNewDestination()
    {
        destination = new Vector3(Random.Range(-10f, 10f), transform.position.y, Random.Range(-10f, 10f));
    }

    // Use this for initialization
    void Start () {
        setNewDestination();
    }
	
	// Update is called once per frame
	new void Update () {
        base.Update();
        if (distanceToDestination < 0.2)
            setNewDestination();
    }
}
