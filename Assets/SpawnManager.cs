using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject ghostPrefab;
    public SpikeController spikeController;
    int ghostAmount = 0;
    int initalGhost = 5;
    int waveNo = 1;
    // Start is called before the first frame update
    void Start()
    {
        SpawnGhosts(initalGhost);
    }

    // Update is called once per frame
    void Update()
    {
        if (ghostAmount <= 0 && spikeController.InputsActive())
        {
            SpawnGhosts(initalGhost++);
            waveNo++;
            Debug.Log(waveNo);
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
