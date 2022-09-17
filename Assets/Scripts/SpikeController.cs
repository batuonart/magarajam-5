using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeController : MonoBehaviour
{
    public GameObject[] upSpikes;
    public GameObject[] downSpikes;
    public GameObject[] rightSpikes;
    public GameObject[] leftSpikes;



    void MoveAll(GameObject[] spikes)
    {
        foreach (var spike in spikes)
        {
            spike.GetComponent<SpikeMovement>().MoveSpike();
        }
    }

    // Update is called once per frame
    void Update()
    {   
		if (Input.GetKey(KeyCode.W))
		{
            MoveAll(downSpikes);

        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            MoveAll(upSpikes);

        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            MoveAll(rightSpikes);

        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            MoveAll(leftSpikes);
        }
    }
}
