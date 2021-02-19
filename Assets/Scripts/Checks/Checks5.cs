using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checks5 : MonoBehaviour
{


    private void OnTriggerStay2D(Collider2D target)
    {
        CheckController.ifActive5 = true;
        CheckController.finish5 = 1;

    }


    private void OnTriggerExit2D(Collider2D target)
    {
        CheckController.ifActive5 = false;
        CheckController.finish5 = 0;
    }
}
