[System.Serializable]
public class PremiumUser : User{
    public int points;
    public Developer developer;
}

[System.Serializable]
public class User {
    public string username;
    public int age;
}

[System.Serializable]
public class Developer {
    public string developerName;
    public int rank;
}
