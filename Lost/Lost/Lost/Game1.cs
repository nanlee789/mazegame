using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace Lost
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
     
        Rectangle currentBlock;
        Rectangle currentBlock1; 
        Rectangle currentBlock2; 
        Rectangle currentBlock3; 
        Rectangle currentBlock4; 
        Rectangle currentBlock5; 
        Rectangle currentBlock6; 
        Rectangle currentBlock7; 
        Rectangle currentBlock8; 
        Rectangle currentBlock9; 
        Rectangle currentBlock10;
        Rectangle currentBlock11;
        Rectangle currentBlock12;
        Rectangle currentBlock13;
        Rectangle currentBlock14;
        Rectangle currentBlock15;
        Rectangle currentBlock16;
        Rectangle currentBlock17;
        Rectangle currentBlock18;
        Rectangle currentBlock19;
        Rectangle currentBlock20;
        Rectangle currentBlock21;
        Rectangle currentBlock22;
        Rectangle currentBlock23;
        Rectangle currentBlock24;
        Rectangle currentBlock25;
        Rectangle currentBlock26;
        Rectangle currentBlock27;
        Rectangle currentBlock28;
        Rectangle currentBlock29;
        Rectangle currentBlock30;
        Rectangle currentBlock31;
        Rectangle currentBlock32;
        Rectangle currentBlock33;
        Rectangle currentBlock34;
        Rectangle currentBlock35;
        Rectangle currentBlock36;
        Rectangle currentBlock37;
        Rectangle currentBlock38;
        Rectangle currentBlock39;
        Rectangle currentJimmy;


        Texture2D squareJimmy;
        Texture2D squareBlock;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here

        
            squareBlock = Content.Load<Texture2D>(@"block");
            squareJimmy = Content.Load<Texture2D>(@"jimmy");

        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            // Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();

            // TODO: Add your update logic here


            Level1Coords = {{0,0}, {50,00}, {75,00}, {100,00}, {125,00}, {150,00}, {175,00}, {200,00}, {225,00}, {250,00}, {275,00},
            {00,25}, {150,25}, {275,25},
            {00,50}, {50,50}, {75,50}, {100,50}, {150,150}, {200,150}, {275,50},
            {00,50}, {50,50}, {75,50}, {100,50}, {150,50}, {200,50}, {275,50}, {00,75}, {100,75}, {150,75}, {200,75}, {275,75},
            {00,100}, {25,100}, {50,100}, {100,100}, {125,100}, {150,100}, {200,100}, {250,100}, {275,100}, 
            {00,125}, {200,125}, {225,125}, 
            {00,150}, {75,150}, {100,150}, {125,150}, {175,150}, {275,150}, 
            {00,175}, {50,175}, {125,175}, {175,175}, {225,175}, {275,175}, 
            {00,200}, {50,200}, {75,200}, {125,200}, {175,200}, {225,200}, {2750,200},
            {00,225}, {100,225}, {125,225}, {225,225}, {275,225},
            {00,250}, {25,250}, {50,250}, {75,250}, {100,250}, {125,225}, {125,250}, {150,250}, {175,250}, {200,250}, {225,250}, {250,250}, {275,250}};











           
            currentBlock = new Rectangle(0, 0, 35, 700);
            currentBlock1 = new Rectangle(84, 97, 716, 25);
            currentBlock2 = new Rectangle(84, 0, 35, 75);
            currentBlock3 = new Rectangle(84, 0, 35, 75);
            currentBlock4 = new Rectangle(775, 0, 35, 428);
            currentBlock5 = new Rectangle(35, 455, 765, 25);
            currentBlock6 = new Rectangle(85, 103, 110, 22);
            currentBlock7 = new Rectangle(170, 50, 25, 70);
            currentBlock8 = new Rectangle(170, 50, 125, 25);
            currentBlock9 = new Rectangle(85, 103, 35, 75);
            currentBlock10 = new Rectangle(85, 152, 200, 25);
            currentBlock11 = new Rectangle(260, 100, 25, 75);
            currentBlock12 = new Rectangle(260, 100, 365, 22);
            currentBlock13 = new Rectangle(350, 52, 25, 55);
            currentBlock14 = new Rectangle(425, 52, 350, 25);
            currentBlock15 = new Rectangle(35, 205, 90, 20);
            currentBlock16 = new Rectangle(35, 255, 90, 20);
            currentBlock17 = new Rectangle(35, 355, 175, 20);
            currentBlock18 = new Rectangle(85, 305, 255, 20);
            currentBlock19 = new Rectangle(85, 408, 125, 20);
            currentBlock20 = new Rectangle(185, 375, 25, 40);
            currentBlock21 = new Rectangle(175, 175, 25, 135);    
            currentBlock22 = new Rectangle(255, 202, 25, 75);
            currentBlock23 = new Rectangle(255, 355, 25, 100);
            currentBlock24 = new Rectangle(255, 200, 200, 25);
            currentBlock25 = new Rectangle(430, 215, 25, 165);
            currentBlock26 = new Rectangle(340, 260, 25, 165);
            currentBlock27 = new Rectangle(450, 305, 325, 20);
            currentBlock28 = new Rectangle(600, 120, 25, 155);
            currentBlock29 = new Rectangle(335, 155, 180, 20);
            currentBlock30 = new Rectangle(515, 155, 20, 150);
            currentBlock31 = new Rectangle(340, 405, 200, 25);
            currentBlock32 = new Rectangle(515, 355, 25, 50);
            currentBlock33 = new Rectangle(540, 355, 140, 25);
            currentBlock34 = new Rectangle(680, 355, 25, 100);
            currentBlock35 = new Rectangle(595, 405, 25, 50);
            currentBlock36 = new Rectangle(685, 100, 25, 75);
            currentBlock37 = new Rectangle(625, 150, 65, 25);
            currentBlock38 = new Rectangle(685, 210, 25, 100);

            currentJimmy = new Rectangle(35, 0, 25, 25);


            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            spriteBatch.Begin();
          
            spriteBatch.Draw(squareBlock, currentBlock, Color.White);
            spriteBatch.Draw(squareBlock, currentBlock1, Color.White);
            spriteBatch.Draw(squareBlock, currentBlock2, Color.White);
            spriteBatch.Draw(squareBlock, currentBlock3, Color.White); 
            spriteBatch.Draw(squareBlock, currentBlock4, Color.White);
            spriteBatch.Draw(squareBlock, currentBlock5, Color.White);
            spriteBatch.Draw(squareBlock, currentBlock6, Color.White);
            spriteBatch.Draw(squareBlock, currentBlock7, Color.White);
            spriteBatch.Draw(squareBlock, currentBlock8, Color.White);
            spriteBatch.Draw(squareBlock, currentBlock9, Color.White);
            spriteBatch.Draw(squareBlock, currentBlock10, Color.White);
            spriteBatch.Draw(squareBlock, currentBlock11, Color.White);
            spriteBatch.Draw(squareBlock, currentBlock12, Color.White);
            spriteBatch.Draw(squareBlock, currentBlock13, Color.White);
            spriteBatch.Draw(squareBlock, currentBlock14, Color.White);
            spriteBatch.Draw(squareBlock, currentBlock15, Color.White);
            spriteBatch.Draw(squareBlock, currentBlock16, Color.White);
            spriteBatch.Draw(squareBlock, currentBlock17, Color.White);
            spriteBatch.Draw(squareBlock, currentBlock18, Color.White);
            spriteBatch.Draw(squareBlock, currentBlock19, Color.White);
            spriteBatch.Draw(squareBlock, currentBlock20, Color.White);
            spriteBatch.Draw(squareBlock, currentBlock21, Color.White);
            spriteBatch.Draw(squareBlock, currentBlock22, Color.White);
            spriteBatch.Draw(squareBlock, currentBlock23, Color.White);
            spriteBatch.Draw(squareBlock, currentBlock24, Color.White);
            spriteBatch.Draw(squareBlock, currentBlock25, Color.White);
            spriteBatch.Draw(squareBlock, currentBlock26, Color.White);
            spriteBatch.Draw(squareBlock, currentBlock27, Color.White);
            spriteBatch.Draw(squareBlock, currentBlock28, Color.White);
            spriteBatch.Draw(squareBlock, currentBlock29, Color.White);
            spriteBatch.Draw(squareBlock, currentBlock30, Color.White);
            spriteBatch.Draw(squareBlock, currentBlock31, Color.White);
            spriteBatch.Draw(squareBlock, currentBlock32, Color.White);
            spriteBatch.Draw(squareBlock, currentBlock33, Color.White);
            spriteBatch.Draw(squareBlock, currentBlock34, Color.White);
            spriteBatch.Draw(squareBlock, currentBlock35, Color.White);
            spriteBatch.Draw(squareBlock, currentBlock36, Color.White);
            spriteBatch.Draw(squareBlock, currentBlock37, Color.White);
            spriteBatch.Draw(squareBlock, currentBlock38, Color.White);
            spriteBatch.Draw(squareJimmy, currentJimmy, Color.White);
            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
