using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hold_Flag
{
    public static bool hold_flag = false;
}

public class Hold : MonoBehaviour {

    // Groups
    public GameObject[] groups;
    GameObject hold;
   

    GameObject createMino()
    {
        // Selected Index
        int i = GroupChecker.Current_Group;
        // Spawn Group at current Position
        return Instantiate(groups[i],
                    transform.position,
                    Quaternion.identity);
    }

    // Update is called once per frame
    void Update ()
    {
        if (Input.GetKeyUp(KeyCode.H))
        {
            if (Hold_Flag.hold_flag == true)
            {
                Debug.Log("before move");
                hold.transform.position = new Vector3(4, 14, -10);
                Debug.Log("move");
            }
            hold = createMino();
        }
        

    }
}
