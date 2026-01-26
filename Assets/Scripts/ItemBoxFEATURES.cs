using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBoxFEATURES : MonoBehaviour
{
    private float movsped;
    private float tophiet;
    private float frompheit;

    public float rotsped;
    public float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        /////// uhhh numero 151 in da workbook
        ///
        moveSpeed = 0.01f;
        movsped = moveSpeed;
        tophiet = this.transform.position.y + 0.5f;
        frompheit = this.transform.position.y;
        rotsped = 200f;
         
    }

    // Update is called once per frame
    void Update()
    {
        AnimateBox();
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Cody")
        {
            this.gameObject.SetActive(false);
            Invoke("itemBoxRespawn", 5);
        }
    }

    void AnimateBox()
    {
        this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + movsped, this.transform.position.z); // up 0.5 down 0.5

        if (this.transform.position.y > tophiet || this.transform.position.y < frompheit)
        {
            movsped *= -1;
        }

        this.transform.Rotate(0, rotsped * Time.deltaTime, rotsped * Time.deltaTime);
    }

    void itemBoxRespawn()
    {
        this.gameObject.SetActive(true);
    }
}
