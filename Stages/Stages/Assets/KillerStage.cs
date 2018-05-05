using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillerStage : Stage {
    public int killRequired = 5;
    public int killCount = 0;

    public override IEnumerator Run()
    {
        while (killCount < killRequired) {
            yield return null;
        }
    }
}
