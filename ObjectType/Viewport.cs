using System;

namespace GodotEngine
{
    /// <summary>
    /// A Viewport creates a different view into the screen, or a sub-view inside another viewport. Children 2D Nodes will display on it, and children Camera 3D nodes will render on it too.
    /// Optionally, a viewport can have its own 2D or 3D world, so they don't share what they draw with other viewports.
    /// If a viewport is a child of a [Control], it will automatically take up its same rect and position, otherwise they must be set manually.
    /// Viewports can also choose to be audio listeners, so they generate positional audio depending on a 2D or 3D camera child of it.
    /// Also, viewports can be assigned to different screens in case the devices have multiple screens.
    /// Finally, viewports can also behave as render targets, in which case they will not be visible unless the associated texture is used to draw.
    /// </summary>
    public class Viewport : Node
    {
        /// <summary>
        /// Do not update the render target.
        /// </summary>
        public const int UPDATE_DISABLED = 0;
        /// <summary>
        /// Update the render target once, then switch to [code]UPDATE_DISABLED[/code]
        /// </summary>
        public const int UPDATE_ONCE = 1;
        /// <summary>
        /// Update the render target only when it is visible. This is the default value.
        /// </summary>
        public const int UPDATE_WHEN_VISIBLE = 2;
        public const int UPDATE_ALWAYS = 3;
        public const int SHADOW_ATLAS_QUADRANT_SUBDIV_DISABLED = 0;
        public const int SHADOW_ATLAS_QUADRANT_SUBDIV_1 = 1;
        public const int SHADOW_ATLAS_QUADRANT_SUBDIV_4 = 2;
        public const int SHADOW_ATLAS_QUADRANT_SUBDIV_16 = 3;
        public const int SHADOW_ATLAS_QUADRANT_SUBDIV_64 = 4;
        public const int SHADOW_ATLAS_QUADRANT_SUBDIV_256 = 5;
        public const int SHADOW_ATLAS_QUADRANT_SUBDIV_1024 = 6;
        public const int SHADOW_ATLAS_QUADRANT_SUBDIV_MAX = 7;
        public const int RENDER_INFO_OBJECTS_IN_FRAME = 0;
        public const int RENDER_INFO_VERTICES_IN_FRAME = 1;
        public const int RENDER_INFO_MATERIAL_CHANGES_IN_FRAME = 2;
        public const int RENDER_INFO_SHADER_CHANGES_IN_FRAME = 3;
        public const int RENDER_INFO_SURFACE_CHANGES_IN_FRAME = 4;
        public const int RENDER_INFO_DRAW_CALLS_IN_FRAME = 5;
        public const int RENDER_INFO_MAX = 6;
        public const int DEBUG_DRAW_DISABLED = 0;
        public const int DEBUG_DRAW_UNSHADED = 1;
        public const int DEBUG_DRAW_OVERDRAW = 2;
        public const int DEBUG_DRAW_WIREFRAME = 3;
        public const int MSAA_DISABLED = 0;
        public const int MSAA_2X = 1;
        public const int MSAA_4X = 2;
        public const int MSAA_8X = 3;
        public const int MSAA_16X = 4;

        private const string nativeName = "Viewport";

        public Viewport() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_Viewport_Ctor(this);
        }

        internal Viewport(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_use_arvr");

        public void set_use_arvr(bool use)
        {
            NativeCalls.godot_icall_1_7(method_bind_0, Object.GetPtr(this), use);
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "use_arvr");

        public bool use_arvr()
        {
            return NativeCalls.godot_icall_0_3(method_bind_1, Object.GetPtr(this));
        }

        private IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_size");

        /// <summary>
        /// Set the size of the viewport.
        /// </summary>
        public void set_size(Vector2 size)
        {
            NativeCalls.godot_icall_1_37(method_bind_2, Object.GetPtr(this), ref size);
        }

        private IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_size");

        /// <summary>
        /// Return the viewport rect. If the viewport is child of a control, it will use the same rect as the parent. Otherwise, if the rect is empty, the viewport will use all the allowed space.
        /// </summary>
        public Vector2 get_size()
        {
            object ret = NativeCalls.godot_icall_0_9(method_bind_3, Object.GetPtr(this));
            return (Vector2)ret;
        }

        private IntPtr method_bind_4 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_world_2d");

        public void set_world_2d(World2D world_2d)
        {
            NativeCalls.godot_icall_1_19(method_bind_4, Object.GetPtr(this), Object.GetPtr(world_2d));
        }

        private IntPtr method_bind_5 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_world_2d");

        /// <summary>
        /// Return the 2D world of the viewport.
        /// </summary>
        public World2D get_world_2d()
        {
            return NativeCalls.godot_icall_0_142(method_bind_5, Object.GetPtr(this));
        }

        private IntPtr method_bind_6 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "find_world_2d");

