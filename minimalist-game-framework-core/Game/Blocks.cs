﻿using SDL2;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

internal class Blocks : Entity
{
    private IntPtr Renderer => Engine.Renderer2; // Gets the SDL Renderer from the Engine class
    private Vector2 position;
    private Vector2 size;
    private GameColor color;
    public Blocks(Vector2 position, Vector2 size, GameColor color)
    {
        this.position = position;
        this.size = size;
        this.color = color;
    }

    public void blockLoop()
    {
        Render();
    }

    public List<Vector2> getCoordinates()
    {
        List<Vector2> result = new List<Vector2>();
        result.Add(position);
        result.Add(size);
        return result;
    }
    protected override Rectangle CalculateBound()
    {
        return new Rectangle((int)position.X, (int)position.Y, (int)size.X, (int)size.Y);
    }

    protected override void Render()
    {
        Draw(position, size);
    }

    protected override void Draw(Vector2 position, Vector2 size)
    {
        SDL.SDL_SetRenderDrawColor(Renderer, 0, 255, 0, 255); // green
        SDL.SDL_Rect rect = new SDL.SDL_Rect()
        {
            x = (int)position.X,
            y = (int)position.Y,
            w = (int)size.X,
            h = (int)size.Y
        };
        SDL.SDL_RenderFillRect(Renderer, ref rect);
    }
}