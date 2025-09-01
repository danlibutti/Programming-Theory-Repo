using UnityEngine;

//Inheritance: BlueBall inherits from the Ball base class
public class BlueBall : Ball
{
    BlueBall()
    {
        scoreValue = 5; // Setting the point value specific to BlueBall
    }
    //Polymorphism: overriding the OnClick method from the Ball base class
    public override void OnClick()
    {
        base.OnClick(); // Call the base class method to destroy the ball
        Debug.Log("You clicked on a BLUE BALL!");
    }
}
