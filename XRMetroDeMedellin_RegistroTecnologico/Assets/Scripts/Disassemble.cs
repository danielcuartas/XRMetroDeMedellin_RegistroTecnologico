using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disassemble : MonoBehaviour
{
    public bool bDisassemble;
    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        bDisassemble = false;
    }

    
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Disassemble");

        anim.SetBool("bDis", true);
        
    }

    

    /*private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Disasseble");
        bDisassemble = true;
    }
    */

    // Update is called once per frame
    void Update()
    {
        
    }
}
