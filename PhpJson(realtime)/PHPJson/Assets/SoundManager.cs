using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

using UnityEditor;

[CustomEditor(typeof(SoundManager))]
public class SoundManagerEditor : Editor {
    public override void OnInspectorGUI()
    {
        if (GUILayout.Button("Some Button")) {

        }
        base.OnInspectorGUI();
    }
}

public class SoundManager : MonoBehaviour {

    [Range(0,1)]
    public float masterVolume = 0;

    [Range(-80,20)]
    public float dbOutput = 0;

    public AudioMixer audioMixer;

    private void Update()
    {
        //-80 -> 20 as 0 -> 1
        var db = Mathf.Lerp(-80, 20, masterVolume);
        dbOutput = db;
        audioMixer.SetFloat("MasterVolume", db);
    }



}
