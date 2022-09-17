using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform target;
    public GameObject[] Ground;
    GameObject item;
    void Start()
    {

        transform.position = target.position;
        Ground = GameObject.FindGameObjectsWithTag("Ground");

        item = Ground[Random.Range(0, Ground.Length - 1)];
        
    }

    // Update is called once per frame
    void Update()
    {
        
        

        if (transform.position != item.transform.position)
        {
            transform.position = Vector2.MoveTowards(transform.position, item.transform.position, 1f * Time.deltaTime);

        }
        else
        {
            item = Ground[Random.Range(0, Ground.Length - 1)];

        }









    }
    IEnumerator BlinkTimer()
    {
        yield return new WaitForSeconds(5);

    }
    void PlaceHolder()
    {


        transform.position = target.transform.position;

    }
}