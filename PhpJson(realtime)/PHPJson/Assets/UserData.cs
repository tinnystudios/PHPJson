using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class UserData{
    public string username = "defaultUserName";
    public int age = 25;

    public SensitiveData sensitiveData;
}

[Serializable]
public class SensitiveData {
    public string password = "";
    public int pinCode = 0152;
    public Gender gender;
}

public enum Gender {
    male,
    female,
    unspecify
}