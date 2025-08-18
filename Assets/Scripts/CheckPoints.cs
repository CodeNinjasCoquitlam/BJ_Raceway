using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoints : MonoBehaviour
{
   /* public bool didCollide;
    public GameManager count;
    public GameObject checkpoint;

    // Start is called before the first frame update
    void Start()
    {
        didCollide = false;
        GameObject gameManagerTransform = GameObject.FindWithTag("gameManager");
        gameManager = gameManagerTransform.GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }*/
   public void onTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Cody")
        {
            Destroy(this);
        }
    }
}

