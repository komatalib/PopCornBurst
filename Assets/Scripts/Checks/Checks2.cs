using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checks2 : MonoBehaviour
{


    private void OnTriggerStay2D(Collider2D target)
    {
        CheckController.ifActive2 = true;
        CheckController.finish2 = 1;

    }


    private void OnTriggerExit2D(Collider2D target)
    {
        CheckController.ifActive2 = false;
        CheckController.finish2 = 0;
    }
}
