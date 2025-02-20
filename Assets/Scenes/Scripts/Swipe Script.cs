using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeScript : MonoBehaviour
{

    private float minSwipeRecognition = 600f;
    private Vector2 swipeCurrentframe;
    private Vector2 swipeLastframe;
    private Vector2 currentSwipe;
    public float HorizontalSwipe;
    public float VerticalSwipe;
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            swipeCurrentframe = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            
         
            if(swipeLastframe!= Vector2.zero)
            {
                currentSwipe = swipeCurrentframe - swipeLastframe;
                if (currentSwipe.sqrMagnitude < minSwipeRecognition)
                { 
                    return; 
                }
                    currentSwipe.Normalize();
                
                //Up/Down
                if(currentSwipe.x < -0.5f && currentSwipe.x > 0.5)
                {
                    if (currentSwipe.x > 0)
                    {
                        VerticalSwipe = 1;
                    }
                    else if(currentSwipe.x < 0)
                    {
                        VerticalSwipe = -1;
                    }
                    
                    

                }
                if(currentSwipe.y < -0.5f && currentSwipe.y > 0.5)
                {
                    if (currentSwipe.y < 0)
                    {
                        HorizontalSwipe--;
                    }
                    else if (currentSwipe.y>0)
                    {
                        HorizontalSwipe++;
                    }
                   HorizontalSwipe = Mathf.Clamp(HorizontalSwipe, -1, 1);
                }
            }
            swipeLastframe = swipeCurrentframe;
        }
        
    }
}
