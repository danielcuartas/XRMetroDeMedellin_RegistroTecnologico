using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assemble : MonoBehaviour
{
    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {

    }

    
    private void OnTriggerEnter(Collider other)
    {

        anim.SetBool("bDis", false);
        
    }

   
    // Update is called once per frame
    void Update()
    {
        
    }
}
