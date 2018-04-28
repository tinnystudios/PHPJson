using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetUser : MonoBehaviour {

    public UserData userData;
    private string path = "http://unityfoundation.gearhostpreview.com/GetUser.php";

    void Start() {
        StartCoroutine(_GetUserData());
    }

    IEnumerator _GetUserData() {
        var userDataJsonString = JsonUtility.ToJson(userData);
        WWW www = new WWW(path);

        yield return www;

        userData = JsonUtility.FromJson<UserData>(www.text);
    }

}
