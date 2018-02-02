using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mini1 : BasicMove {

    private Transform player;
    private float tempoLagPosPlayer = 1f;
    private float timeLagPosPlayer = 0f;

    // Use this for initialization
    void Start () {
        player = GameObject.FindWithTag("Player").transform;
        SetDestPlayer();
    }

    void SetDestPlayer()
    {
        destination = player.position;
    }
	
	// Update is called once per frame
	void Update () {
        base.Update();
        timeLagPosPlayer += Time.deltaTime;
        if (timeLagPosPlayer > tempoLagPosPlayer)
        {
            SetDestPlayer();
            timeLagPosPlayer = 0f;
        }
	}
}
