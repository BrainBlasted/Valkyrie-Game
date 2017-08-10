using System;
using System.Runtime.CompilerServices;
using System.Collections.Generic;

namespace GodotEngine
{
    internal static class NativeCalls
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_TypeDB_get_method(string type, string method);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_Object_Dtor(IntPtr ptr);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static Error godot_icall_Object_connect_signal_awaiter(IntPtr source, string signal, IntPtr target, SignalAwaiter awaiter);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_NodePath_Ctor(string path);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_NodePath_Dtor(IntPtr ptr);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static string godot_icall_NodePath_operator_String(IntPtr ptr);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_RID_Ctor(IntPtr from);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_RID_Dtor(IntPtr ptr);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static byte[] godot_icall_String_md5_buffer(string str);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static string godot_icall_String_md5_text(string str);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static int godot_icall_String_rfind(string str, string what, int from);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static int godot_icall_String_rfindn(string str, string what, int from);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static byte[] godot_icall_String_sha256_buffer(string str);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static string godot_icall_String_sha256_text(string str);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static object godot_icall_Godot_bytes2var(byte[] bytes);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static object godot_icall_Godot_convert(object what, int type);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static int godot_icall_Godot_hash(object var);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static Object godot_icall_Godot_instance_from_id(int instance_id);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_Godot_print(object[] what);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_Godot_printerr(object[] what);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_Godot_printraw(object[] what);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_Godot_prints(object[] what);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_Godot_printt(object[] what);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_Godot_seed(int seed);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static string godot_icall_Godot_str(object[] what);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static object godot_icall_Godot_str2var(string str);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static bool godot_icall_Godot_type_exists(string type);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static byte[] godot_icall_Godot_var2bytes(object what);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static string godot_icall_Godot_var2str(object var);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static WeakRef godot_icall_Godot_weakref(IntPtr obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_ARVRAnchor_Ctor(ARVRAnchor obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_ARVRCamera_Ctor(ARVRCamera obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_ARVRController_Ctor(ARVRController obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_ARVROrigin_Ctor(ARVROrigin obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_ARVRPositionalTracker_Ctor(ARVRPositionalTracker obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_ARVRScriptInterface_Ctor(ARVRScriptInterface obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_ARVRServer_get_singleton();
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_AStar_Ctor(AStar obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_AcceptDialog_Ctor(AcceptDialog obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_AnimatedSprite_Ctor(AnimatedSprite obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_AnimatedSprite3D_Ctor(AnimatedSprite3D obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_Animation_Ctor(Animation obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_AnimationPlayer_Ctor(AnimationPlayer obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_AnimationTreePlayer_Ctor(AnimationTreePlayer obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_Area_Ctor(Area obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_Area2D_Ctor(Area2D obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_ArrayMesh_Ctor(ArrayMesh obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_AtlasTexture_Ctor(AtlasTexture obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_AudioBusLayout_Ctor(AudioBusLayout obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_AudioEffectAmplify_Ctor(AudioEffectAmplify obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_AudioEffectBandLimitFilter_Ctor(AudioEffectBandLimitFilter obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_AudioEffectBandPassFilter_Ctor(AudioEffectBandPassFilter obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_AudioEffectChorus_Ctor(AudioEffectChorus obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_AudioEffectCompressor_Ctor(AudioEffectCompressor obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_AudioEffectDelay_Ctor(AudioEffectDelay obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_AudioEffectDistortion_Ctor(AudioEffectDistortion obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_AudioEffectEQ10_Ctor(AudioEffectEQ10 obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_AudioEffectEQ21_Ctor(AudioEffectEQ21 obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_AudioEffectEQ6_Ctor(AudioEffectEQ6 obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_AudioEffectHighPassFilter_Ctor(AudioEffectHighPassFilter obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_AudioEffectHighShelfFilter_Ctor(AudioEffectHighShelfFilter obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_AudioEffectLimiter_Ctor(AudioEffectLimiter obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_AudioEffectLowPassFilter_Ctor(AudioEffectLowPassFilter obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_AudioEffectLowShelfFilter_Ctor(AudioEffectLowShelfFilter obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_AudioEffectNotchFilter_Ctor(AudioEffectNotchFilter obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_AudioEffectPanner_Ctor(AudioEffectPanner obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_AudioEffectPhaser_Ctor(AudioEffectPhaser obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_AudioEffectPitchShift_Ctor(AudioEffectPitchShift obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_AudioEffectReverb_Ctor(AudioEffectReverb obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_AudioEffectStereoEnhance_Ctor(AudioEffectStereoEnhance obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_AudioServer_get_singleton();
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_AudioStreamOGGVorbis_Ctor(AudioStreamOGGVorbis obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_AudioStreamPlayer_Ctor(AudioStreamPlayer obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_AudioStreamPlayer2D_Ctor(AudioStreamPlayer2D obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_AudioStreamPlayer3D_Ctor(AudioStreamPlayer3D obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_AudioStreamRandomPitch_Ctor(AudioStreamRandomPitch obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_AudioStreamSample_Ctor(AudioStreamSample obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_BackBufferCopy_Ctor(BackBufferCopy obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_BitMap_Ctor(BitMap obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_BitmapFont_Ctor(BitmapFont obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_BoneAttachment_Ctor(BoneAttachment obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_BoxShape_Ctor(BoxShape obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_Button_Ctor(Button obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_ButtonGroup_Ctor(ButtonGroup obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_CSharpScript_Ctor(CSharpScript obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_Camera_Ctor(Camera obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_Camera2D_Ctor(Camera2D obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_CanvasItemMaterial_Ctor(CanvasItemMaterial obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_CanvasLayer_Ctor(CanvasLayer obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_CanvasModulate_Ctor(CanvasModulate obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_CapsuleMesh_Ctor(CapsuleMesh obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_CapsuleShape_Ctor(CapsuleShape obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_CapsuleShape2D_Ctor(CapsuleShape2D obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_CenterContainer_Ctor(CenterContainer obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_CheckBox_Ctor(CheckBox obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_CheckButton_Ctor(CheckButton obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_CircleShape2D_Ctor(CircleShape2D obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_CollisionPolygon_Ctor(CollisionPolygon obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_CollisionPolygon2D_Ctor(CollisionPolygon2D obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_CollisionShape_Ctor(CollisionShape obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_CollisionShape2D_Ctor(CollisionShape2D obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_ColorPicker_Ctor(ColorPicker obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_ColorPickerButton_Ctor(ColorPickerButton obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_ColorRect_Ctor(ColorRect obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_ConcavePolygonShape_Ctor(ConcavePolygonShape obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_ConcavePolygonShape2D_Ctor(ConcavePolygonShape2D obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_ConeTwistJoint_Ctor(ConeTwistJoint obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_ConfigFile_Ctor(ConfigFile obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_ConfirmationDialog_Ctor(ConfirmationDialog obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_Container_Ctor(Container obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_Control_Ctor(Control obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_ConvexPolygonShape_Ctor(ConvexPolygonShape obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_ConvexPolygonShape2D_Ctor(ConvexPolygonShape2D obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_CubeMap_Ctor(CubeMap obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_CubeMesh_Ctor(CubeMesh obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_Curve_Ctor(Curve obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_Curve2D_Ctor(Curve2D obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_Curve3D_Ctor(Curve3D obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_CurveTexture_Ctor(CurveTexture obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_CylinderMesh_Ctor(CylinderMesh obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_DampedSpringJoint2D_Ctor(DampedSpringJoint2D obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_DirectionalLight_Ctor(DirectionalLight obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_DynamicFont_Ctor(DynamicFont obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_DynamicFontData_Ctor(DynamicFontData obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_Environment_Ctor(Environment obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_FileDialog_Ctor(FileDialog obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_FuncRef_Ctor(FuncRef obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_GDNative_Ctor(GDNative obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_GDNativeLibrary_Ctor(GDNativeLibrary obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_GDScript_Ctor(GDScript obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_GIProbe_Ctor(GIProbe obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_GIProbeData_Ctor(GIProbeData obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_Generic6DOFJoint_Ctor(Generic6DOFJoint obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_Gradient_Ctor(Gradient obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_GradientTexture_Ctor(GradientTexture obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_GraphEdit_Ctor(GraphEdit obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_GraphNode_Ctor(GraphNode obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_GridContainer_Ctor(GridContainer obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_GridMap_Ctor(GridMap obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_GrooveJoint2D_Ctor(GrooveJoint2D obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_HBoxContainer_Ctor(HBoxContainer obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_HScrollBar_Ctor(HScrollBar obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_HSeparator_Ctor(HSeparator obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_HSlider_Ctor(HSlider obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_HSplitContainer_Ctor(HSplitContainer obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_HTTPClient_Ctor(HTTPClient obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_HTTPRequest_Ctor(HTTPRequest obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_HingeJoint_Ctor(HingeJoint obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_IP_get_singleton();
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_Image_Ctor(Image obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_ImageTexture_Ctor(ImageTexture obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_ImmediateGeometry_Ctor(ImmediateGeometry obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_Input_get_singleton();
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_InputEventAction_Ctor(InputEventAction obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_InputEventJoypadButton_Ctor(InputEventJoypadButton obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_InputEventJoypadMotion_Ctor(InputEventJoypadMotion obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_InputEventKey_Ctor(InputEventKey obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_InputEventMouseButton_Ctor(InputEventMouseButton obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_InputEventMouseMotion_Ctor(InputEventMouseMotion obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_InputEventScreenDrag_Ctor(InputEventScreenDrag obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_InputEventScreenTouch_Ctor(InputEventScreenTouch obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_InputMap_get_singleton();
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_InterpolatedCamera_Ctor(InterpolatedCamera obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_ItemList_Ctor(ItemList obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_KinematicBody_Ctor(KinematicBody obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_KinematicBody2D_Ctor(KinematicBody2D obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_Label_Ctor(Label obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_LargeTexture_Ctor(LargeTexture obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_Light2D_Ctor(Light2D obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_LightOccluder2D_Ctor(LightOccluder2D obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_Line2D_Ctor(Line2D obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_LineEdit_Ctor(LineEdit obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_LineShape2D_Ctor(LineShape2D obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_LinkButton_Ctor(LinkButton obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_Listener_Ctor(Listener obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_MainLoop_Ctor(MainLoop obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_MarginContainer_Ctor(MarginContainer obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_MenuButton_Ctor(MenuButton obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_MeshDataTool_Ctor(MeshDataTool obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_MeshInstance_Ctor(MeshInstance obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_MeshLibrary_Ctor(MeshLibrary obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_MultiMesh_Ctor(MultiMesh obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_MultiMeshInstance_Ctor(MultiMeshInstance obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_NativeScript_Ctor(NativeScript obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_Navigation_Ctor(Navigation obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_Navigation2D_Ctor(Navigation2D obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_NavigationMesh_Ctor(NavigationMesh obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_NavigationMeshInstance_Ctor(NavigationMeshInstance obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_NavigationPolygon_Ctor(NavigationPolygon obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_NavigationPolygonInstance_Ctor(NavigationPolygonInstance obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_NetworkedMultiplayerENet_Ctor(NetworkedMultiplayerENet obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_NinePatchRect_Ctor(NinePatchRect obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_Node_Ctor(Node obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_Node2D_Ctor(Node2D obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_Object_Ctor(Object obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_OccluderPolygon2D_Ctor(OccluderPolygon2D obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_OmniLight_Ctor(OmniLight obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_OptionButton_Ctor(OptionButton obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_PCKPacker_Ctor(PCKPacker obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_PHashTranslation_Ctor(PHashTranslation obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_PackedDataContainer_Ctor(PackedDataContainer obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_PackedScene_Ctor(PackedScene obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_PacketPeerStream_Ctor(PacketPeerStream obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_PacketPeerUDP_Ctor(PacketPeerUDP obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_Panel_Ctor(Panel obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_PanelContainer_Ctor(PanelContainer obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_PanoramaSky_Ctor(PanoramaSky obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_ParallaxBackground_Ctor(ParallaxBackground obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_ParallaxLayer_Ctor(ParallaxLayer obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_Particles_Ctor(Particles obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_Particles2D_Ctor(Particles2D obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_ParticlesMaterial_Ctor(ParticlesMaterial obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_Path_Ctor(Path obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_Path2D_Ctor(Path2D obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_PathFollow_Ctor(PathFollow obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_PathFollow2D_Ctor(PathFollow2D obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_Performance_get_singleton();
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_Physics2DServer_get_singleton();
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_Physics2DShapeQueryParameters_Ctor(Physics2DShapeQueryParameters obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_Physics2DTestMotionResult_Ctor(Physics2DTestMotionResult obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_PhysicsServer_get_singleton();
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_PhysicsShapeQueryParameters_Ctor(PhysicsShapeQueryParameters obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_PinJoint_Ctor(PinJoint obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_PinJoint2D_Ctor(PinJoint2D obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_PlaneMesh_Ctor(PlaneMesh obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_PlaneShape_Ctor(PlaneShape obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_Polygon2D_Ctor(Polygon2D obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_PolygonPathFinder_Ctor(PolygonPathFinder obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_Popup_Ctor(Popup obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_PopupDialog_Ctor(PopupDialog obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_PopupMenu_Ctor(PopupMenu obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_PopupPanel_Ctor(PopupPanel obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_Portal_Ctor(Portal obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_Position2D_Ctor(Position2D obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_Position3D_Ctor(Position3D obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_PrismMesh_Ctor(PrismMesh obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_ProceduralSky_Ctor(ProceduralSky obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_ProgressBar_Ctor(ProgressBar obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_ProjectSettings_get_singleton();
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_ProximityGroup_Ctor(ProximityGroup obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_QuadMesh_Ctor(QuadMesh obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_Range_Ctor(Range obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_RayCast_Ctor(RayCast obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_RayCast2D_Ctor(RayCast2D obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_RayShape_Ctor(RayShape obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_RayShape2D_Ctor(RayShape2D obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_RectangleShape2D_Ctor(RectangleShape2D obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_Reference_Ctor(Reference obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_ReferenceRect_Ctor(ReferenceRect obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_ReflectionProbe_Ctor(ReflectionProbe obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_RegEx_Ctor(RegEx obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_RegExMatch_Ctor(RegExMatch obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_RemoteTransform_Ctor(RemoteTransform obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_RemoteTransform2D_Ctor(RemoteTransform2D obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_Resource_Ctor(Resource obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_ResourcePreloader_Ctor(ResourcePreloader obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_RichTextLabel_Ctor(RichTextLabel obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_RigidBody_Ctor(RigidBody obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_RigidBody2D_Ctor(RigidBody2D obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_Room_Ctor(Room obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_RoomBounds_Ctor(RoomBounds obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_SceneTree_Ctor(SceneTree obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_ScrollContainer_Ctor(ScrollContainer obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_SegmentShape2D_Ctor(SegmentShape2D obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_Shader_Ctor(Shader obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_ShaderMaterial_Ctor(ShaderMaterial obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_ShortCut_Ctor(ShortCut obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_Skeleton_Ctor(Skeleton obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_SliderJoint_Ctor(SliderJoint obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_Spatial_Ctor(Spatial obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_SpatialMaterial_Ctor(SpatialMaterial obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_SpatialVelocityTracker_Ctor(SpatialVelocityTracker obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_SphereMesh_Ctor(SphereMesh obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_SphereShape_Ctor(SphereShape obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_SpinBox_Ctor(SpinBox obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_SpotLight_Ctor(SpotLight obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_Sprite_Ctor(Sprite obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_Sprite3D_Ctor(Sprite3D obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_SpriteFrames_Ctor(SpriteFrames obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_StaticBody_Ctor(StaticBody obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_StaticBody2D_Ctor(StaticBody2D obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_StreamPeerBuffer_Ctor(StreamPeerBuffer obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_StreamPeerSSL_Ctor(StreamPeerSSL obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_StreamPeerTCP_Ctor(StreamPeerTCP obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_StreamTexture_Ctor(StreamTexture obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_StyleBoxEmpty_Ctor(StyleBoxEmpty obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_StyleBoxFlat_Ctor(StyleBoxFlat obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_StyleBoxTexture_Ctor(StyleBoxTexture obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_SurfaceTool_Ctor(SurfaceTool obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_TCP_Server_Ctor(TCP_Server obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_TabContainer_Ctor(TabContainer obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_Tabs_Ctor(Tabs obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_TextEdit_Ctor(TextEdit obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_TextureButton_Ctor(TextureButton obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_TextureProgress_Ctor(TextureProgress obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_TextureRect_Ctor(TextureRect obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_Theme_Ctor(Theme obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_TileMap_Ctor(TileMap obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_TileSet_Ctor(TileSet obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_Timer_Ctor(Timer obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_ToolButton_Ctor(ToolButton obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_TouchScreenButton_Ctor(TouchScreenButton obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_Translation_Ctor(Translation obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_TranslationServer_get_singleton();
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_Tree_Ctor(Tree obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_TriangleMesh_Ctor(TriangleMesh obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_Tween_Ctor(Tween obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_UndoRedo_Ctor(UndoRedo obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_VBoxContainer_Ctor(VBoxContainer obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_VScrollBar_Ctor(VScrollBar obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_VSeparator_Ctor(VSeparator obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_VSlider_Ctor(VSlider obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_VSplitContainer_Ctor(VSplitContainer obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_VehicleBody_Ctor(VehicleBody obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_VehicleWheel_Ctor(VehicleWheel obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_VideoPlayer_Ctor(VideoPlayer obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_Viewport_Ctor(Viewport obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_ViewportContainer_Ctor(ViewportContainer obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_ViewportTexture_Ctor(ViewportTexture obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_VisibilityEnabler_Ctor(VisibilityEnabler obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_VisibilityEnabler2D_Ctor(VisibilityEnabler2D obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_VisibilityNotifier_Ctor(VisibilityNotifier obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_VisibilityNotifier2D_Ctor(VisibilityNotifier2D obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_VisualScript_Ctor(VisualScript obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_VisualScriptBasicTypeConstant_Ctor(VisualScriptBasicTypeConstant obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_VisualScriptBuiltinFunc_Ctor(VisualScriptBuiltinFunc obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_VisualScriptClassConstant_Ctor(VisualScriptClassConstant obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_VisualScriptComment_Ctor(VisualScriptComment obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_VisualScriptCondition_Ctor(VisualScriptCondition obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_VisualScriptConstant_Ctor(VisualScriptConstant obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_VisualScriptConstructor_Ctor(VisualScriptConstructor obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_VisualScriptCustomNode_Ctor(VisualScriptCustomNode obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_VisualScriptDeconstruct_Ctor(VisualScriptDeconstruct obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_VisualScriptEmitSignal_Ctor(VisualScriptEmitSignal obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_VisualScriptEngineSingleton_Ctor(VisualScriptEngineSingleton obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_VisualScriptExpression_Ctor(VisualScriptExpression obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_VisualScriptFunction_Ctor(VisualScriptFunction obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_VisualScriptFunctionCall_Ctor(VisualScriptFunctionCall obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_VisualScriptGlobalConstant_Ctor(VisualScriptGlobalConstant obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_VisualScriptIndexGet_Ctor(VisualScriptIndexGet obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_VisualScriptIndexSet_Ctor(VisualScriptIndexSet obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_VisualScriptInputAction_Ctor(VisualScriptInputAction obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_VisualScriptIterator_Ctor(VisualScriptIterator obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_VisualScriptLocalVar_Ctor(VisualScriptLocalVar obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_VisualScriptLocalVarSet_Ctor(VisualScriptLocalVarSet obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_VisualScriptMathConstant_Ctor(VisualScriptMathConstant obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_VisualScriptOperator_Ctor(VisualScriptOperator obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_VisualScriptPreload_Ctor(VisualScriptPreload obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_VisualScriptPropertyGet_Ctor(VisualScriptPropertyGet obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_VisualScriptPropertySet_Ctor(VisualScriptPropertySet obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_VisualScriptResourcePath_Ctor(VisualScriptResourcePath obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_VisualScriptReturn_Ctor(VisualScriptReturn obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_VisualScriptSceneNode_Ctor(VisualScriptSceneNode obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_VisualScriptSceneTree_Ctor(VisualScriptSceneTree obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_VisualScriptSelect_Ctor(VisualScriptSelect obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_VisualScriptSelf_Ctor(VisualScriptSelf obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_VisualScriptSequence_Ctor(VisualScriptSequence obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_VisualScriptSubCall_Ctor(VisualScriptSubCall obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_VisualScriptSwitch_Ctor(VisualScriptSwitch obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_VisualScriptTypeCast_Ctor(VisualScriptTypeCast obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_VisualScriptVariableGet_Ctor(VisualScriptVariableGet obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_VisualScriptVariableSet_Ctor(VisualScriptVariableSet obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_VisualScriptWhile_Ctor(VisualScriptWhile obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_VisualScriptYield_Ctor(VisualScriptYield obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_VisualScriptYieldSignal_Ctor(VisualScriptYieldSignal obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_VisualServer_get_singleton();
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_WeakRef_Ctor(WeakRef obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_WindowDialog_Ctor(WindowDialog obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_World_Ctor(World obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_World2D_Ctor(World2D obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_WorldEnvironment_Ctor(WorldEnvironment obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_XMLParser_Ctor(XMLParser obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_YSort_Ctor(YSort obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall__ClassDB_get_singleton();
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_Directory_Ctor(Directory obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall__Engine_get_singleton();
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_File_Ctor(File obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall__Geometry_get_singleton();
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall__GodotSharp_get_singleton();
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall__Marshalls_get_singleton();
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_Mutex_Ctor(Mutex obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall__OS_get_singleton();
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall__ResourceLoader_get_singleton();
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall__ResourceSaver_get_singleton();
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_Semaphore_Ctor(Semaphore obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_Thread_Ctor(Thread obj);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_1_0(IntPtr method, IntPtr ptr, int arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static int godot_icall_0_1(IntPtr method, IntPtr ptr);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static string godot_icall_0_2(IntPtr method, IntPtr ptr);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static bool godot_icall_0_3(IntPtr method, IntPtr ptr);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static object godot_icall_0_4(IntPtr method, IntPtr ptr);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static int godot_icall_1_5(IntPtr method, IntPtr ptr, int arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static float godot_icall_1_6(IntPtr method, IntPtr ptr, int arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_1_7(IntPtr method, IntPtr ptr, bool arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_0_8(IntPtr method, IntPtr ptr);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static object godot_icall_0_9(IntPtr method, IntPtr ptr);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_1_10(IntPtr method, IntPtr ptr, float arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static float godot_icall_0_11(IntPtr method, IntPtr ptr);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static object godot_icall_0_12(IntPtr method, IntPtr ptr);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static object godot_icall_1_13(IntPtr method, IntPtr ptr, bool arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static object godot_icall_0_14(IntPtr method, IntPtr ptr);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_2_15(IntPtr method, IntPtr ptr, bool arg1, bool arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static ARVRInterface godot_icall_1_16(IntPtr method, IntPtr ptr, int arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static ARVRInterface godot_icall_1_17(IntPtr method, IntPtr ptr, string arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static ARVRPositionalTracker godot_icall_1_18(IntPtr method, IntPtr ptr, int arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_1_19(IntPtr method, IntPtr ptr, IntPtr arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_3_20(IntPtr method, IntPtr ptr, int arg1, ref Vector3 arg2, float arg3);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static object godot_icall_1_21(IntPtr method, IntPtr ptr, int arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static bool godot_icall_1_22(IntPtr method, IntPtr ptr, int arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_3_23(IntPtr method, IntPtr ptr, int arg1, int arg2, bool arg3);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_2_24(IntPtr method, IntPtr ptr, int arg1, int arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static bool godot_icall_2_25(IntPtr method, IntPtr ptr, int arg1, int arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static int godot_icall_1_26(IntPtr method, IntPtr ptr, ref Vector3 arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static object godot_icall_1_27(IntPtr method, IntPtr ptr, ref Vector3 arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static Vector3[] godot_icall_2_28(IntPtr method, IntPtr ptr, int arg1, int arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static int[] godot_icall_2_29(IntPtr method, IntPtr ptr, int arg1, int arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static Object godot_icall_0_30(IntPtr method, IntPtr ptr);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static Button godot_icall_3_31(IntPtr method, IntPtr ptr, string arg1, bool arg2, string arg3);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static Button godot_icall_1_32(IntPtr method, IntPtr ptr, string arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static LineEdit godot_icall_1_33(IntPtr method, IntPtr ptr, IntPtr arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_1_34(IntPtr method, IntPtr ptr, string arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_1_35(IntPtr method, IntPtr ptr, IntPtr arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static SpriteFrames godot_icall_0_36(IntPtr method, IntPtr ptr);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_1_37(IntPtr method, IntPtr ptr, ref Vector2 arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static int godot_icall_2_38(IntPtr method, IntPtr ptr, int arg1, int arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_1_39(IntPtr method, IntPtr ptr, int arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_2_40(IntPtr method, IntPtr ptr, int arg1, IntPtr arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static int godot_icall_1_41(IntPtr method, IntPtr ptr, IntPtr arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_2_42(IntPtr method, IntPtr ptr, int arg1, bool arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static int godot_icall_5_43(IntPtr method, IntPtr ptr, int arg1, float arg2, ref Vector3 arg3, ref Quat arg4, ref Vector3 arg5);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_4_44(IntPtr method, IntPtr ptr, int arg1, float arg2, object arg3, float arg4);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_2_45(IntPtr method, IntPtr ptr, int arg1, float arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_3_46(IntPtr method, IntPtr ptr, int arg1, int arg2, object arg3);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_3_47(IntPtr method, IntPtr ptr, int arg1, int arg2, float arg3);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static float godot_icall_2_48(IntPtr method, IntPtr ptr, int arg1, int arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static int godot_icall_3_49(IntPtr method, IntPtr ptr, int arg1, float arg2, bool arg3);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static object[] godot_icall_2_50(IntPtr method, IntPtr ptr, int arg1, float arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static int[] godot_icall_3_51(IntPtr method, IntPtr ptr, int arg1, float arg2, float arg3);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static string godot_icall_2_52(IntPtr method, IntPtr ptr, int arg1, int arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static object[] godot_icall_2_53(IntPtr method, IntPtr ptr, int arg1, int arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static int godot_icall_2_54(IntPtr method, IntPtr ptr, string arg1, IntPtr arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_2_55(IntPtr method, IntPtr ptr, string arg1, string arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static bool godot_icall_1_56(IntPtr method, IntPtr ptr, string arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static Animation godot_icall_1_57(IntPtr method, IntPtr ptr, string arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static string[] godot_icall_0_58(IntPtr method, IntPtr ptr);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static string godot_icall_1_59(IntPtr method, IntPtr ptr, string arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_3_60(IntPtr method, IntPtr ptr, string arg1, string arg2, float arg3);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static float godot_icall_2_61(IntPtr method, IntPtr ptr, string arg1, string arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_4_62(IntPtr method, IntPtr ptr, string arg1, float arg2, float arg3, bool arg4);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_2_63(IntPtr method, IntPtr ptr, string arg1, float arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_1_64(IntPtr method, IntPtr ptr, IntPtr arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_0_65(IntPtr method, IntPtr ptr);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_2_66(IntPtr method, IntPtr ptr, float arg1, bool arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static string godot_icall_1_67(IntPtr method, IntPtr ptr, IntPtr arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_2_68(IntPtr method, IntPtr ptr, int arg1, string arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static int godot_icall_2_69(IntPtr method, IntPtr ptr, string arg1, string arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static int godot_icall_1_70(IntPtr method, IntPtr ptr, string arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static string godot_icall_2_71(IntPtr method, IntPtr ptr, string arg1, int arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_2_72(IntPtr method, IntPtr ptr, string arg1, IntPtr arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_3_73(IntPtr method, IntPtr ptr, string arg1, IntPtr arg2, bool arg3);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static float godot_icall_1_74(IntPtr method, IntPtr ptr, string arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_2_75(IntPtr method, IntPtr ptr, string arg1, bool arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_2_76(IntPtr method, IntPtr ptr, string arg1, ref Vector2 arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static object godot_icall_1_77(IntPtr method, IntPtr ptr, string arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_2_78(IntPtr method, IntPtr ptr, string arg1, int arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_3_79(IntPtr method, IntPtr ptr, string arg1, int arg2, bool arg3);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static bool godot_icall_2_80(IntPtr method, IntPtr ptr, string arg1, int arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static int godot_icall_3_81(IntPtr method, IntPtr ptr, string arg1, string arg2, int arg3);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static bool godot_icall_3_82(IntPtr method, IntPtr ptr, string arg1, string arg2, int arg3);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_1_83(IntPtr method, IntPtr ptr, ref Vector3 arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static object[] godot_icall_0_84(IntPtr method, IntPtr ptr);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static bool godot_icall_1_85(IntPtr method, IntPtr ptr, IntPtr arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static string godot_icall_1_86(IntPtr method, IntPtr ptr, int arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_4_87(IntPtr method, IntPtr ptr, int arg1, object[] arg2, object[] arg3, int arg4);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_2_88(IntPtr method, IntPtr ptr, int arg1, IntPtr arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static Material godot_icall_1_89(IntPtr method, IntPtr ptr, int arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_1_90(IntPtr method, IntPtr ptr, ref Rect3 arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static object godot_icall_0_91(IntPtr method, IntPtr ptr);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static Texture godot_icall_0_92(IntPtr method, IntPtr ptr);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_1_93(IntPtr method, IntPtr ptr, ref Rect2 arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static object godot_icall_0_94(IntPtr method, IntPtr ptr);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_3_95(IntPtr method, IntPtr ptr, int arg1, IntPtr arg2, int arg3);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static AudioEffect godot_icall_2_96(IntPtr method, IntPtr ptr, int arg1, int arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_3_97(IntPtr method, IntPtr ptr, int arg1, int arg2, int arg3);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static AudioBusLayout godot_icall_0_98(IntPtr method, IntPtr ptr);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_1_99(IntPtr method, IntPtr ptr, byte[] arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static byte[] godot_icall_0_100(IntPtr method, IntPtr ptr);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static AudioStream godot_icall_0_101(IntPtr method, IntPtr ptr);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static ShortCut godot_icall_0_102(IntPtr method, IntPtr ptr);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static ButtonGroup godot_icall_0_103(IntPtr method, IntPtr ptr);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_2_104(IntPtr method, IntPtr ptr, ref Vector2 arg1, bool arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static bool godot_icall_1_105(IntPtr method, IntPtr ptr, ref Vector2 arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_2_106(IntPtr method, IntPtr ptr, ref Rect2 arg1, bool arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_5_107(IntPtr method, IntPtr ptr, int arg1, int arg2, ref Rect2 arg3, ref Vector2 arg4, float arg5);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static Texture godot_icall_1_108(IntPtr method, IntPtr ptr, int arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static object godot_icall_2_109(IntPtr method, IntPtr ptr, int arg1, int arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static BitmapFont godot_icall_0_110(IntPtr method, IntPtr ptr);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static BaseButton godot_icall_0_111(IntPtr method, IntPtr ptr);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static Object godot_icall_1_112(IntPtr method, IntPtr ptr, object[] arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static object godot_icall_1_113(IntPtr method, IntPtr ptr, ref Vector2 arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static object godot_icall_1_114(IntPtr method, IntPtr ptr, ref Vector3 arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static bool godot_icall_1_115(IntPtr method, IntPtr ptr, ref Vector3 arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_3_116(IntPtr method, IntPtr ptr, float arg1, float arg2, float arg3);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static Environment godot_icall_0_117(IntPtr method, IntPtr ptr);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static Viewport godot_icall_0_118(IntPtr method, IntPtr ptr);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_1_119(IntPtr method, IntPtr ptr, object arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static object godot_icall_0_120(IntPtr method, IntPtr ptr);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_0_121(IntPtr method, IntPtr ptr);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_1_122(IntPtr method, IntPtr ptr, ref Color arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static object godot_icall_0_123(IntPtr method, IntPtr ptr);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_5_124(IntPtr method, IntPtr ptr, ref Vector2 arg1, ref Vector2 arg2, ref Color arg3, float arg4, bool arg5);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_4_125(IntPtr method, IntPtr ptr, Vector2[] arg1, ref Color arg2, float arg3, bool arg4);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_4_126(IntPtr method, IntPtr ptr, Vector2[] arg1, Color[] arg2, float arg3, bool arg4);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_3_127(IntPtr method, IntPtr ptr, ref Rect2 arg1, ref Color arg2, bool arg3);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_3_128(IntPtr method, IntPtr ptr, ref Vector2 arg1, float arg2, ref Color arg3);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_4_129(IntPtr method, IntPtr ptr, IntPtr arg1, ref Vector2 arg2, ref Color arg3, IntPtr arg4);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_6_130(IntPtr method, IntPtr ptr, IntPtr arg1, ref Rect2 arg2, bool arg3, ref Color arg4, bool arg5, IntPtr arg6);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_7_131(IntPtr method, IntPtr ptr, IntPtr arg1, ref Rect2 arg2, ref Rect2 arg3, ref Color arg4, bool arg5, IntPtr arg6, bool arg7);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_2_132(IntPtr method, IntPtr ptr, IntPtr arg1, ref Rect2 arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_6_133(IntPtr method, IntPtr ptr, Vector2[] arg1, Color[] arg2, Vector2[] arg3, IntPtr arg4, float arg5, IntPtr arg6);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_5_134(IntPtr method, IntPtr ptr, Vector2[] arg1, Color[] arg2, Vector2[] arg3, IntPtr arg4, IntPtr arg5);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_5_135(IntPtr method, IntPtr ptr, Vector2[] arg1, ref Color arg2, Vector2[] arg3, IntPtr arg4, IntPtr arg5);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_5_136(IntPtr method, IntPtr ptr, IntPtr arg1, ref Vector2 arg2, string arg3, ref Color arg4, int arg5);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static float godot_icall_5_137(IntPtr method, IntPtr ptr, IntPtr arg1, ref Vector2 arg2, string arg3, string arg4, ref Color arg5);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_3_138(IntPtr method, IntPtr ptr, ref Vector2 arg1, float arg2, ref Vector2 arg3);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_1_139(IntPtr method, IntPtr ptr, ref Transform2D arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static object godot_icall_0_140(IntPtr method, IntPtr ptr);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static World2D godot_icall_0_141(IntPtr method, IntPtr ptr);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static Material godot_icall_0_142(IntPtr method, IntPtr ptr);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static object godot_icall_1_143(IntPtr method, IntPtr ptr, ref Vector2 arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static InputEvent godot_icall_1_144(IntPtr method, IntPtr ptr, IntPtr arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static int godot_icall_1_145(IntPtr method, IntPtr ptr, IntPtr arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_2_146(IntPtr method, IntPtr ptr, int arg1, ref Transform arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static object godot_icall_1_147(IntPtr method, IntPtr ptr, int arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static Object godot_icall_1_148(IntPtr method, IntPtr ptr, int arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static Object godot_icall_2_149(IntPtr method, IntPtr ptr, int arg1, int arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_2_150(IntPtr method, IntPtr ptr, int arg1, ref Transform2D arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static object godot_icall_1_151(IntPtr method, IntPtr ptr, int arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_1_152(IntPtr method, IntPtr ptr, Vector2[] arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static Vector2[] godot_icall_0_153(IntPtr method, IntPtr ptr);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static Shape godot_icall_0_154(IntPtr method, IntPtr ptr);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static Shape2D godot_icall_0_155(IntPtr method, IntPtr ptr);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static ColorPicker godot_icall_0_156(IntPtr method, IntPtr ptr);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_1_157(IntPtr method, IntPtr ptr, Vector3[] arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static Vector3[] godot_icall_0_158(IntPtr method, IntPtr ptr);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_3_159(IntPtr method, IntPtr ptr, string arg1, string arg2, object arg3);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static object godot_icall_3_160(IntPtr method, IntPtr ptr, string arg1, string arg2, object arg3);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static bool godot_icall_2_161(IntPtr method, IntPtr ptr, string arg1, string arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static string[] godot_icall_1_162(IntPtr method, IntPtr ptr, string arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static int godot_icall_1_163(IntPtr method, IntPtr ptr, string arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static Button godot_icall_0_164(IntPtr method, IntPtr ptr);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_2_165(IntPtr method, IntPtr ptr, IntPtr arg1, ref Rect2 arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static Control godot_icall_0_166(IntPtr method, IntPtr ptr);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static Theme godot_icall_0_167(IntPtr method, IntPtr ptr);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_2_168(IntPtr method, IntPtr ptr, string arg1, ref Color arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static Texture godot_icall_2_169(IntPtr method, IntPtr ptr, string arg1, string arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static StyleBox godot_icall_2_170(IntPtr method, IntPtr ptr, string arg1, string arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static Font godot_icall_2_171(IntPtr method, IntPtr ptr, string arg1, string arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static object godot_icall_2_172(IntPtr method, IntPtr ptr, string arg1, string arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static string godot_icall_1_173(IntPtr method, IntPtr ptr, ref Vector2 arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static int godot_icall_1_174(IntPtr method, IntPtr ptr, ref Vector2 arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_2_175(IntPtr method, IntPtr ptr, object arg1, IntPtr arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static Image godot_icall_1_176(IntPtr method, IntPtr ptr, int arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static int godot_icall_5_177(IntPtr method, IntPtr ptr, ref Vector2 arg1, float arg2, float arg3, int arg4, int arg5);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static object godot_icall_1_178(IntPtr method, IntPtr ptr, int arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static float godot_icall_1_179(IntPtr method, IntPtr ptr, float arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_4_180(IntPtr method, IntPtr ptr, ref Vector2 arg1, ref Vector2 arg2, ref Vector2 arg3, int arg4);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_2_181(IntPtr method, IntPtr ptr, int arg1, ref Vector2 arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static object godot_icall_2_182(IntPtr method, IntPtr ptr, int arg1, float arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static object godot_icall_1_183(IntPtr method, IntPtr ptr, float arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static object godot_icall_2_184(IntPtr method, IntPtr ptr, float arg1, bool arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static Vector2[] godot_icall_2_185(IntPtr method, IntPtr ptr, int arg1, float arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_4_186(IntPtr method, IntPtr ptr, ref Vector3 arg1, ref Vector3 arg2, ref Vector3 arg3, int arg4);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_2_187(IntPtr method, IntPtr ptr, int arg1, ref Vector3 arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static object godot_icall_2_188(IntPtr method, IntPtr ptr, int arg1, float arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static object godot_icall_1_189(IntPtr method, IntPtr ptr, float arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static object godot_icall_2_190(IntPtr method, IntPtr ptr, float arg1, bool arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static float[] godot_icall_0_191(IntPtr method, IntPtr ptr);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static Vector3[] godot_icall_2_192(IntPtr method, IntPtr ptr, int arg1, float arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static Curve godot_icall_0_193(IntPtr method, IntPtr ptr);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static DynamicFontData godot_icall_0_194(IntPtr method, IntPtr ptr);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static DynamicFontData godot_icall_1_195(IntPtr method, IntPtr ptr, int arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static CubeMap godot_icall_0_196(IntPtr method, IntPtr ptr);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_1_197(IntPtr method, IntPtr ptr, string[] arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static VBoxContainer godot_icall_0_198(IntPtr method, IntPtr ptr);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_5_199(IntPtr method, IntPtr ptr, IntPtr arg1, ref Vector2 arg2, string arg3, ref Color arg4, int arg5);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static float godot_icall_5_200(IntPtr method, IntPtr ptr, IntPtr arg1, ref Vector2 arg2, int arg3, int arg4, ref Color arg5);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static object godot_icall_1_201(IntPtr method, IntPtr ptr, object[] arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static object godot_icall_1_202(IntPtr method, IntPtr ptr, object arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static bool godot_icall_1_203(IntPtr method, IntPtr ptr, bool arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static GDNativeLibrary godot_icall_0_204(IntPtr method, IntPtr ptr);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static object godot_icall_3_205(IntPtr method, IntPtr ptr, string arg1, object[] arg2, object[] arg3);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static GIProbeData godot_icall_0_206(IntPtr method, IntPtr ptr);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_2_207(IntPtr method, IntPtr ptr, IntPtr arg1, bool arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_1_208(IntPtr method, IntPtr ptr, ref Transform arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_1_209(IntPtr method, IntPtr ptr, int[] arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static int[] godot_icall_0_210(IntPtr method, IntPtr ptr);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_2_211(IntPtr method, IntPtr ptr, float arg1, ref Color arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_2_212(IntPtr method, IntPtr ptr, int arg1, ref Color arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static object godot_icall_1_213(IntPtr method, IntPtr ptr, int arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static object godot_icall_1_214(IntPtr method, IntPtr ptr, float arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_1_215(IntPtr method, IntPtr ptr, float[] arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_1_216(IntPtr method, IntPtr ptr, Color[] arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static Color[] godot_icall_0_217(IntPtr method, IntPtr ptr);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static Gradient godot_icall_0_218(IntPtr method, IntPtr ptr);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static int godot_icall_4_219(IntPtr method, IntPtr ptr, string arg1, int arg2, string arg3, int arg4);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static bool godot_icall_4_220(IntPtr method, IntPtr ptr, string arg1, int arg2, string arg3, int arg4);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_4_221(IntPtr method, IntPtr ptr, string arg1, int arg2, string arg3, int arg4);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_9_222(IntPtr method, IntPtr ptr, int arg1, bool arg2, int arg3, ref Color arg4, bool arg5, int arg6, ref Color arg7, IntPtr arg8, IntPtr arg9);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static MeshLibrary godot_icall_0_223(IntPtr method, IntPtr ptr);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_5_224(IntPtr method, IntPtr ptr, int arg1, int arg2, int arg3, int arg4, int arg5);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static int godot_icall_3_225(IntPtr method, IntPtr ptr, int arg1, int arg2, int arg3);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_4_226(IntPtr method, IntPtr ptr, bool arg1, bool arg2, int arg3, int arg4);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static int godot_icall_2_227(IntPtr method, IntPtr ptr, int arg1, ref Rect3 arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static object godot_icall_1_228(IntPtr method, IntPtr ptr, int arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static int godot_icall_4_229(IntPtr method, IntPtr ptr, string arg1, int arg2, bool arg3, bool arg4);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static StreamPeer godot_icall_0_230(IntPtr method, IntPtr ptr);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static int godot_icall_4_231(IntPtr method, IntPtr ptr, int arg1, string arg2, string[] arg3, byte[] arg4);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static int godot_icall_4_232(IntPtr method, IntPtr ptr, int arg1, string arg2, string[] arg3, string arg4);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static int godot_icall_1_233(IntPtr method, IntPtr ptr, byte[] arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static Dictionary<object, object> godot_icall_0_234(IntPtr method, IntPtr ptr);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static int godot_icall_0_235(IntPtr method, IntPtr ptr);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static string godot_icall_1_236(IntPtr method, IntPtr ptr, Dictionary<object, object> arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static int godot_icall_5_237(IntPtr method, IntPtr ptr, string arg1, string[] arg2, bool arg3, int arg4, string arg5);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static int godot_icall_2_238(IntPtr method, IntPtr ptr, string arg1, int arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_4_239(IntPtr method, IntPtr ptr, int arg1, int arg2, bool arg3, int arg4);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_5_240(IntPtr method, IntPtr ptr, int arg1, int arg2, bool arg3, int arg4, byte[] arg5);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static int godot_icall_3_241(IntPtr method, IntPtr ptr, int arg1, int arg2, float arg3);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_3_242(IntPtr method, IntPtr ptr, IntPtr arg1, ref Rect2 arg2, ref Vector2 arg3);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_4_243(IntPtr method, IntPtr ptr, IntPtr arg1, IntPtr arg2, ref Rect2 arg3, ref Vector2 arg4);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static Image godot_icall_1_244(IntPtr method, IntPtr ptr, ref Rect2 arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_3_245(IntPtr method, IntPtr ptr, int arg1, int arg2, ref Color arg3);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static object godot_icall_2_246(IntPtr method, IntPtr ptr, int arg1, int arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_4_247(IntPtr method, IntPtr ptr, int arg1, int arg2, int arg3, int arg4);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_2_248(IntPtr method, IntPtr ptr, IntPtr arg1, int arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_1_249(IntPtr method, IntPtr ptr, ref Plane arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_4_250(IntPtr method, IntPtr ptr, int arg1, int arg2, float arg3, bool arg4);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_4_251(IntPtr method, IntPtr ptr, int arg1, float arg2, float arg3, float arg4);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_2_252(IntPtr method, IntPtr ptr, IntPtr arg1, ref Vector2 arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static bool godot_icall_1_253(IntPtr method, IntPtr ptr, IntPtr arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static InputEvent godot_icall_2_254(IntPtr method, IntPtr ptr, ref Transform2D arg1, ref Vector2 arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static bool godot_icall_2_255(IntPtr method, IntPtr ptr, string arg1, IntPtr arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static object[] godot_icall_1_256(IntPtr method, IntPtr ptr, string arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static bool godot_icall_2_257(IntPtr method, IntPtr ptr, IntPtr arg1, string arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static Dictionary<object, object> godot_icall_1_258(IntPtr method, IntPtr ptr, bool arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_3_259(IntPtr method, IntPtr ptr, string arg1, IntPtr arg2, bool arg3);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_2_260(IntPtr method, IntPtr ptr, IntPtr arg1, bool arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_2_261(IntPtr method, IntPtr ptr, int arg1, ref Rect2 arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static object godot_icall_1_262(IntPtr method, IntPtr ptr, int arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_2_263(IntPtr method, IntPtr ptr, int arg1, object arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static object godot_icall_1_264(IntPtr method, IntPtr ptr, int arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static int godot_icall_2_265(IntPtr method, IntPtr ptr, ref Vector2 arg1, bool arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static VScrollBar godot_icall_0_266(IntPtr method, IntPtr ptr);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static Dictionary<object, object> godot_icall_1_267(IntPtr method, IntPtr ptr, ref Vector3 arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static object godot_icall_5_268(IntPtr method, IntPtr ptr, ref Vector3 arg1, ref Vector3 arg2, float arg3, int arg4, float arg5);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static bool godot_icall_2_269(IntPtr method, IntPtr ptr, ref Transform arg1, ref Vector3 arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static Dictionary<object, object> godot_icall_1_270(IntPtr method, IntPtr ptr, ref Vector2 arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static object godot_icall_5_271(IntPtr method, IntPtr ptr, ref Vector2 arg1, ref Vector2 arg2, float arg3, int arg4, float arg5);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static bool godot_icall_2_272(IntPtr method, IntPtr ptr, ref Transform2D arg1, ref Vector2 arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static int godot_icall_2_273(IntPtr method, IntPtr ptr, ref Vector2 arg1, IntPtr arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static OccluderPolygon2D godot_icall_0_274(IntPtr method, IntPtr ptr);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static PopupMenu godot_icall_0_275(IntPtr method, IntPtr ptr);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static bool godot_icall_1_276(IntPtr method, IntPtr ptr, float arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static ArrayMesh godot_icall_1_277(IntPtr method, IntPtr ptr, float arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static TriangleMesh godot_icall_0_278(IntPtr method, IntPtr ptr);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static int godot_icall_2_279(IntPtr method, IntPtr ptr, IntPtr arg1, int arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static int godot_icall_1_280(IntPtr method, IntPtr ptr, IntPtr arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_2_281(IntPtr method, IntPtr ptr, int arg1, ref Plane arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static object godot_icall_1_282(IntPtr method, IntPtr ptr, int arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_2_283(IntPtr method, IntPtr ptr, int arg1, int[] arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static int[] godot_icall_1_284(IntPtr method, IntPtr ptr, int arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_2_285(IntPtr method, IntPtr ptr, int arg1, float[] arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static float[] godot_icall_1_286(IntPtr method, IntPtr ptr, int arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static Mesh godot_icall_0_287(IntPtr method, IntPtr ptr);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static Mesh godot_icall_1_288(IntPtr method, IntPtr ptr, int arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static NavigationMesh godot_icall_1_289(IntPtr method, IntPtr ptr, int arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static Shape godot_icall_1_290(IntPtr method, IntPtr ptr, int arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static MultiMesh godot_icall_0_291(IntPtr method, IntPtr ptr);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static int godot_icall_3_292(IntPtr method, IntPtr ptr, IntPtr arg1, ref Transform arg2, IntPtr arg3);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static Vector3[] godot_icall_3_293(IntPtr method, IntPtr ptr, ref Vector3 arg1, ref Vector3 arg2, bool arg3);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static object godot_icall_3_294(IntPtr method, IntPtr ptr, ref Vector3 arg1, ref Vector3 arg2, bool arg3);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static Object godot_icall_1_295(IntPtr method, IntPtr ptr, ref Vector3 arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static int godot_icall_3_296(IntPtr method, IntPtr ptr, IntPtr arg1, ref Transform2D arg2, IntPtr arg3);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static Vector2[] godot_icall_3_297(IntPtr method, IntPtr ptr, ref Vector2 arg1, ref Vector2 arg2, bool arg3);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static Object godot_icall_1_298(IntPtr method, IntPtr ptr, ref Vector2 arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static NavigationMesh godot_icall_0_299(IntPtr method, IntPtr ptr);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_2_300(IntPtr method, IntPtr ptr, Vector2[] arg1, int arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_2_301(IntPtr method, IntPtr ptr, int arg1, Vector2[] arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static Vector2[] godot_icall_1_302(IntPtr method, IntPtr ptr, int arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static NavigationPolygon godot_icall_0_303(IntPtr method, IntPtr ptr);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static int godot_icall_4_304(IntPtr method, IntPtr ptr, int arg1, int arg2, int arg3, int arg4);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static int godot_icall_4_305(IntPtr method, IntPtr ptr, string arg1, int arg2, int arg3, int arg4);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static Node godot_icall_1_306(IntPtr method, IntPtr ptr, int arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static bool godot_icall_1_307(IntPtr method, IntPtr ptr, IntPtr arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static Node godot_icall_1_308(IntPtr method, IntPtr ptr, IntPtr arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static Node godot_icall_0_309(IntPtr method, IntPtr ptr);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static Node godot_icall_3_310(IntPtr method, IntPtr ptr, string arg1, bool arg2, bool arg3);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static object[] godot_icall_1_311(IntPtr method, IntPtr ptr, IntPtr arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_1_312(IntPtr method, IntPtr ptr, IntPtr arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_2_313(IntPtr method, IntPtr ptr, IntPtr arg1, int arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static SceneTree godot_icall_0_314(IntPtr method, IntPtr ptr);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_2_315(IntPtr method, IntPtr ptr, string arg1, object[] arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_3_316(IntPtr method, IntPtr ptr, int arg1, string arg2, object[] arg3);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_2_317(IntPtr method, IntPtr ptr, string arg1, object arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_3_318(IntPtr method, IntPtr ptr, int arg1, string arg2, object arg3);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static float godot_icall_1_319(IntPtr method, IntPtr ptr, ref Vector2 arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static object godot_icall_1_320(IntPtr method, IntPtr ptr, IntPtr arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static object godot_icall_1_321(IntPtr method, IntPtr ptr, string arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static Script godot_icall_0_322(IntPtr method, IntPtr ptr);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_2_323(IntPtr method, IntPtr ptr, string arg1, object[] arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static object godot_icall_2_324(IntPtr method, IntPtr ptr, string arg1, object[] arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static object godot_icall_2_325(IntPtr method, IntPtr ptr, string arg1, object[] arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static int godot_icall_5_326(IntPtr method, IntPtr ptr, string arg1, IntPtr arg2, string arg3, object[] arg4, int arg5);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_3_327(IntPtr method, IntPtr ptr, string arg1, IntPtr arg2, string arg3);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static bool godot_icall_3_328(IntPtr method, IntPtr ptr, string arg1, IntPtr arg2, string arg3);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_3_329(IntPtr method, IntPtr ptr, IntPtr arg1, string arg2, int arg3);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static int godot_icall_1_330(IntPtr method, IntPtr ptr, bool arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static int godot_icall_1_331(IntPtr method, IntPtr ptr, object arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static SceneState godot_icall_0_332(IntPtr method, IntPtr ptr);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static int godot_icall_1_333(IntPtr method, IntPtr ptr, object arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static int godot_icall_1_334(IntPtr method, IntPtr ptr, byte[] arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static int godot_icall_3_335(IntPtr method, IntPtr ptr, int arg1, string arg2, int arg3);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_2_336(IntPtr method, IntPtr ptr, int arg1, IntPtr arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static CurveTexture godot_icall_0_337(IntPtr method, IntPtr ptr);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static GradientTexture godot_icall_0_338(IntPtr method, IntPtr ptr);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static Curve3D godot_icall_0_339(IntPtr method, IntPtr ptr);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static Curve2D godot_icall_0_340(IntPtr method, IntPtr ptr);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_1_341(IntPtr method, IntPtr ptr, int arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static Physics2DDirectSpaceState godot_icall_0_342(IntPtr method, IntPtr ptr);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static object[] godot_icall_5_343(IntPtr method, IntPtr ptr, ref Vector2 arg1, int arg2, object[] arg3, int arg4, int arg5);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static Dictionary<object, object> godot_icall_5_344(IntPtr method, IntPtr ptr, ref Vector2 arg1, ref Vector2 arg2, object[] arg3, int arg4, int arg5);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static object[] godot_icall_2_345(IntPtr method, IntPtr ptr, IntPtr arg1, int arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static object[] godot_icall_1_346(IntPtr method, IntPtr ptr, IntPtr arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static Dictionary<object, object> godot_icall_1_347(IntPtr method, IntPtr ptr, IntPtr arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_2_348(IntPtr method, IntPtr ptr, IntPtr arg1, object arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static int godot_icall_1_349(IntPtr method, IntPtr ptr, IntPtr arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_1_350(IntPtr method, IntPtr ptr, IntPtr arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_2_351(IntPtr method, IntPtr ptr, IntPtr arg1, bool arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static bool godot_icall_1_352(IntPtr method, IntPtr ptr, IntPtr arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_3_353(IntPtr method, IntPtr ptr, IntPtr arg1, int arg2, float arg3);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static float godot_icall_2_354(IntPtr method, IntPtr ptr, IntPtr arg1, int arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static Physics2DDirectSpaceState godot_icall_1_355(IntPtr method, IntPtr ptr, IntPtr arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_2_356(IntPtr method, IntPtr ptr, IntPtr arg1, IntPtr arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_1_357(IntPtr method, IntPtr ptr, IntPtr arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_2_358(IntPtr method, IntPtr ptr, IntPtr arg1, int arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_3_359(IntPtr method, IntPtr ptr, IntPtr arg1, IntPtr arg2, ref Transform2D arg3);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_3_360(IntPtr method, IntPtr ptr, IntPtr arg1, int arg2, IntPtr arg3);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_3_361(IntPtr method, IntPtr ptr, IntPtr arg1, int arg2, ref Transform2D arg3);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_3_362(IntPtr method, IntPtr ptr, IntPtr arg1, int arg2, bool arg3);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_2_363(IntPtr method, IntPtr ptr, IntPtr arg1, int arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static object godot_icall_2_364(IntPtr method, IntPtr ptr, IntPtr arg1, int arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_3_365(IntPtr method, IntPtr ptr, IntPtr arg1, int arg2, object arg3);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_2_366(IntPtr method, IntPtr ptr, IntPtr arg1, ref Transform2D arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static object godot_icall_1_367(IntPtr method, IntPtr ptr, IntPtr arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_3_368(IntPtr method, IntPtr ptr, IntPtr arg1, IntPtr arg2, string arg3);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_2_369(IntPtr method, IntPtr ptr, int arg1, bool arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_3_370(IntPtr method, IntPtr ptr, IntPtr arg1, ref Vector2 arg2, ref Vector2 arg3);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_2_371(IntPtr method, IntPtr ptr, IntPtr arg1, ref Vector2 arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_4_372(IntPtr method, IntPtr ptr, IntPtr arg1, IntPtr arg2, string arg3, object arg4);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static bool godot_icall_5_373(IntPtr method, IntPtr ptr, IntPtr arg1, ref Transform2D arg2, ref Vector2 arg3, float arg4, IntPtr arg5);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_3_374(IntPtr method, IntPtr ptr, ref Vector2 arg1, IntPtr arg2, IntPtr arg3);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_5_375(IntPtr method, IntPtr ptr, ref Vector2 arg1, ref Vector2 arg2, ref Vector2 arg3, IntPtr arg4, IntPtr arg5);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_4_376(IntPtr method, IntPtr ptr, ref Vector2 arg1, ref Vector2 arg2, IntPtr arg3, IntPtr arg4);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_1_377(IntPtr method, IntPtr ptr, object[] arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_2_378(IntPtr method, IntPtr ptr, ref Vector3 arg1, ref Vector3 arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static PhysicsDirectSpaceState godot_icall_0_379(IntPtr method, IntPtr ptr);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static Dictionary<object, object> godot_icall_5_380(IntPtr method, IntPtr ptr, ref Vector3 arg1, ref Vector3 arg2, object[] arg3, int arg4, int arg5);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static object[] godot_icall_2_381(IntPtr method, IntPtr ptr, IntPtr arg1, ref Vector3 arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static PhysicsDirectSpaceState godot_icall_1_382(IntPtr method, IntPtr ptr, IntPtr arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_3_383(IntPtr method, IntPtr ptr, IntPtr arg1, IntPtr arg2, ref Transform arg3);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_3_384(IntPtr method, IntPtr ptr, IntPtr arg1, int arg2, ref Transform arg3);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static object godot_icall_2_385(IntPtr method, IntPtr ptr, IntPtr arg1, int arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_2_386(IntPtr method, IntPtr ptr, IntPtr arg1, ref Transform arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static object godot_icall_1_387(IntPtr method, IntPtr ptr, IntPtr arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_3_388(IntPtr method, IntPtr ptr, IntPtr arg1, ref Vector3 arg2, ref Vector3 arg3);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_2_389(IntPtr method, IntPtr ptr, IntPtr arg1, ref Vector3 arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_4_390(IntPtr method, IntPtr ptr, IntPtr arg1, ref Vector3 arg2, IntPtr arg3, ref Vector3 arg4);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static object godot_icall_1_391(IntPtr method, IntPtr ptr, IntPtr arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_4_392(IntPtr method, IntPtr ptr, IntPtr arg1, ref Transform arg2, IntPtr arg3, ref Transform arg4);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static bool godot_icall_2_393(IntPtr method, IntPtr ptr, IntPtr arg1, int arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_4_394(IntPtr method, IntPtr ptr, IntPtr arg1, int arg2, int arg3, float arg4);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static float godot_icall_3_395(IntPtr method, IntPtr ptr, IntPtr arg1, int arg2, int arg3);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_4_396(IntPtr method, IntPtr ptr, IntPtr arg1, int arg2, int arg3, bool arg4);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static bool godot_icall_3_397(IntPtr method, IntPtr ptr, IntPtr arg1, int arg2, int arg3);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static object godot_icall_0_398(IntPtr method, IntPtr ptr);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_2_399(IntPtr method, IntPtr ptr, Vector2[] arg1, int[] arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static Vector2[] godot_icall_2_400(IntPtr method, IntPtr ptr, ref Vector2 arg1, ref Vector2 arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_4_401(IntPtr method, IntPtr ptr, IntPtr arg1, string arg2, int arg3, int arg4);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_3_402(IntPtr method, IntPtr ptr, string arg1, int arg2, int arg3);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_3_403(IntPtr method, IntPtr ptr, string arg1, string arg2, int arg3);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_4_404(IntPtr method, IntPtr ptr, IntPtr arg1, IntPtr arg2, int arg3, bool arg4);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_3_405(IntPtr method, IntPtr ptr, IntPtr arg1, int arg2, bool arg3);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_3_406(IntPtr method, IntPtr ptr, int arg1, IntPtr arg2, bool arg3);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static ShortCut godot_icall_1_407(IntPtr method, IntPtr ptr, int arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_1_408(IntPtr method, IntPtr ptr, Dictionary<object, object> arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static Object godot_icall_1_409(IntPtr method, IntPtr ptr, string arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static RegExMatch godot_icall_3_410(IntPtr method, IntPtr ptr, string arg1, int arg2, int arg3);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static string godot_icall_5_411(IntPtr method, IntPtr ptr, string arg1, string arg2, bool arg3, int arg4, int arg5);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static string godot_icall_1_412(IntPtr method, IntPtr ptr, object arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static Resource godot_icall_1_413(IntPtr method, IntPtr ptr, bool arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static Resource godot_icall_0_414(IntPtr method, IntPtr ptr);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static Resource godot_icall_1_415(IntPtr method, IntPtr ptr, string arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_3_416(IntPtr method, IntPtr ptr, int arg1, bool arg2, int arg3);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_2_417(IntPtr method, IntPtr ptr, ref Vector2 arg1, ref Vector2 arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static bool godot_icall_3_418(IntPtr method, IntPtr ptr, ref Vector2 arg1, float arg2, IntPtr arg3);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static Room godot_icall_0_419(IntPtr method, IntPtr ptr);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_2_420(IntPtr method, IntPtr ptr, int arg1, bool arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static PackedScene godot_icall_1_421(IntPtr method, IntPtr ptr, int arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static string[] godot_icall_1_422(IntPtr method, IntPtr ptr, int arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static object godot_icall_2_423(IntPtr method, IntPtr ptr, int arg1, int arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static object[] godot_icall_1_424(IntPtr method, IntPtr ptr, int arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static SceneTreeTimer godot_icall_2_425(IntPtr method, IntPtr ptr, float arg1, bool arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_4_426(IntPtr method, IntPtr ptr, int arg1, int arg2, ref Vector2 arg3, int arg4);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_4_427(IntPtr method, IntPtr ptr, int arg1, string arg2, string arg3, object[] arg4);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_3_428(IntPtr method, IntPtr ptr, int arg1, string arg2, int arg3);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_4_429(IntPtr method, IntPtr ptr, int arg1, string arg2, string arg3, object arg4);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_3_430(IntPtr method, IntPtr ptr, string arg1, string arg2, object[] arg3);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static Texture godot_icall_1_431(IntPtr method, IntPtr ptr, string arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static Shader godot_icall_0_432(IntPtr method, IntPtr ptr);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static bool godot_icall_3_433(IntPtr method, IntPtr ptr, ref Transform2D arg1, IntPtr arg2, ref Transform2D arg3);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static bool godot_icall_5_434(IntPtr method, IntPtr ptr, ref Transform2D arg1, ref Vector2 arg2, IntPtr arg3, ref Transform2D arg4, ref Vector2 arg5);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static object godot_icall_3_435(IntPtr method, IntPtr ptr, ref Transform2D arg1, IntPtr arg2, ref Transform2D arg3);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static object godot_icall_5_436(IntPtr method, IntPtr ptr, ref Transform2D arg1, ref Vector2 arg2, IntPtr arg3, ref Transform2D arg4, ref Vector2 arg5);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static InputEvent godot_icall_0_437(IntPtr method, IntPtr ptr);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static Spatial godot_icall_0_438(IntPtr method, IntPtr ptr);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static World godot_icall_0_439(IntPtr method, IntPtr ptr);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static SpatialGizmo godot_icall_0_440(IntPtr method, IntPtr ptr);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_2_441(IntPtr method, IntPtr ptr, ref Vector3 arg1, float arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_3_442(IntPtr method, IntPtr ptr, ref Vector3 arg1, ref Vector3 arg2, ref Vector3 arg3);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static LineEdit godot_icall_0_443(IntPtr method, IntPtr ptr);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_3_444(IntPtr method, IntPtr ptr, string arg1, IntPtr arg2, int arg3);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static Texture godot_icall_2_445(IntPtr method, IntPtr ptr, string arg1, int arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_3_446(IntPtr method, IntPtr ptr, string arg1, int arg2, IntPtr arg3);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static object[] godot_icall_1_447(IntPtr method, IntPtr ptr, byte[] arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static StreamPeerBuffer godot_icall_0_448(IntPtr method, IntPtr ptr);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static int godot_icall_1_449(IntPtr method, IntPtr ptr, IntPtr arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static int godot_icall_3_450(IntPtr method, IntPtr ptr, IntPtr arg1, bool arg2, string arg3);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static bool godot_icall_2_451(IntPtr method, IntPtr ptr, ref Vector2 arg1, ref Rect2 arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_2_452(IntPtr method, IntPtr ptr, IntPtr arg1, ref Rect2 arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_6_453(IntPtr method, IntPtr ptr, Vector3[] arg1, Vector2[] arg2, Color[] arg3, Vector2[] arg4, Vector3[] arg5, object[] arg6);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_3_454(IntPtr method, IntPtr ptr, IntPtr arg1, int arg2, ref Transform arg3);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static Mesh godot_icall_1_455(IntPtr method, IntPtr ptr, IntPtr arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static int godot_icall_2_456(IntPtr method, IntPtr ptr, int arg1, string arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static StreamPeerTCP godot_icall_0_457(IntPtr method, IntPtr ptr);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static Control godot_icall_1_458(IntPtr method, IntPtr ptr, int arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static Popup godot_icall_0_459(IntPtr method, IntPtr ptr);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static int[] godot_icall_4_460(IntPtr method, IntPtr ptr, string arg1, int arg2, int arg3, int arg4);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_4_461(IntPtr method, IntPtr ptr, string arg1, string arg2, ref Color arg3, bool arg4);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_5_462(IntPtr method, IntPtr ptr, IntPtr arg1, ref Vector2 arg2, ref Color arg3, bool arg4, IntPtr arg5);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_6_463(IntPtr method, IntPtr ptr, IntPtr arg1, ref Rect2 arg2, bool arg3, ref Color arg4, bool arg5, IntPtr arg6);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_7_464(IntPtr method, IntPtr ptr, IntPtr arg1, ref Rect2 arg2, ref Rect2 arg3, ref Color arg4, bool arg5, IntPtr arg6, bool arg7);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static Image godot_icall_0_465(IntPtr method, IntPtr ptr);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static BitMap godot_icall_0_466(IntPtr method, IntPtr ptr);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_3_467(IntPtr method, IntPtr ptr, string arg1, string arg2, IntPtr arg3);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_3_468(IntPtr method, IntPtr ptr, string arg1, string arg2, ref Color arg3);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static Font godot_icall_0_469(IntPtr method, IntPtr ptr);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static TileSet godot_icall_0_470(IntPtr method, IntPtr ptr);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_6_471(IntPtr method, IntPtr ptr, int arg1, int arg2, int arg3, bool arg4, bool arg5, bool arg6);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_5_472(IntPtr method, IntPtr ptr, ref Vector2 arg1, int arg2, bool arg3, bool arg4, bool arg5);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static object godot_icall_2_473(IntPtr method, IntPtr ptr, ref Vector2 arg1, bool arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static ShaderMaterial godot_icall_1_474(IntPtr method, IntPtr ptr, int arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_3_475(IntPtr method, IntPtr ptr, int arg1, int arg2, IntPtr arg3);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static Shape2D godot_icall_2_476(IntPtr method, IntPtr ptr, int arg1, int arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_3_477(IntPtr method, IntPtr ptr, int arg1, int arg2, ref Transform2D arg3);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static object godot_icall_2_478(IntPtr method, IntPtr ptr, int arg1, int arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_4_479(IntPtr method, IntPtr ptr, int arg1, IntPtr arg2, ref Transform2D arg3, bool arg4);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_2_480(IntPtr method, IntPtr ptr, int arg1, object[] arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static NavigationPolygon godot_icall_1_481(IntPtr method, IntPtr ptr, int arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static OccluderPolygon2D godot_icall_1_482(IntPtr method, IntPtr ptr, int arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static TreeItem godot_icall_1_483(IntPtr method, IntPtr ptr, IntPtr arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static TreeItem godot_icall_0_484(IntPtr method, IntPtr ptr);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static object godot_icall_2_485(IntPtr method, IntPtr ptr, IntPtr arg1, int arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static TreeItem godot_icall_1_486(IntPtr method, IntPtr ptr, ref Vector2 arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_5_487(IntPtr method, IntPtr ptr, int arg1, float arg2, float arg3, float arg4, bool arg5);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static Dictionary<object, object> godot_icall_1_488(IntPtr method, IntPtr ptr, int arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_3_489(IntPtr method, IntPtr ptr, int arg1, IntPtr arg2, string arg3);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_3_490(IntPtr method, IntPtr ptr, int arg1, ref Color arg2, bool arg3);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_5_491(IntPtr method, IntPtr ptr, int arg1, IntPtr arg2, int arg3, bool arg4, string arg5);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static Texture godot_icall_2_492(IntPtr method, IntPtr ptr, int arg1, int arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static bool godot_icall_2_493(IntPtr method, IntPtr ptr, IntPtr arg1, string arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static bool godot_icall_8_494(IntPtr method, IntPtr ptr, IntPtr arg1, string arg2, object arg3, object arg4, float arg5, int arg6, int arg7, float arg8);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static bool godot_icall_8_495(IntPtr method, IntPtr ptr, IntPtr arg1, float arg2, string arg3, object arg4, object arg5, object arg6, object arg7, object arg8);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static bool godot_icall_9_496(IntPtr method, IntPtr ptr, IntPtr arg1, string arg2, object arg3, IntPtr arg4, string arg5, float arg6, int arg7, int arg8, float arg9);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static bool godot_icall_9_497(IntPtr method, IntPtr ptr, IntPtr arg1, string arg2, IntPtr arg3, string arg4, object arg5, float arg6, int arg7, int arg8, float arg9);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_3_498(IntPtr method, IntPtr ptr, IntPtr arg1, string arg2, object[] arg3);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_3_499(IntPtr method, IntPtr ptr, IntPtr arg1, string arg2, object arg3);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static VideoStream godot_icall_0_500(IntPtr method, IntPtr ptr);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_3_501(IntPtr method, IntPtr ptr, bool arg1, ref Vector2 arg2, ref Vector2 arg3);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static ViewportTexture godot_icall_0_502(IntPtr method, IntPtr ptr);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static Camera godot_icall_0_503(IntPtr method, IntPtr ptr);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_4_504(IntPtr method, IntPtr ptr, string arg1, int arg2, IntPtr arg3, ref Vector2 arg4);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static VisualScriptNode godot_icall_2_505(IntPtr method, IntPtr ptr, string arg1, int arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_3_506(IntPtr method, IntPtr ptr, string arg1, int arg2, ref Vector2 arg3);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static object godot_icall_2_507(IntPtr method, IntPtr ptr, string arg1, int arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_4_508(IntPtr method, IntPtr ptr, string arg1, int arg2, int arg3, int arg4);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static bool godot_icall_4_509(IntPtr method, IntPtr ptr, string arg1, int arg2, int arg3, int arg4);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_5_510(IntPtr method, IntPtr ptr, string arg1, int arg2, int arg3, int arg4, int arg5);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static bool godot_icall_5_511(IntPtr method, IntPtr ptr, string arg1, int arg2, int arg3, int arg4, int arg5);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_3_512(IntPtr method, IntPtr ptr, string arg1, object arg2, bool arg3);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_2_513(IntPtr method, IntPtr ptr, string arg1, Dictionary<object, object> arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static Dictionary<object, object> godot_icall_1_514(IntPtr method, IntPtr ptr, string arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_3_515(IntPtr method, IntPtr ptr, string arg1, int arg2, string arg3);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_3_516(IntPtr method, IntPtr ptr, IntPtr arg1, string arg2, object[] arg3);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static object[] godot_icall_1_517(IntPtr method, IntPtr ptr, object[] arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static VisualScript godot_icall_0_518(IntPtr method, IntPtr ptr);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static IntPtr godot_icall_2_519(IntPtr method, IntPtr ptr, IntPtr arg1, int arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static TextureButton godot_icall_0_520(IntPtr method, IntPtr ptr);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static Dictionary<object, object> godot_icall_2_521(IntPtr method, IntPtr ptr, string arg1, string arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static object[] godot_icall_2_522(IntPtr method, IntPtr ptr, string arg1, bool arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static object godot_icall_2_523(IntPtr method, IntPtr ptr, IntPtr arg1, string arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static int godot_icall_3_524(IntPtr method, IntPtr ptr, IntPtr arg1, string arg2, object arg3);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static bool godot_icall_3_525(IntPtr method, IntPtr ptr, string arg1, string arg2, bool arg3);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static string[] godot_icall_2_526(IntPtr method, IntPtr ptr, string arg1, bool arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static int godot_icall_2_527(IntPtr method, IntPtr ptr, bool arg1, bool arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static int godot_icall_2_528(IntPtr method, IntPtr ptr, string arg1, string arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static MainLoop godot_icall_0_529(IntPtr method, IntPtr ptr);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static int godot_icall_3_530(IntPtr method, IntPtr ptr, string arg1, int arg2, byte[] arg3);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static int godot_icall_3_531(IntPtr method, IntPtr ptr, string arg1, int arg2, string arg3);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static int godot_icall_3_532(IntPtr method, IntPtr ptr, string arg1, int arg2, int arg3);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static byte[] godot_icall_1_533(IntPtr method, IntPtr ptr, int arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static object[] godot_icall_1_534(IntPtr method, IntPtr ptr, ref Vector3 arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static object[] godot_icall_4_535(IntPtr method, IntPtr ptr, float arg1, float arg2, int arg3, int arg4);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static object[] godot_icall_5_536(IntPtr method, IntPtr ptr, float arg1, float arg2, int arg3, int arg4, int arg5);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static float godot_icall_4_537(IntPtr method, IntPtr ptr, ref Vector2 arg1, ref Vector2 arg2, ref Vector2 arg3, float arg4);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_4_538(IntPtr method, IntPtr ptr, ref Vector2 arg1, ref Vector2 arg2, ref Vector2 arg3, ref Vector2 arg4);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static Vector2[] godot_icall_4_539(IntPtr method, IntPtr ptr, ref Vector2 arg1, ref Vector2 arg2, ref Vector2 arg3, ref Vector2 arg4);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static Vector3[] godot_icall_4_540(IntPtr method, IntPtr ptr, ref Vector3 arg1, ref Vector3 arg2, ref Vector3 arg3, ref Vector3 arg4);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static object godot_icall_3_541(IntPtr method, IntPtr ptr, ref Vector2 arg1, ref Vector2 arg2, ref Vector2 arg3);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static object godot_icall_3_542(IntPtr method, IntPtr ptr, ref Vector3 arg1, ref Vector3 arg2, ref Vector3 arg3);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void godot_icall_5_543(IntPtr method, IntPtr ptr, ref Vector3 arg1, ref Vector3 arg2, ref Vector3 arg3, ref Vector3 arg4, ref Vector3 arg5);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static Vector3[] godot_icall_4_544(IntPtr method, IntPtr ptr, ref Vector3 arg1, ref Vector3 arg2, ref Vector3 arg3, float arg4);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static Vector3[] godot_icall_4_545(IntPtr method, IntPtr ptr, ref Vector3 arg1, ref Vector3 arg2, float arg3, float arg4);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static Vector3[] godot_icall_3_546(IntPtr method, IntPtr ptr, ref Vector3 arg1, ref Vector3 arg2, object[] arg3);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static bool godot_icall_4_547(IntPtr method, IntPtr ptr, ref Vector2 arg1, ref Vector2 arg2, ref Vector2 arg3, ref Vector2 arg4);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static int[] godot_icall_1_548(IntPtr method, IntPtr ptr, Vector2[] arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static Dictionary<object, object> godot_icall_1_549(IntPtr method, IntPtr ptr, Vector2[] arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static string godot_icall_1_550(IntPtr method, IntPtr ptr, byte[] arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static byte[] godot_icall_1_551(IntPtr method, IntPtr ptr, string arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static int godot_icall_4_552(IntPtr method, IntPtr ptr, string arg1, string[] arg2, bool arg3, object[] arg4);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static int godot_icall_1_553(IntPtr method, IntPtr ptr, Dictionary<object, object> arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static int godot_icall_4_554(IntPtr method, IntPtr ptr, string arg1, float arg2, string arg3, string arg4);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static ResourceInteractiveLoader godot_icall_2_555(IntPtr method, IntPtr ptr, string arg1, string arg2);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static Resource godot_icall_3_556(IntPtr method, IntPtr ptr, string arg1, string arg2, bool arg3);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static int godot_icall_3_557(IntPtr method, IntPtr ptr, string arg1, IntPtr arg2, int arg3);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static string[] godot_icall_1_558(IntPtr method, IntPtr ptr, IntPtr arg1);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static int godot_icall_4_559(IntPtr method, IntPtr ptr, IntPtr arg1, string arg2, object arg3, int arg4);
    }
}
