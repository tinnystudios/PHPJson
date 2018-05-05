using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SurvivorStage : Stage
{
    public float timeLapsedRequired = 15;

    public float timeLapsed = 0;

    public override IEnumerator Run()
    {
        //While timelapse has not gone passed the required timeLapse
        while (timeLapsed < timeLapsedRequired)
        {
            //Monitor timelapsed
            timeLapsed += Time.deltaTime;
            //Continue the loop
            yield return null;
        }
        //Ends here
    }

}
