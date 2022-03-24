using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chainCollision : MonoBehaviour
{
   void OnTriggerEnter2D (Collider2D col)
   {
        chain.IsFired = false;

        if(col.tag == "Ball")
        {
            col.GetComponent<ball>().Split();
        }
   }
}
