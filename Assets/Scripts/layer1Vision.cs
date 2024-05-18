using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class layer1Vision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("btn_start"))
        {
            var objs = GameObject.FindGameObjectsWithTag("Screen2");
            foreach (var obj in objs) obj.SetActive(true);
        }
    }
}
