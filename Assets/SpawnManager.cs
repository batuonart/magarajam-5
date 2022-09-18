using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject ghostPrefab;
    int ghostAmount = 0;
    // Start is called before the first frame update
    void Start()
    {
        SpawnGhosts(5);
    }

    // Update is called once per frame
    void Update()
    {
        
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
