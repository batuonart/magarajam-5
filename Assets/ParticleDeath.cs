using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleDeath : MonoBehaviour
{
    public float deathDelay = 2f;
    // Start is called before the first frame update
    void Start()
    {
       Destroy(gameObject, deathDelay);

    }
}
