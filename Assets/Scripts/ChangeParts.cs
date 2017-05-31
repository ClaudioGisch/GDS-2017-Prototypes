using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeParts : MonoBehaviour {

    public GameObject[] arrayOfParts;
    private int pos = 0;

	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.J))
        {
            nextPart();
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            previousPart();
        }


    }

    public void nextPart()
    {
        removePart();
        pos++;
        if (pos >= arrayOfParts.Length)
        {
            pos = 0;
        }
        insertPart();
    }

    public void previousPart()
    {
        removePart();
        pos--;
        if (pos < 0)
        {
            pos = arrayOfParts.Length - 1;
        }
        insertPart();
    }

    void removePart()
    {
        foreach (Transform child in transform)
        {
            GameObject.Destroy(child.gameObject); //destroy the child currently attached to this object
        }

    }

    void insertPart()
    {
        Instantiate(arrayOfParts[pos], transform);
    }
}

