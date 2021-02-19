using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checks6 : MonoBehaviour
{


    private void OnTriggerStay2D(Collider2D target)
    {
        CheckController.ifActive6 = true;
        CheckController.finish6 = 1;

    }


    private void OnTriggerExit2D(Collider2D target)
    {
        CheckController.ifActive6 = false;
        CheckController.finish6 = 0;
    }
}
