// Include the namespaces (code libraries) you need below.
using Raylib_cs;
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("Moon Phases");
            Window.SetSize(400, 400);
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(0, 0, 50);

            // Moon
            //Draw.SetFillColor(250, 100, 50, 190);
            Draw.SetLineSize(0);
            if (Input.IsKeyboardKeyDown(KeyboardKey.Space))
            {
                //Blood Moon
                Window.ClearBackground(20, 0, 40);
                Draw.SetLineSize(4);
                Draw.SetLineColor(255, 175, 145, 120);
                Draw.SetFillColor(255, 115, 75, 0);
                Draw.Circle(200, 200, 96);
                Draw.SetLineColor(255, 140, 110, 90);
                Draw.SetLineSize(4);
                Draw.SetFillColor(250, 110, 70, 240);
                Draw.Circle(200, 200, 95);
            }
            else
            {
                Draw.SetLineSize(5);
                Draw.SetFillColor(240, 240, 255);
                Draw.SetLineColor(250, 240, 255, 90);
                Draw.Circle(200, 200, 95);
            }

            Draw.SetLineSize(0);
            //Draw.SetLineColor(180, 180, 180, 90);
            //Draw.SetFillColor(240, 240, 255);
            Draw.SetFillColor(200, 200, 220);
            //Draw.Capsule(25, 20, 50);
            //Draw.Ellipse(200, 200, 80, 50);
            //Draw.SetLineSize(0);
            //Draw.Circle(200, 200, 95);

            // Shadow (Doesn't appear during bloodmoon)
            if (Input.IsKeyboardKeyDown(KeyboardKey.Space))
            {

            }
            else
            {
                Draw.SetLineSize(5);
                Draw.SetFillColor(0, 0, 50, 220);
                Draw.SetLineColor(0, 0, 50, 90);
                Draw.Circle(Input.GetMouseX(), 200, 100);
            }


            // Stars
            Draw.SetFillColor(245, 245, 255);
            Draw.SetLineSize(4);
            Draw.SetLineColor(250, 250, 255, 40);
            // Star 1
            Draw.Triangle(340, 305, 337, 310, 343, 310);
            Draw.Triangle(340, 315, 337, 310, 343, 310);
            // Star 2
            Draw.Triangle(60, 85, 57, 90, 63, 90);
            Draw.Triangle(60, 95, 57, 90, 63, 90);
            // Star 3
            Draw.Triangle(20, 365, 17, 370, 23, 370);
            Draw.Triangle(20, 375, 17, 370, 23, 370);
            // Star 4
            Draw.Triangle(280, 20, 277, 25, 283, 25);
            Draw.Triangle(280, 30, 277, 25, 283, 25);
            // Star 5
            Draw.Triangle(110, 305, 107, 310, 113, 310);
            Draw.Triangle(110, 315, 107, 310, 113, 310);
            // Star 5
            Draw.Triangle(370, 150, 367, 155, 373, 155);
            Draw.Triangle(370, 160, 367, 155, 373, 155);
            // Star
            Draw.Line(20, 230, 22, 230);
            Draw.Line(60, 30, 62, 30);
            Draw.Line(300, 330, 302, 330);
            Draw.Line(180, 360, 182, 360);
            Draw.Line(230, 50, 232, 50);
            Draw.Line(370, 180, 372, 180);
        }
    }

}
