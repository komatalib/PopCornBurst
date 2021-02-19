using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checks4 : MonoBehaviour
{


    private void OnTriggerStay2D(Collider2D target)
    {
        CheckController.ifActive4 = true;
        CheckController.finish4 = 1;

    }


    private void OnTriggerExit2D(Collider2D target)
    {
        CheckController.ifActive4 = false;
        CheckController.finish4 = 0;
    }
}
