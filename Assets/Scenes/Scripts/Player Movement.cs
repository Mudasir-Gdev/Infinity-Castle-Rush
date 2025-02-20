using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private SwipeScript SwipeInput;
    void Start()
    {
        SwipeInput = GetComponent<SwipeScript>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveX =SwipeInput.HorizontalSwipe*2;
        float moveY = SwipeInput.VerticalSwipe;
        Vector2 Move = new Vector2(SwipeInput.HorizontalSwipe,SwipeInput.VerticalSwipe);
        transform.position=new Vector2(moveX,0);
        if (moveY == 1f)
            //jump
            Debug.Log("Jump");
        else if (moveY == -1f)
            //Slide\slash
            Debug.Log("Slash");
        /*SwipeInput.VerticalSwipe = 0;*/
       

        
        
    }
}
