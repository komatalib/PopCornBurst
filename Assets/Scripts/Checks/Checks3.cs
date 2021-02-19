using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checks3 : MonoBehaviour
{


    private void OnTriggerStay2D(Collider2D target)
    {
        CheckController.ifActive3 = true;
        CheckController.finish3 = 1;

    }


    private void OnTriggerExit2D(Collider2D target)
    {
        CheckController.ifActive3 = false;
        CheckController.finish3 = 0;
    }
}
