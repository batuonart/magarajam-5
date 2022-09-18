using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeMovement : MonoBehaviour
{
   
    float spikeSpeed = 5f;
    public bool moveInput = false;
    public bool shouldReturn = false;
    public bool inReset = true;
    Vector3 startPos;


	private void Start()
	{
        startPos = transform.position;
	}

	private void Update()
	{

        if (moveInput)
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
                shouldReturn = false;
                inReset = true;
			}
        }
    }

	public void MoveSpike()
    {
        inReset = false;
        moveInput = true;
    }

    public bool GetResetStatus()
    {
        return inReset;
    }

    private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.CompareTag("Rock") ||collision.gameObject.CompareTag("Spike"))
		{
            moveInput = false;
            shouldReturn = true;

        }
    }
}
