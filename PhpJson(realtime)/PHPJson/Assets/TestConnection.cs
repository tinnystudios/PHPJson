using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestConnection : MonoBehaviour {

    //Declare a path to test the connection
    private string connectionPath = "http://unityfoundation.gearhostpreview.com/GetUser.php";

    private void Start()
    {
        StartCoroutine(_GetConnection());
    }

    IEnumerator _GetConnection() {
        //Create a call to the network
        WWW www = new WWW(connectionPath);

        //Wait for the call to complete
        yield return www;

        //Output the response
        Debug.Log(www.text);
    }

}
