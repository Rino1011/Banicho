using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animation : MonoBehaviour
{
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //Debug.Log("osu");
            animator.SetBool("test", true);
        }
        else if (Input.GetMouseButtonUp(0))
        {
            animator.SetBool("test", false);
        }
    }
}
