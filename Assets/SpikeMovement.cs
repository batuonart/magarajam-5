using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeMovement : MonoBehaviour
{
   
    float spikeSpeed = 5f;
    bool isCrashed = false;
    bool canMove = false;
    bool shouldReturn = false;
    Vector3 startPos;


	private void Start()
	{
        Debug.Log(startPos);
        startPos = transform.position;
	}

	private void Update()
	{

        if (canMove && !isCrashed)
		{
            transform.Translate(new Vector2(0, 1) * spikeSpeed * Time.deltaTime);
        }

		
    }

	private void FixedUpdate()
	{
        if (shouldReturn)
        {
            transform.position = Vector2.MoveTowards(transform.position, startPos, spikeSpeed * Time.deltaTime);
			if (transform.position == startPos)
			{
                isCrashed = false;
                shouldReturn = false;
			}
        }
    }

	public void MoveSpike()
    {
        canMove = true;
    }


    private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.CompareTag("Rock") ||collision.gameObject.CompareTag("Spike"))
		{
            isCrashed = true;
            canMove = false;
            shouldReturn = true;

        }
    }
}
