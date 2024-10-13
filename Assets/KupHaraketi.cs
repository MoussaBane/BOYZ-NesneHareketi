using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KupHaraketi : MonoBehaviour
{

    public float speed = 1.0f; // Public değişken
    private float hiz = 1.0f;  // Private değişken


    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(3, 4, 2); // Nesnenin x=3 y=4 z=2 yapar.
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position += Vector3.forward * Time.deltaTime; // Nesneyi Z ekseninde hareket ettirir.

        // float moveVertical = Input.GetAxis("Vertical"); // Yön tuşları ile dikey eksen kontrolü
        // transform.position += Vector3.forward * moveVertical * speed * Time.deltaTime;

        float moveVertical = Input.GetAxis("Vertical"); // Yön tuşları ile dikey eksen kontrolü
        float moveHorizontal = Input.GetAxis("Horizontal"); // Yatay eksen kontrolü
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        transform.position += movement * speed * Time.deltaTime;
    }
}
