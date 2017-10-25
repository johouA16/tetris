using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    // Groups
    public GameObject[] groups;
    GameObject next;
    bool isExistNextZone = false;

    public void spawnNext()
    {
        if (isExistNextZone)
        {
            moveObject(next);
            next = createMino();
        }
        else
        {
            moveObject(createMino());
            next = createMino();
        }
    }

    void moveObject(GameObject fallObject)
    {
        fallObject.transform.position = new Vector3(4, 14, -10);
    }

    GameObject createMino()
    {
        // Random Index
        int i = Random.Range(0, groups.Length);

        // Spawn Group at current Position
        return Instantiate(groups[i],
                    transform.position,
                    Quaternion.identity);
    }

    // Use this for initialization
    void Start()
    {
        spawnNext();
        isExistNextZone = true;
    }


}
