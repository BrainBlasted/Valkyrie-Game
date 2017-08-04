using System;

namespace GodotEngine
{
    /// <summary>
    /// Base class of anything 2D. Canvas items are laid out in a tree and children inherit and extend the transform of their parent. CanvasItem is extended by [Control], for anything GUI related, and by [Node2D] for anything 2D engine related.
    /// Any CanvasItem can draw. For this, the "update" function must be called, then NOTIFICATION_DRAW will be received on idle time to request redraw. Because of this, canvas items don't need to be redraw on every frame, improving the performance significantly. Several functions for drawing on the CanvasItem are provided (see draw_* functions). They can only be used inside the notification, signal or _draw() overrides function, though.
    /// Canvas items are draw in tree order. By default, children are on top of their parents so a root CanvasItem will be drawn behind everything (this can be changed per item though).
    /// Canvas items can also be hidden (hiding also their subtree). They provide many means for changing standard parameters such as opacity (for it and the subtree) and self opacity, blend mode.
    /// Ultimately, a transform notification can be requested, which will notify the node that its global position changed in case the parent tree changed.
    /// </summary>
    public class CanvasItem : Node
    {
        /// <summary>
        /// Mix blending mode. Colors are assumed to be independent of the alpha (opacity) value.
        /// </summary>
        public const int BLEND_MODE_MIX = 0;
        /// <summary>
        /// Additive blending mode.
        /// </summary>
        public const int BLEND_MODE_ADD = 1;
        /// <summary>
        /// Subtractive blending mode.
        /// </summary>
        public const int BLEND_MODE_SUB = 2;
        /// <summary>
        /// Multiplicative blending mode.
        /// </summary>
        public const int BLEND_MODE_MUL = 3;
        /// <summary>
        /// Mix blending mode. Colors are assumed to be premultiplied by the alpha (opacity) value.
        /// </summary>
        public const int BLEND_MODE_PREMULT_ALPHA = 4;
        /// <summary>
        /// CanvasItem is requested to draw.
        /// </summary>
        public const int NOTIFICATION_DRAW = 30;
        /// <summary>
        /// Canvas item visibility has changed.
        /// </summary>
        public const int NOTIFICATION_VISIBILITY_CHANGED = 31;
        /// <summary>
        /// Canvas item has entered the canvas.
        /// </summary>
        public const int NOTIFICATION_ENTER_CANVAS = 32;
        /// <summary>
        /// Canvas item has exited the canvas.
        /// </summary>
        public const int NOTIFICATION_EXIT_CANVAS = 33;
        /// <summary>
        /// Canvas item transform has changed. Only received if requested.
        /// </summary>
        public const int NOTIFICATION_TRANSFORM_CHANGED = 29;

        private const string nativeName = "CanvasItem";

        internal CanvasItem() {}

        internal CanvasItem(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "edit_set_state");

        /// <summary>
        /// Set the transform state of this CanvasItem. For [Node2D], this is an [Array] with (in order) a [Vector2] for position, a float for rotation (radians) and another [Vector2] for scale. For [Control] this is a [Rect2] with the position and size.
        /// </summary>
        public void edit_set_state(object state)
        {
            NativeCalls.godot_icall_1_119(method_bind_0, Object.GetPtr(this), state);
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "edit_get_state");

        /// <summary>
        /// Used for editing, returns an opaque value representing the transform state.
        /// </summary>
        public object edit_get_state()
        {
            return NativeCalls.godot_icall_0_120(method_bind_1, Object.GetPtr(this));
        }

        private IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "edit_set_rect");

        public void edit_set_rect(Rect2 rect)
        {
            NativeCalls.godot_icall_1_93(method_bind_2, Object.GetPtr(this), ref rect);
        }