        /// <summary>
        /// Return the 2D world of the viewport.
        /// </summary>
        public World2D find_world_2d()
        {
            return NativeCalls.godot_icall_0_142(method_bind_6, Object.GetPtr(this));
        }

        private IntPtr method_bind_7 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_world");

        /// <summary>
        /// Change the 3D world of the viewport.
        /// </summary>
        public void set_world(World world)
        {
            NativeCalls.godot_icall_1_19(method_bind_7, Object.GetPtr(this), Object.GetPtr(world));
        }

        private IntPtr method_bind_8 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_world");

        /// <summary>
        /// Return the 3D world of the viewport.
        /// </summary>
        public World get_world()
        {
            return NativeCalls.godot_icall_0_436(method_bind_8, Object.GetPtr(this));
        }

        private IntPtr method_bind_9 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "find_world");

        /// <summary>
        /// Return the 3D world of the viewport, or if no such present, the one of the parent viewport.
        /// </summary>
        public World find_world()
        {
            return NativeCalls.godot_icall_0_436(method_bind_9, Object.GetPtr(this));
        }

        private IntPtr method_bind_10 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_canvas_transform");

        /// <summary>
        /// Set the canvas transform of the viewport, useful for changing the on-screen positions of all child [CanvasItem]\ s. This is relative to the global canvas transform of the viewport.
        /// </summary>
        public void set_canvas_transform(Transform2D xform)
        {
            NativeCalls.godot_icall_1_140(method_bind_10, Object.GetPtr(this), ref xform);
        }

        private IntPtr method_bind_11 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_canvas_transform");

        /// <summary>
        /// Get the canvas transform of the viewport.
        /// </summary>
        public Transform2D get_canvas_transform()
        {
            object ret = NativeCalls.godot_icall_0_141(method_bind_11, Object.GetPtr(this));
            return (Transform2D)ret;
        }

        private IntPtr method_bind_12 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_global_canvas_transform");

        /// <summary>
        /// Set the global canvas transform of the viewport. The canvas transform is relative to this.
        /// </summary>
        public void set_global_canvas_transform(Transform2D xform)
        {
            NativeCalls.godot_icall_1_140(method_bind_12, Object.GetPtr(this), ref xform);
        }

        private IntPtr method_bind_13 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_global_canvas_transform");

        /// <summary>
        /// Get the global canvas transform of the viewport.
        /// </summary>
        public Transform2D get_global_canvas_transform()
        {
            object ret = NativeCalls.godot_icall_0_141(method_bind_13, Object.GetPtr(this));
            return (Transform2D)ret;
        }

        private IntPtr method_bind_14 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_final_transform");

        /// <summary>
        /// Get the total transform of the viewport.
        /// </summary>
        public Transform2D get_final_transform()
        {
            object ret = NativeCalls.godot_icall_0_141(method_bind_14, Object.GetPtr(this));
            return (Transform2D)ret;
        }

        private IntPtr method_bind_15 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_visible_rect");

        /// <summary>
        /// Return the final, visible rect in global screen coordinates.
        /// </summary>
        public Rect2 get_visible_rect()
        {
            object ret = NativeCalls.godot_icall_0_95(method_bind_15, Object.GetPtr(this));
            return (Rect2)ret;
        }

        private IntPtr method_bind_16 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_transparent_background");

        /// <summary>
        /// If this viewport is a child of another viewport, keep the previously drawn background visible.
        /// </summary>
        public void set_transparent_background(bool enable)
        {
            NativeCalls.godot_icall_1_7(method_bind_16, Object.GetPtr(this), enable);
        }

        private IntPtr method_bind_17 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "has_transparent_background");

        /// <summary>
        /// Return whether the viewport lets whatever is behind it to show.
        /// </summary>
        public bool has_transparent_background()
        {
            return NativeCalls.godot_icall_0_3(method_bind_17, Object.GetPtr(this));
        }

        private IntPtr method_bind_18 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_size_override");

        /// <summary>
        /// Set the size override of the viewport. If the enable parameter is true, it would use the override, otherwise it would use the default size. If the size parameter is equal to [code](-1, -1)[/code], it won't update the size.
        /// <param name="size">If the param is null, then the default value is new Vector2(-1, -1)</param>
        /// <param name="margin">If the param is null, then the default value is new Vector2(0, 0)</param>
        /// </summary>
        public void set_size_override(bool enable, Nullable<Vector2> size = null, Nullable<Vector2> margin = null)
        {
            Vector2 size_in = size.HasValue ? size.Value : new Vector2(-1, -1);
            Vector2 margin_in = margin.HasValue ? margin.Value : new Vector2(0, 0);
            NativeCalls.godot_icall_3_497(method_bind_18, Object.GetPtr(this), enable, ref size_in, ref margin_in);
        }

        private IntPtr method_bind_19 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_size_override");

        /// <summary>
        /// Get the size override set with [method set_size_override].
        /// </summary>
        public Vector2 get_size_override()
        {
            object ret = NativeCalls.godot_icall_0_9(method_bind_19, Object.GetPtr(this));
            return (Vector2)ret;
        }

        private IntPtr method_bind_20 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_size_override_enabled");

        /// <summary>
        /// Get the enabled status of the size override set with [method set_size_override].
        /// </summary>
        public bool is_size_override_enabled()
        {
            return NativeCalls.godot_icall_0_3(method_bind_20, Object.GetPtr(this));
        }

        private IntPtr method_bind_21 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_size_override_stretch");

        /// <summary>
        /// Set whether the size override affects stretch as well.
        /// </summary>
        public void set_size_override_stretch(bool enabled)
        {
            NativeCalls.godot_icall_1_7(method_bind_21, Object.GetPtr(this), enabled);
        }

        private IntPtr method_bind_22 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_size_override_stretch_enabled");

        /// <summary>
        /// Get the enabled status of the size strech override set with [method set_size_override_stretch].
        /// </summary>
        public bool is_size_override_stretch_enabled()
        {
            return NativeCalls.godot_icall_0_3(method_bind_22, Object.GetPtr(this));
        }

        private IntPtr method_bind_23 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_vflip");

        /// <summary>
        /// Set whether the viewport is flipped on the Y axis.
        /// </summary>
        public void set_vflip(bool enable)
        {
            NativeCalls.godot_icall_1_7(method_bind_23, Object.GetPtr(this), enable);
        }

        private IntPtr method_bind_24 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_vflip");

        /// <summary>
        /// Set whether the render target is flipped on the Y axis.
        /// </summary>
        public bool get_vflip()
        {
            return NativeCalls.godot_icall_0_3(method_bind_24, Object.GetPtr(this));
        }

        private IntPtr method_bind_25 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_clear_on_new_frame");

        public void set_clear_on_new_frame(bool enable)
        {
            NativeCalls.godot_icall_1_7(method_bind_25, Object.GetPtr(this), enable);
        }

        private IntPtr method_bind_26 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_clear_on_new_frame");

        /// <summary>
        /// Return whether automatic clearing of the render target on each frame is enabled.
        /// </summary>
        public bool get_clear_on_new_frame()
        {
            return NativeCalls.godot_icall_0_3(method_bind_26, Object.GetPtr(this));
        }

        private IntPtr method_bind_27 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "clear");

        /// <summary>
        /// Clear the viewport manually.
        /// </summary>
        public void clear()
        {
            NativeCalls.godot_icall_0_8(method_bind_27, Object.GetPtr(this));
        }

        private IntPtr method_bind_28 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_update_mode");

        /// <summary>
        /// Set when the render target would be updated, using the [code]UPDATE_*[/code] constants
        /// </summary>
        public void set_update_mode(int mode)
        {
            NativeCalls.godot_icall_1_0(method_bind_28, Object.GetPtr(this), mode);
        }

        private IntPtr method_bind_29 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_update_mode");

        /// <summary>
        /// Get when the viewport would be updated, will be one of the [code]UPDATE_*[/code] constants.
        /// </summary>
        public int get_update_mode()
        {
            return NativeCalls.godot_icall_0_1(method_bind_29, Object.GetPtr(this));
        }

        private IntPtr method_bind_30 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_msaa");

        public void set_msaa(int msaa)
        {
            NativeCalls.godot_icall_1_0(method_bind_30, Object.GetPtr(this), msaa);
        }

        private IntPtr method_bind_31 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_msaa");

        public int get_msaa()
        {
            return NativeCalls.godot_icall_0_1(method_bind_31, Object.GetPtr(this));
        }

        private IntPtr method_bind_32 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_hdr");

        public void set_hdr(bool enable)
        {
            NativeCalls.godot_icall_1_7(method_bind_32, Object.GetPtr(this), enable);
        }

        private IntPtr method_bind_33 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_hdr");

        /// <summary>
        /// Get whether the rendered texture has filters enabled.
        /// </summary>
        public bool get_hdr()
        {
            return NativeCalls.godot_icall_0_3(method_bind_33, Object.GetPtr(this));
        }

        private IntPtr method_bind_34 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_usage");

        public void set_usage(int usage)
        {
            NativeCalls.godot_icall_1_0(method_bind_34, Object.GetPtr(this), usage);
        }

        private IntPtr method_bind_35 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_usage");

        public int get_usage()
        {
            return NativeCalls.godot_icall_0_1(method_bind_35, Object.GetPtr(this));
        }

        private IntPtr method_bind_36 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_debug_draw");

        public void set_debug_draw(int debug_draw)
        {
            NativeCalls.godot_icall_1_0(method_bind_36, Object.GetPtr(this), debug_draw);
        }

        private IntPtr method_bind_37 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_debug_draw");

        public int get_debug_draw()
        {
            return NativeCalls.godot_icall_0_1(method_bind_37, Object.GetPtr(this));
        }

        private IntPtr method_bind_38 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_render_info");

        public int get_render_info(int info)
        {
            return NativeCalls.godot_icall_1_5(method_bind_38, Object.GetPtr(this), info);
        }

        private IntPtr method_bind_39 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_texture");

        /// <summary>
        /// Get the viewport's texture, for use with various objects that you want to texture with the viewport.
        /// </summary>
        public ViewportTexture get_texture()
        {
            return NativeCalls.godot_icall_0_498(method_bind_39, Object.GetPtr(this));
        }

        private IntPtr method_bind_40 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_physics_object_picking");

        /// <summary>
        /// Enable/disable picking for all physics objects inside the viewport.
        /// </summary>
        public void set_physics_object_picking(bool enable)
        {
            NativeCalls.godot_icall_1_7(method_bind_40, Object.GetPtr(this), enable);
        }

        private IntPtr method_bind_41 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_physics_object_picking");

        /// <summary>
        /// Get whether picking for all physics objects inside the viewport is enabled.
        /// </summary>
        public bool get_physics_object_picking()
        {
            return NativeCalls.godot_icall_0_3(method_bind_41, Object.GetPtr(this));
        }

        private IntPtr method_bind_42 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_viewport_rid");

        /// <summary>
        /// Get the viewport RID from the [VisualServer].
        /// </summary>
        public RID get_viewport_rid()
        {
            IntPtr ret = NativeCalls.godot_icall_0_122(method_bind_42, Object.GetPtr(this));
            return new RID(ret);
        }

        private IntPtr method_bind_43 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "input");

        public void input(InputEvent local_event)
        {
            NativeCalls.godot_icall_1_19(method_bind_43, Object.GetPtr(this), Object.GetPtr(local_event));
        }

        private IntPtr method_bind_44 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "unhandled_input");

        public void unhandled_input(InputEvent local_event)
        {
            NativeCalls.godot_icall_1_19(method_bind_44, Object.GetPtr(this), Object.GetPtr(local_event));
        }

        private IntPtr method_bind_45 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "update_worlds");

        /// <summary>
        /// Force update of the 2D and 3D worlds.
        /// </summary>
        public void update_worlds()
        {
            NativeCalls.godot_icall_0_8(method_bind_45, Object.GetPtr(this));
        }

        private IntPtr method_bind_46 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_use_own_world");

        /// <summary>
        /// Make the viewport use a world separate from the parent viewport's world.
        /// </summary>
        public void set_use_own_world(bool enable)
        {
            NativeCalls.godot_icall_1_7(method_bind_46, Object.GetPtr(this), enable);
        }

        private IntPtr method_bind_47 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_using_own_world");

        /// <summary>
        /// Return whether the viewport is using a world separate from the parent viewport's world.
        /// </summary>
        public bool is_using_own_world()
        {
            return NativeCalls.godot_icall_0_3(method_bind_47, Object.GetPtr(this));
        }

        private IntPtr method_bind_48 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_camera");

        /// <summary>
        /// Return the active 3D camera.
        /// </summary>
        public Camera get_camera()
        {
            return NativeCalls.godot_icall_0_499(method_bind_48, Object.GetPtr(this));
        }

        private IntPtr method_bind_49 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_as_audio_listener");

        /// <summary>
        /// Makes the viewport send sounds to the speakers.
        /// </summary>
        public void set_as_audio_listener(bool enable)
        {
            NativeCalls.godot_icall_1_7(method_bind_49, Object.GetPtr(this), enable);
        }

        private IntPtr method_bind_50 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_audio_listener");

        /// <summary>
        /// Returns whether the viewport sends sounds to the speakers.
        /// </summary>
        public bool is_audio_listener()
        {
            return NativeCalls.godot_icall_0_3(method_bind_50, Object.GetPtr(this));
        }

        private IntPtr method_bind_51 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_as_audio_listener_2d");

        /// <summary>
        /// Makes the viewport send sounds from 2D emitters to the speakers.
        /// </summary>
        public void set_as_audio_listener_2d(bool enable)
        {
            NativeCalls.godot_icall_1_7(method_bind_51, Object.GetPtr(this), enable);
        }

        private IntPtr method_bind_52 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_audio_listener_2d");

        /// <summary>
        /// Returns whether the viewport sends soundsfrom 2D emitters to the speakers.
        /// </summary>
        public bool is_audio_listener_2d()
        {
            return NativeCalls.godot_icall_0_3(method_bind_52, Object.GetPtr(this));
        }

        private IntPtr method_bind_53 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_attach_to_screen_rect");

        public void set_attach_to_screen_rect(Rect2 rect)
        {
            NativeCalls.godot_icall_1_94(method_bind_53, Object.GetPtr(this), ref rect);
        }

        private IntPtr method_bind_54 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_mouse_position");

        /// <summary>
        /// Get the mouse position, relative to the viewport.
        /// </summary>
        public Vector2 get_mouse_position()
        {
            object ret = NativeCalls.godot_icall_0_9(method_bind_54, Object.GetPtr(this));
            return (Vector2)ret;
        }

        private IntPtr method_bind_55 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "warp_mouse");

        /// <summary>
        /// Warp the mouse to a position, relative to the viewport.
        /// </summary>
        public void warp_mouse(Vector2 to_pos)
        {
            NativeCalls.godot_icall_1_37(method_bind_55, Object.GetPtr(this), ref to_pos);
        }

        private IntPtr method_bind_56 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "gui_has_modal_stack");

        /// <summary>
        /// Returs whether there are shown modals on-screen.
        /// </summary>
        public bool gui_has_modal_stack()
        {
            return NativeCalls.godot_icall_0_3(method_bind_56, Object.GetPtr(this));
        }

        private IntPtr method_bind_57 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "gui_get_drag_data");

        /// <summary>
        /// Returs the drag data from the GUI, that was previously returned by [method Control.get_drag_data].
        /// </summary>
        public object gui_get_drag_data()
        {
            return NativeCalls.godot_icall_0_121(method_bind_57, Object.GetPtr(this));
        }

        private IntPtr method_bind_58 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_disable_input");

        /// <summary>
        /// Set whether input to the viewport is disabled.
        /// </summary>
        public void set_disable_input(bool disable)
        {
            NativeCalls.godot_icall_1_7(method_bind_58, Object.GetPtr(this), disable);
        }

        private IntPtr method_bind_59 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_input_disabled");

        /// <summary>
        /// Return whether input to the viewport is disabled.
        /// </summary>
        public bool is_input_disabled()
        {
            return NativeCalls.godot_icall_0_3(method_bind_59, Object.GetPtr(this));
        }

        private IntPtr method_bind_60 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_disable_3d");

        public void set_disable_3d(bool disable)
        {
            NativeCalls.godot_icall_1_7(method_bind_60, Object.GetPtr(this), disable);
        }

        private IntPtr method_bind_61 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_3d_disabled");

        public bool is_3d_disabled()
        {
            return NativeCalls.godot_icall_0_3(method_bind_61, Object.GetPtr(this));
        }

        private IntPtr method_bind_62 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_shadow_atlas_size");

        public void set_shadow_atlas_size(int size)
        {
            NativeCalls.godot_icall_1_0(method_bind_62, Object.GetPtr(this), size);
        }

        private IntPtr method_bind_63 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_shadow_atlas_size");

        public int get_shadow_atlas_size()
        {
            return NativeCalls.godot_icall_0_1(method_bind_63, Object.GetPtr(this));
        }

        private IntPtr method_bind_64 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_shadow_atlas_quadrant_subdiv");

        public void set_shadow_atlas_quadrant_subdiv(int quadrant, int subdiv)
        {
            NativeCalls.godot_icall_2_24(method_bind_64, Object.GetPtr(this), quadrant, subdiv);
        }

        private IntPtr method_bind_65 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_shadow_atlas_quadrant_subdiv");

        public int get_shadow_atlas_quadrant_subdiv(int quadrant)
        {
            return NativeCalls.godot_icall_1_5(method_bind_65, Object.GetPtr(this), quadrant);
        }
    }
}
