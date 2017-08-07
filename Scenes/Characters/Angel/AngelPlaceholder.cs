using System;
using GodotEngine;

public class AngelPlaceholder : KinematicBody2D
{
    // Motion variables
    float speed = 75.0f;
    float xspeed = 25.0f;
    Vector2 velocity;
    Vector2 velocityup;
    void _ready()
    {
        // Called every time the node is added to the scene.
        // Initialization here
        set_fixed_process(true);
        
    }

    void _fixed_process(float delta)
    {
        velocityup.y -= delta * speed;
        Vector2 motion = delta * velocityup;
        move(motion);

        velocity.x = xspeed;
        Vector2 motionx = velocity;

        if (Input.is_action_pressed("ui_down") || Input.is_key_pressed(31))
        {
            SlowY();
        } else if (Input.is_action_just_pressed("ui_up") || Input.is_key_pressed(17))
        {
            SpeedUp();
        }
        if (Input.is_action_pressed("ui_right") || Input.is_key_pressed(32))
        {
            move(motionx);
        }else if (Input.is_action_pressed("ui_left") || Input.is_key_pressed(30))
        {
            move(-motionx);
        }
    }
    void SlowY()
    {
        speed = speed - (speed * 0.75f);
    }

    void SpeedUp()
    {
        speed = speed + (speed * 0.05f);
    }

    void StopX()
    {
        velocity.x = 0;
    }

    
}
