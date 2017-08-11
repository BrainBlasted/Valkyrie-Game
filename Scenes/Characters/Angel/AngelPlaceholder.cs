//
//    Copyright (C) 2017  BrainBlasted
//
//    This program is free software: you can redistribute it and/or modify
//    it under the terms of the GNU General Public License as published by
//    the Free Software Foundation, either version 3 of the License, or
//    (at your option) any later version.
//
//    This program is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//    GNU General Public License for more details.
//
//    You should have received a copy of the GNU General Public License
//    along with this program.  If not, see <http://www.gnu.org/licenses/>.
//
using System;
using GodotEngine;

public class AngelPlaceholder : KinematicBody2D
{
    // Motion variables
    float speed = 75.0f;    // Separate variables for 
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
        // Pulls the player up by a fixed process
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
