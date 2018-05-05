using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//It's going run stages in order
public class StageManager : MonoBehaviour {

    public Stage[] stages; //An array of stages to run

    //Unity callback, gets called at the start
    private void Awake()
    {
        //Stages = all stage in the scene
        //stages = FindObjectsOfType<Stage>();

        //Stages = all stage inside stageManager object.
        stages = GetComponentsInChildren<Stage>(includeInactive:true);

        StartCoroutine(StageRoutine());
    }

    //Custom code, not unity callbacks.
    IEnumerator StageRoutine() {
        Debug.Log("[StageManager] begins");

        for (int i = 0; i < stages.Length; i++) {
            Debug.Log(stages[i].name + " started");

            yield return stages[i].Run();

            Debug.Log(stages[i].name + " ended");
        }

        Debug.Log("[StageManager] ends");
    }


}
