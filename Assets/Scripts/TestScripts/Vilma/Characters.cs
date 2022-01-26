using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Characters : MonoBehaviour
{
    public GameObject Animal;
    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = Animal.GetComponent<Animator>();
        anim.SetBool("Activate", false);
    }

    public void HappyAnim ()
    {
        anim.SetBool("Activate", true);
    }

    public void IdleAnim()
    {
        anim.SetBool("Activate", false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
