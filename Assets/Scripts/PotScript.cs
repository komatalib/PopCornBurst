using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotScript : MonoBehaviour
{
    [SerializeField]
    private GameObject corn;

    private Rigidbody2D myPot;

    private void Awake()
    {
        myPot = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Cooking();
    }

    void Cooking()
    {
        if (Input.GetMouseButton(0))
        {
            StartCoroutine(CookingCorn());
            
        }
    }

    IEnumerator CookingCorn()
    {
        Vector3 temp = myPot.position;
        temp.x = Random.Range(-0.4f, 0.4f);
        temp.y -= 0.2f;
        Instantiate(corn, temp, Quaternion.identity);

        yield return new WaitForSeconds(2f);
    }
}
