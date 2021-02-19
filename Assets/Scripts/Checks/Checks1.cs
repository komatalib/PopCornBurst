using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checks1 : MonoBehaviour
{

    
    private void OnTriggerStay2D(Collider2D target)
    {
            CheckController.ifActive1 = true;
        CheckController.finish1 = 1;
        
    }


    private void OnTriggerExit2D(Collider2D target)
    {
            CheckController.ifActive1 = false;
        CheckController.finish1 = 0;
    }
}
