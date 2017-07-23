extends KinematicBody2D

var speed = 70.0
var velocityup = Vector2()
var xspeed = 25.0
var velocity = Vector2()

func _fixed_process(delta):
	velocityup.y -= delta * speed 
	var motion = delta * velocityup
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

func _slow_y():
	# Slows the character
	speed = speed - (speed * 0.75)

func _speedup():
	# Speeds up the character
	speed = speed + (speed * 0.05)

func _stopx():
	velocity.x = 0
	
func _ready():
	# Called every time the node is added to the scene.
	# Initialization here
	set_fixed_process(true)
	pass
