using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetUser : MonoBehaviour {
    public User user;
    public PremiumUser premiumUser;

    private string path = "http://localhost/getuser.php";

    private void Start()
    {
        StartCoroutine(GetData());
    }

    IEnumerator GetData() {

        using (WWW www = new WWW(path))
        {
            yield return www;

            //If there is no error
            if (!string.IsNullOrEmpty(www.error))
            {
                Debug.Log("There is an error");
            }


            var jsonText = www.text;
            user = JsonUtility.FromJson<User>(jsonText);
            premiumUser = JsonUtility.FromJson<PremiumUser>(jsonText);
        }
    }

}
