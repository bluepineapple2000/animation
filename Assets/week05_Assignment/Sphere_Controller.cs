using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere_Controller : MonoBehaviour
{
    Animator Anim;
    public string PlayKey, PauseKey, ReverseKey;

    void Start()
    {
        Anim = GetComponent<Animator>();
        Anim.SetFloat("Controller", 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            if (Input.inputString.ToLower() == PlayKey.ToLower())
            {
                Anim.SetFloat("Controller", 1f);
            }
        }
        if (Input.anyKeyDown)
        {
            if (Input.inputString.ToLower() == PauseKey.ToLower())
            {
                Anim.SetFloat("Controller", 0f);
            }
        }
        if (Input.anyKeyDown)
        {
            if (Input.inputString.ToLower() == ReverseKey.ToLower())
            {
                Anim.SetFloat("Controller", -1f);
            }
        }
    }
}
