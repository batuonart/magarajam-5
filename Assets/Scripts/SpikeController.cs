using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeController : MonoBehaviour
{
    GameObject[] allSpikes;
    public GameObject[] upSpikes;
    public GameObject[] downSpikes;
    public GameObject[] rightSpikes;
    public GameObject[] leftSpikes;

    public int resettedSpikes = 0;

    public bool InputsActive()
    {
		foreach (var item in upSpikes)
		{
            if (!item.GetComponent<SpikeMovement>().GetResetStatus())
            {
                return false;
            }
        }
        foreach (var item in downSpikes)
        {
            if (!item.GetComponent<SpikeMovement>().GetResetStatus())
            {
                return false;
            }
        }
        foreach (var item in rightSpikes)
        {
            if (!item.GetComponent<SpikeMovement>().GetResetStatus())
            {
                return false;
            }
        }
        foreach (var item in leftSpikes)
        {
            if (!item.GetComponent<SpikeMovement>().GetResetStatus())
            {
                return false;
            }
        }
        return true;
    }

	void MoveAll(GameObject[] spikes)
    {
            foreach (var spike in spikes)
            {
                if (spike.GetComponent<SpikeMovement>().GetResetStatus())
                {
                    resettedSpikes++;
                }
            }

            if (resettedSpikes > 4 && InputsActive())
            {
                resettedSpikes = 0;
                foreach (var spike in spikes)
                {
                    spike.GetComponent<SpikeMovement>().MoveSpike();
                }
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