        private IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "edit_rotate");

        /// <summary>
        /// Used for editing, handle rotation.
        /// </summary>
        public void edit_rotate(float degrees)
        {
            NativeCalls.godot_icall_1_10(method_bind_3, Object.GetPtr(this), degrees);
        }

        private IntPtr method_bind_4 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_item_rect");

        /// <summary>
        /// Return a rect containing the editable boundaries of the item.
        /// </summary>
        public Rect2 get_item_rect()
        {
            object ret = NativeCalls.godot_icall_0_94(method_bind_4, Object.GetPtr(this));
            return (Rect2)ret;
        }

        private IntPtr method_bind_5 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_item_and_children_rect");

        /// <summary>
        /// Get a [Rect2] with the boundaries of this item and its children.
        /// </summary>
        public Rect2 get_item_and_children_rect()
        {
            object ret = NativeCalls.godot_icall_0_94(method_bind_5, Object.GetPtr(this));
            return (Rect2)ret;
        }

        private IntPtr method_bind_6 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_canvas_item");

        /// <summary>
        /// Return the canvas item RID used by [VisualServer] for this item.
        /// </summary>
        public RID get_canvas_item()
        {
            IntPtr ret = NativeCalls.godot_icall_0_121(method_bind_6, Object.GetPtr(this));
            return new RID(ret);
        }

        private IntPtr method_bind_7 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_visible");

        /// <summary>
        /// Set whether this item should be visible or not.
        /// Note that a hidden CanvasItem will make all children hidden too, so no matter what is set here this item won't be shown if its parent or grandparents nodes are hidden.
        /// </summary>
        public void set_visible(bool visible)
        {
            NativeCalls.godot_icall_1_7(method_bind_7, Object.GetPtr(this), visible);
        }

        private IntPtr method_bind_8 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_visible");

        /// <summary>
        /// Return true if this CanvasItem is visible. It may be invisible because itself or a parent canvas item is hidden.
        /// </summary>
        public bool is_visible()
        {
            return NativeCalls.godot_icall_0_3(method_bind_8, Object.GetPtr(this));
        }

        private IntPtr method_bind_9 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_visible_in_tree");

        public bool is_visible_in_tree()
        {
            return NativeCalls.godot_icall_0_3(method_bind_9, Object.GetPtr(this));
        }

        private IntPtr method_bind_10 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "show");

        /// <summary>
        /// Show the CanvasItem currently hidden.
        /// </summary>
        public void show()
        {
            NativeCalls.godot_icall_0_8(method_bind_10, Object.GetPtr(this));
        }

        private IntPtr method_bind_11 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "hide");

        /// <summary>
        /// Hide the CanvasItem currently visible.
        /// </summary>
        public void hide()
        {
            NativeCalls.godot_icall_0_8(method_bind_11, Object.GetPtr(this));
        }

        private IntPtr method_bind_12 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "update");

        /// <summary>
        /// Queue the CanvasItem for update. [code]NOTIFICATION_DRAW[/code] will be called on idle time to request redraw.
        /// </summary>
        public void update()
        {
            NativeCalls.godot_icall_0_8(method_bind_12, Object.GetPtr(this));
        }

        private IntPtr method_bind_13 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_as_toplevel");

        /// <summary>
        /// Set as top level. This means that it will not inherit transform from parent canvas items.
        /// </summary>
        public void set_as_toplevel(bool enable)
        {
            NativeCalls.godot_icall_1_7(method_bind_13, Object.GetPtr(this), enable);
        }

        private IntPtr method_bind_14 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_set_as_toplevel");

        /// <summary>
        /// Return if set as toplevel. See [method set_as_toplevel].
        /// </summary>
        public bool is_set_as_toplevel()
        {
            return NativeCalls.godot_icall_0_3(method_bind_14, Object.GetPtr(this));
        }

        private IntPtr method_bind_15 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_light_mask");

        /// <summary>
        /// Set the ligtht mask number of this item.
        /// </summary>
        public void set_light_mask(int light_mask)
        {
            NativeCalls.godot_icall_1_0(method_bind_15, Object.GetPtr(this), light_mask);
        }

        private IntPtr method_bind_16 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_light_mask");

        /// <summary>
        /// Get this item's light mask number.
        /// </summary>
        public int get_light_mask()
        {
            return NativeCalls.godot_icall_0_1(method_bind_16, Object.GetPtr(this));
        }

        private IntPtr method_bind_17 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_modulate");

        /// <summary>
        /// Set the modulate of the CanvasItem. This [i]affects[/i] the modulation of children items.
        /// </summary>
        public void set_modulate(Color modulate)
        {
            NativeCalls.godot_icall_1_122(method_bind_17, Object.GetPtr(this), ref modulate);
        }

        private IntPtr method_bind_18 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_modulate");

        /// <summary>
        /// Get the modulate of the CanvasItem, which affects children items too.
        /// </summary>
        public Color get_modulate()
        {
            object ret = NativeCalls.godot_icall_0_123(method_bind_18, Object.GetPtr(this));
            return (Color)ret;
        }

        private IntPtr method_bind_19 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_self_modulate");

        /// <summary>
        /// Set the self-modulate of the CanvasItem. This does not affect the modulation of children items.
        /// </summary>
        public void set_self_modulate(Color self_modulate)
        {
            NativeCalls.godot_icall_1_122(method_bind_19, Object.GetPtr(this), ref self_modulate);
        }

        private IntPtr method_bind_20 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_self_modulate");

        /// <summary>
        /// Get the self-modulate of the CanvasItem.
        /// </summary>
        public Color get_self_modulate()
        {
            object ret = NativeCalls.godot_icall_0_123(method_bind_20, Object.GetPtr(this));
            return (Color)ret;
        }

        private IntPtr method_bind_21 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_draw_behind_parent");

        /// <summary>
        /// Set whether the canvas item is drawn behind its parent.
        /// </summary>
        public void set_draw_behind_parent(bool enable)
        {
            NativeCalls.godot_icall_1_7(method_bind_21, Object.GetPtr(this), enable);
        }

        private IntPtr method_bind_22 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_draw_behind_parent_enabled");

        /// <summary>
        /// Return whether the item is drawn behind its parent.
        /// </summary>
        public bool is_draw_behind_parent_enabled()
        {
            return NativeCalls.godot_icall_0_3(method_bind_22, Object.GetPtr(this));
        }

        private IntPtr method_bind_23 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "draw_line");

        /// <summary>
        /// Draw a line from a 2D point to another, with a given color and width. It can be optionally antialiased.
        /// </summary>
        public void draw_line(Vector2 from, Vector2 to, Color color, float width = 1f, bool antialiased = false)
        {
            NativeCalls.godot_icall_5_124(method_bind_23, Object.GetPtr(this), ref from, ref to, ref color, width, antialiased);
        }

        private IntPtr method_bind_24 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "draw_polyline");

        public void draw_polyline(Vector2[] points, Color color, float width = 1f, bool antialiased = false)
        {
            NativeCalls.godot_icall_4_125(method_bind_24, Object.GetPtr(this), points, ref color, width, antialiased);
        }

        private IntPtr method_bind_25 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "draw_polyline_colors");

        public void draw_polyline_colors(Vector2[] points, Color[] colors, float width = 1f, bool antialiased = false)
        {
            NativeCalls.godot_icall_4_126(method_bind_25, Object.GetPtr(this), points, colors, width, antialiased);
        }

        private IntPtr method_bind_26 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "draw_rect");

        /// <summary>
        /// Draw a colored rectangle.
        /// </summary>
        public void draw_rect(Rect2 rect, Color color, bool filled = true)
        {
            NativeCalls.godot_icall_3_127(method_bind_26, Object.GetPtr(this), ref rect, ref color, filled);
        }

        private IntPtr method_bind_27 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "draw_circle");

        /// <summary>
        /// Draw a colored circle.
        /// </summary>
        public void draw_circle(Vector2 pos, float radius, Color color)
        {
            NativeCalls.godot_icall_3_128(method_bind_27, Object.GetPtr(this), ref pos, radius, ref color);
        }

        private IntPtr method_bind_28 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "draw_texture");

        /// <summary>
        /// Draw a texture at a given position.
        /// <param name="modulate">If the param is null, then the default value is new Color(1, 1, 1, 1)</param>
        /// </summary>
        public void draw_texture(Texture texture, Vector2 pos, Nullable<Color> modulate = null, Texture normal_map = null)
        {
            Color modulate_in = modulate.HasValue ? modulate.Value : new Color(1, 1, 1, 1);
            NativeCalls.godot_icall_4_129(method_bind_28, Object.GetPtr(this), Object.GetPtr(texture), ref pos, ref modulate_in, Object.GetPtr(normal_map));
        }

        private IntPtr method_bind_29 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "draw_texture_rect");

        /// <summary>
        /// Draw a textured rectangle at a given position, optionally modulated by a color. Transpose swaps the x and y coordinates when reading the texture.
        /// <param name="modulate">If the param is null, then the default value is new Color(1, 1, 1, 1)</param>
        /// </summary>
        public void draw_texture_rect(Texture texture, Rect2 rect, bool tile, Nullable<Color> modulate = null, bool transpose = false, Texture normal_map = null)
        {
            Color modulate_in = modulate.HasValue ? modulate.Value : new Color(1, 1, 1, 1);
            NativeCalls.godot_icall_6_130(method_bind_29, Object.GetPtr(this), Object.GetPtr(texture), ref rect, tile, ref modulate_in, transpose, Object.GetPtr(normal_map));
        }

        private IntPtr method_bind_30 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "draw_texture_rect_region");

        /// <summary>
        /// Draw a textured rectangle region at a given position, optionally modulated by a color. Transpose swaps the x and y coordinates when reading the texture.
        /// <param name="modulate">If the param is null, then the default value is new Color(1, 1, 1, 1)</param>
        /// </summary>
        public void draw_texture_rect_region(Texture texture, Rect2 rect, Rect2 src_rect, Nullable<Color> modulate = null, bool transpose = false, Texture normal_map = null, bool clip_uv = true)
        {
            Color modulate_in = modulate.HasValue ? modulate.Value : new Color(1, 1, 1, 1);
            NativeCalls.godot_icall_7_131(method_bind_30, Object.GetPtr(this), Object.GetPtr(texture), ref rect, ref src_rect, ref modulate_in, transpose, Object.GetPtr(normal_map), clip_uv);
        }

        private IntPtr method_bind_31 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "draw_style_box");

        /// <summary>
        /// Draw a styled rectangle.
        /// </summary>
        public void draw_style_box(StyleBox style_box, Rect2 rect)
        {
            NativeCalls.godot_icall_2_132(method_bind_31, Object.GetPtr(this), Object.GetPtr(style_box), ref rect);
        }

        private IntPtr method_bind_32 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "draw_primitive");

        /// <summary>
        /// Draw a custom primitive, 1 point for a point, 2 points for a line, 3 points for a triangle and 4 points for a quad.
        /// </summary>
        public void draw_primitive(Vector2[] points, Color[] colors, Vector2[] uvs, Texture texture = null, float width = 1f, Texture normal_map = null)
        {
            NativeCalls.godot_icall_6_133(method_bind_32, Object.GetPtr(this), points, colors, uvs, Object.GetPtr(texture), width, Object.GetPtr(normal_map));
        }

        private IntPtr method_bind_33 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "draw_polygon");

        /// <summary>
        /// Draw a polygon of any amount of points, convex or concave.
        /// <param name="uvs">If the param is null, then the default value is new Vector2[] {}</param>
        /// </summary>
        public void draw_polygon(Vector2[] points, Color[] colors, Vector2[] uvs = null, Texture texture = null, Texture normal_map = null)
        {
            Vector2[] uvs_in = uvs != null ? uvs : new Vector2[] {};
            NativeCalls.godot_icall_5_134(method_bind_33, Object.GetPtr(this), points, colors, uvs_in, Object.GetPtr(texture), Object.GetPtr(normal_map));
        }

        private IntPtr method_bind_34 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "draw_colored_polygon");

        /// <summary>
        /// Draw a colored polygon of any amount of points, convex or concave.
        /// <param name="uvs">If the param is null, then the default value is new Vector2[] {}</param>
        /// </summary>
        public void draw_colored_polygon(Vector2[] points, Color color, Vector2[] uvs = null, Texture texture = null, Texture normal_map = null)
        {
            Vector2[] uvs_in = uvs != null ? uvs : new Vector2[] {};
            NativeCalls.godot_icall_5_135(method_bind_34, Object.GetPtr(this), points, ref color, uvs_in, Object.GetPtr(texture), Object.GetPtr(normal_map));
        }

        private IntPtr method_bind_35 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "draw_string");

        /// <summary>
        /// Draw a string using a custom font.
        /// <param name="modulate">If the param is null, then the default value is new Color(1, 1, 1, 1)</param>
        /// </summary>
        public void draw_string(Font font, Vector2 pos, string text, Nullable<Color> modulate = null, int clip_w = -1)
        {
            Color modulate_in = modulate.HasValue ? modulate.Value : new Color(1, 1, 1, 1);
            NativeCalls.godot_icall_5_136(method_bind_35, Object.GetPtr(this), Object.GetPtr(font), ref pos, text, ref modulate_in, clip_w);
        }

        private IntPtr method_bind_36 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "draw_char");

        /// <summary>
        /// Draw a string character using a custom font. Returns the advance, depending on the char width and kerning with an optional next char.
        /// <param name="modulate">If the param is null, then the default value is new Color(1, 1, 1, 1)</param>
        /// </summary>
        public float draw_char(Font font, Vector2 pos, string @char, string next, Nullable<Color> modulate = null)
        {
            Color modulate_in = modulate.HasValue ? modulate.Value : new Color(1, 1, 1, 1);
            return NativeCalls.godot_icall_5_137(method_bind_36, Object.GetPtr(this), Object.GetPtr(font), ref pos, @char, next, ref modulate_in);
        }

        private IntPtr method_bind_37 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "draw_set_transform");

        /// <summary>
        /// Set a custom transform for drawing. Anything drawn afterwards will be transformed by this.
        /// </summary>
        public void draw_set_transform(Vector2 pos, float rot, Vector2 scale)
        {
            NativeCalls.godot_icall_3_138(method_bind_37, Object.GetPtr(this), ref pos, rot, ref scale);
        }

        private IntPtr method_bind_38 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "draw_set_transform_matrix");

        public void draw_set_transform_matrix(Transform2D xform)
        {
            NativeCalls.godot_icall_1_139(method_bind_38, Object.GetPtr(this), ref xform);
        }

        private IntPtr method_bind_39 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_transform");

        /// <summary>
        /// Get the transform matrix of this item.
        /// </summary>
        public Transform2D get_transform()
        {
            object ret = NativeCalls.godot_icall_0_140(method_bind_39, Object.GetPtr(this));
            return (Transform2D)ret;
        }

        private IntPtr method_bind_40 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_global_transform");

        /// <summary>
        /// Get the global transform matrix of this item.
        /// </summary>
        public Transform2D get_global_transform()
        {
            object ret = NativeCalls.godot_icall_0_140(method_bind_40, Object.GetPtr(this));
            return (Transform2D)ret;
        }

        private IntPtr method_bind_41 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_global_transform_with_canvas");

        /// <summary>
        /// Get the global transform matrix of this item in relation to the canvas.
        /// </summary>
        public Transform2D get_global_transform_with_canvas()
        {
            object ret = NativeCalls.godot_icall_0_140(method_bind_41, Object.GetPtr(this));
            return (Transform2D)ret;
        }

        private IntPtr method_bind_42 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_viewport_transform");

        /// <summary>
        /// Get this item's transform in relation to the viewport.
        /// </summary>
        public Transform2D get_viewport_transform()
        {
            object ret = NativeCalls.godot_icall_0_140(method_bind_42, Object.GetPtr(this));
            return (Transform2D)ret;
        }

        private IntPtr method_bind_43 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_viewport_rect");

        /// <summary>
        /// Get the viewport's boundaries as a [Rect2].
        /// </summary>
        public Rect2 get_viewport_rect()
        {
            object ret = NativeCalls.godot_icall_0_94(method_bind_43, Object.GetPtr(this));
            return (Rect2)ret;
        }

        private IntPtr method_bind_44 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_canvas_transform");

        /// <summary>
        /// Get the transform matrix of this item's canvas.
        /// </summary>
        public Transform2D get_canvas_transform()
        {
            object ret = NativeCalls.godot_icall_0_140(method_bind_44, Object.GetPtr(this));
            return (Transform2D)ret;
        }

        private IntPtr method_bind_45 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_local_mouse_pos");

        /// <summary>
        /// Get the mouse position relative to this item's position.
        /// </summary>
        public Vector2 get_local_mouse_pos()
        {
            object ret = NativeCalls.godot_icall_0_9(method_bind_45, Object.GetPtr(this));
            return (Vector2)ret;
        }

        private IntPtr method_bind_46 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_global_mouse_position");

        /// <summary>
        /// Get the global position of the mouse.
        /// </summary>
        public Vector2 get_global_mouse_position()
        {
            object ret = NativeCalls.godot_icall_0_9(method_bind_46, Object.GetPtr(this));
            return (Vector2)ret;
        }

        private IntPtr method_bind_47 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_canvas");

        /// <summary>
        /// Return the [RID] of the [World2D] canvas where this item is in.
        /// </summary>
        public RID get_canvas()
        {
            IntPtr ret = NativeCalls.godot_icall_0_121(method_bind_47, Object.GetPtr(this));
            return new RID(ret);
        }

        private IntPtr method_bind_48 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_world_2d");

        /// <summary>
        /// Get the [World2D] where this item is in.
        /// </summary>
        public World2D get_world_2d()
        {
            return NativeCalls.godot_icall_0_141(method_bind_48, Object.GetPtr(this));
        }

        private IntPtr method_bind_49 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_material");

        /// <summary>
        /// Set the material of this item.
        /// </summary>
        public void set_material(Material material)
        {
            NativeCalls.godot_icall_1_35(method_bind_49, Object.GetPtr(this), Object.GetPtr(material));
        }

        private IntPtr method_bind_50 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_material");

        /// <summary>
        /// Get the material of this item.
        /// </summary>
        public Material get_material()
        {
            return NativeCalls.godot_icall_0_142(method_bind_50, Object.GetPtr(this));
        }

        private IntPtr method_bind_51 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_use_parent_material");

        /// <summary>
        /// Set whether or not this item should use its parent's material.
        /// </summary>
        public void set_use_parent_material(bool enable)
        {
            NativeCalls.godot_icall_1_7(method_bind_51, Object.GetPtr(this), enable);
        }

        private IntPtr method_bind_52 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_use_parent_material");

        /// <summary>
        /// Get whether this item uses its parent's material.
        /// </summary>
        public bool get_use_parent_material()
        {
            return NativeCalls.godot_icall_0_3(method_bind_52, Object.GetPtr(this));
        }

        private IntPtr method_bind_53 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_notify_local_transform");

        public void set_notify_local_transform(bool enable)
        {
            NativeCalls.godot_icall_1_7(method_bind_53, Object.GetPtr(this), enable);
        }

        private IntPtr method_bind_54 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_local_transform_notification_enabled");

        public bool is_local_transform_notification_enabled()
        {
            return NativeCalls.godot_icall_0_3(method_bind_54, Object.GetPtr(this));
        }

        private IntPtr method_bind_55 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_notify_transform");

        public void set_notify_transform(bool enable)
        {
            NativeCalls.godot_icall_1_7(method_bind_55, Object.GetPtr(this), enable);
        }

        private IntPtr method_bind_56 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_transform_notification_enabled");

        public bool is_transform_notification_enabled()
        {
            return NativeCalls.godot_icall_0_3(method_bind_56, Object.GetPtr(this));
        }

        private IntPtr method_bind_57 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "make_canvas_pos_local");

        public Vector2 make_canvas_pos_local(Vector2 screen_point)
        {
            object ret = NativeCalls.godot_icall_1_143(method_bind_57, Object.GetPtr(this), ref screen_point);
            return (Vector2)ret;
        }

        private IntPtr method_bind_58 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "make_input_local");

        public InputEvent make_input_local(InputEvent @event)
        {
            return NativeCalls.godot_icall_1_144(method_bind_58, Object.GetPtr(this), Object.GetPtr(@event));
        }
    }
}
