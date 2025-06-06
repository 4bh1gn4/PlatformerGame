﻿using System;
using System.Collections.Generic;
using System.Text;
using SDL2;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Drawing;


internal class Button
{
    private IntPtr Renderer => Engine.Renderer2;
    public string Text { get; }
    private Vector2 position;
    private Vector2 size;
    public Vector2 getPosition()
    {
        return position;
    }

    public Vector2 getSize()
    {
        return size;
    }
    public Button(string text, Vector2 position, Vector2 size)
    {
        Text = text;
        this.position = position;
        this.size = size;
    }



    public bool IsClicked()
    {
        // Implement logic to check if the button is clicked
        // For example, you can use mouse input or touch events here
        return false;
    }
}
 