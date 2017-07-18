extends KinematicBody2D

var speed = 70.0
var velocity = Vector2()
var dashspeed = 60.0

func _fixed_process(delta):
	# move( Vector2(0,-1))
	velocity.y -= delta * speed
	var motion = delta * velocity
	move(motion)
	if Input.is_action_just_pressed("ui_down"):
		_slow_y()
	elif Input.is_action_just_pressed("ui_up"):
		_speedup()
	if Input.is_action_just_pressed("ui_right"):
		velocity.x = dashspeed * 5.0
	elif Input.is_action_just_pressed("ui_left"):
		velocity.x = - dashspeed * 5.0
#	else:
#		_stopx()
#	elif Input.is_key_pressed(KEY_LEFT):
#		_dash_left()

func _slow_y():
	# Slows the character
	speed = speed * -1

func _speedup():
	# Speeds up the character
	speed = 300.0

func _stopx():
	velocity.x = 0
#func _dash_left():
#	# Left dash
#	velocity.x -= dashspeed
#	var motionx = int(dashspeed) * 1
#	move(motionx)

func _ready():
	# Called every time the node is added to the scene.
	# Initialization here
	set_fixed_process(true)
	pass
