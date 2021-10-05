using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHandler : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        Debug.Log("its alll fine");

        Debug.Log("why is it so hard");
    }

    // Update is called once per frame
    private void Update()
    {

        Vector3 horizontal = new Vector3(Input.GetAxis("Horizontal"), 0.0f, 0.0f);
        transform.position = transform.position + horizontal * Time.deltaTime;

    }
}
