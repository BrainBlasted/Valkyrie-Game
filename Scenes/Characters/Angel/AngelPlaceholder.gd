#
#    Copyright (C) 2017  BrainBlasted
#
#    This program is free software: you can redistribute it and/or modify
#    it under the terms of the GNU General Public License as published by
#    the Free Software Foundation, either version 3 of the License, or
#    (at your option) any later version.
#
#    This program is distributed in the hope that it will be useful,
#    but WITHOUT ANY WARRANTY; without even the implied warranty of
#    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
#    GNU General Public License for more details.
#
#    You should have received a copy of the GNU General Public License
#    along with this program.  If not, see <http://www.gnu.org/licenses/>.
#
extends KinematicBody2D

# Motion variables
var speed = 75.0
var velocityup = Vector2()
var xspeed = 25.0
var velocity = Vector2()

func _slow_y():
	# Slows the character
	speed = speed - (speed * 0.75)

func _speedup():
	# Speeds up the character
	speed = speed + (speed * 0.05)

func _stopx():
	velocity.x = 0
	
func _fixed_process(delta):
	velocityup.y -= delta * speed 
	var motion = delta * velocityup
	# var motiony = 
	move(motion)
	
	velocity.x =  xspeed
	var motionx = velocity

	if Input.is_action_just_pressed("ui_down") || Input.is_key_pressed(KEY_S): 
		_slow_y()
		# if !Input.is_key_pressed(KEY_S):
		# 	speed = 70.0
	elif Input.is_action_just_pressed("ui_up") || Input.is_key_pressed(KEY_W):
		_speedup()
		# if !Input.is_key_pressed(KEY_W):
		#	speed = 70.0
	if Input.is_action_pressed("ui_right") || Input.is_key_pressed(KEY_D):
		move(motionx)
	elif Input.is_action_pressed("ui_left") || Input.is_key_pressed(KEY_A):
		move(-motionx)

func _ready():
	# Called every time the node is added to the scene.
	# Initialization here
	set_fixed_process(true)
	pass