using UnityEngine;

//Inheritance: YellowBall inherits from the Ball base class
public class YellowBall : Ball
{
    YellowBall()
    {
        scoreValue = 15; // Setting the point value specific to YellowBall
    }
    //Polymorphism: overriding the OnClick method from the Ball base class
    public override void OnClick()
    {
        base.OnClick(); // Call the base class method to destroy the ball
        Debug.Log("You clicked on a YELLOW BALL!");
    }
}
