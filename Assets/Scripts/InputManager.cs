using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private Transform[] _transArray;
    
    // Start is called before the first frame update

    public GameObject redObj;
    public GameObject blueObj;
    public Vector3 tempPosition;
    
    void Start()
    {
        redObj = GameObject.FindWithTag("Red");
        blueObj = GameObject.FindWithTag("Blue");
        _transArray = new Transform[2];
        _transArray[0] = redObj.GetComponent<Transform>();
        _transArray[1] = blueObj.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            redObj.transform.Rotate(0f, 0f, 45.0f);
            blueObj.transform.Rotate(0f, 0f, -45.0f);
        }

        if (Input.GetButtonDown("Fire1"))
        {
            float tempY = blueObj.transform.position.y;
            blueObj.transform.position = new Vector3(blueObj.transform.position.x, redObj.transform.position.y, blueObj.transform.position.z);
            redObj.transform.position = new Vector3(redObj.transform.position.x, tempY, redObj.transform.position.z);

        }
    }
}
