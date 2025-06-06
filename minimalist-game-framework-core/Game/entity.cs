﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

internal abstract class Entity : IDisposable
{
    string name;
    Vector2 position;
    public Rectangle Bound { get { return CalculateBound(); } }
    public string Name { get { return name; } }
    public Vector2 Position { get { return position; } set { position = value; } }

    protected abstract Rectangle CalculateBound();
    protected abstract void Render();
    protected abstract void Draw(Vector2 position, Vector2 size);

    public void Dispose()
    {
        throw new NotImplementedException();
    }
}