using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCMovement : MonoBehaviour
{
    public GameObject[] Ground;
    GameObject item;
    public GameObject spawnManager;
    public GameObject particle;
    float ghostSpeed = 2f;

    void Start()
    {
        spawnManager = GameObject.FindGameObjectWithTag("SpawnManager");


        Ground = GameObject.FindGameObjectsWithTag("Ground");
        item = Ground[Random.Range(0, Ground.Length - 1)];
        transform.position = Ground[Random.Range(0, Ground.Length - 1)].transform.position;
    }

    void Update()
    {
        if (transform.position != item.transform.position)
        {
            transform.position = Vector2.MoveTowards(transform.position, item.transform.position, ghostSpeed * Time.deltaTime);
        }
        else
        {
            item = Ground[Random.Range(0, Ground.Length - 1)];
        }
    }

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.CompareTag("Spike"))
		{
            spawnManager.GetComponent<SpawnManager>().GhostDestroyed();
            Instantiate(particle, transform.position, transform.rotation);
            Destroy(gameObject);
		}
	}
}