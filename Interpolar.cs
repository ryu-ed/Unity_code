using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interpolar : MonoBehaviour {

    public Transform[] targets;
    public int currenTargetIndex;
    public float speed;
    
    

    private void Update()
    {
        transform.position = Vector3.MoveTowards(
            transform.position, 
            targets[currenTargetIndex].position, 
            speed * Time.deltaTime);
      

        float dist = Vector3.Distance(transform.position, targets[currenTargetIndex].position);
        if (dist <= 0.1)
        {
            currenTargetIndex++;
            if(currenTargetIndex <= targets.Length)
            {
                currenTargetIndex = 0;
            }
        }
    }
}
