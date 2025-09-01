using UnityEngine;


//Inheritance: RedBall inherits from the Ball base class
public class RedBall : Ball
{
    RedBall()
    {
        scoreValue = 10; // Setting the point value specific to RedBall
    }
    //Polymorphism: overriding the OnClick method from the Ball base class
    public override void OnClick()
    {
        base.OnClick(); // Call the base class method to destroy the ball
        Debug.Log("You clicked on a RED BALL!");
    }
}
