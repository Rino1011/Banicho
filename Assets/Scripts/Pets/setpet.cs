using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setpet : MonoBehaviour
{
    int count;
    public GameObject second;
    public GameObject third;
    // Start is called before the first frame update
    void Start()
    {
        int count = petcount.visitCount;
        Debug.Log("Visit Count: " + count);
    }

    // Update is called once per frame
    void Update()
    {
        if(count == 2)
        {
            second.SetActive(true);

            if (count == 3)
            {
                third.SetActive(true);
            }
        }
        
    }
}
