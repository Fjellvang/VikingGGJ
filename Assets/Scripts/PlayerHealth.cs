using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {

    public float health = 10;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void TakeDmg()
    {
        health--;
        if (health < 0)
        {
            //we dead
            Destroy(gameObject);
        }
    }
}
