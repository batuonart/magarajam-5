using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject ghostPrefab;
    public GameObject RockPrefab;

    public SpikeController spikeController;
    public GameObject[]  Ground;
    int ghostAmount = 0;
    int initalGhost = 5;
    int waveNo = 1;
    // Start is called before the first frame update
    void Start()
    {
        SpawnGhosts(initalGhost);
        Ground = GameObject.FindGameObjectsWithTag("Ground");
    }

    // Update is called once per frame
    void Update()
    {
        if (ghostAmount <= 0 && spikeController.InputsActive())
        {
            SpawnGhosts(initalGhost++);
            waveNo++;
            Debug.Log(waveNo);
            if (waveNo % 5 == 0)
            {
                RockPrefab.transform.position = Ground[Random.Range(0, Ground.Length - 1)].transform.position;
                Instantiate(RockPrefab, RockPrefab.transform.position, RockPrefab.transform.rotation);
            }
        }
        
    }

    void SpawnGhosts(int amnt)
    {
		for (int i = 0; i < amnt; i++)
		{
            ghostAmount++;
            Instantiate(ghostPrefab, ghostPrefab.transform.position, ghostPrefab.transform.rotation);
		}
    }

    public void GhostDestroyed()
    {
        ghostAmount--;
    }
}
