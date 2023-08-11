#include <iostream>
#include "raylib.h"
#include "prefs.h"

using namespace std;

int officeScroll = -400;
int officeScrollSpeed = 0;
int officeFrame = 0;


int main(void)
{
    InitWindow(screenWidth, screenHeight, TextFormat("%s", gameName.c_str()));
    SetWindowState(FLAG_VSYNC_HINT);
    InitAudioDevice();

    /*ASSETS*/
    //Textures
    Texture2D sprOfficeF1 = LoadTexture("./assets/39.png");
    
    //Images
    Image gameIcon = LoadImage("./assets/icon.png");
    
    //Sounds
    Sound sndHonk = LoadSound("./assets/honk.wav");

    /*BOUNDS*/
    Rectangle honkButtonBounds = { 671+(float)officeScroll, 235, 14, 8 }; //The Honk

    SetWindowIcon(gameIcon);
    while (!WindowShouldClose())
    {
        BeginDrawing();
        ClearBackground(RAYWHITE);
        
        /*OFFICE*/
        //office scroll
        officeScrollSpeed=(GetMouseX()-screenWidth/2)/(screenWidth/15);
        officeScroll-=officeScrollSpeed;
        if (officeScroll>0){
            officeScroll=0;
        }
        if (officeScroll<-320){
            officeScroll=-320;
        }
        DrawTexture(sprOfficeF1, officeScroll, 0, RAYWHITE);  
        DrawText(TextFormat("%i; %i", officeScrollSpeed, officeScroll),0,32,32,GREEN); //For debuging
        DrawText("IT'S ME",0,64,32,GREEN);
        //the honk
        honkButtonBounds = { 671+(float)officeScroll, 235, 14, 8 };
        if (CheckCollisionPointRec(GetMousePosition(), honkButtonBounds))
        {
            if (IsMouseButtonPressed(MOUSE_BUTTON_LEFT)) {
                PlaySound(sndHonk);
            } 
        }
        //DrawRectangle(671+(float)officeScroll, 235, 14, 8, RED); //For debuging
        
        DrawFPS(0,0); //For debuging
        EndDrawing();
    }

    UnloadTexture(sprOfficeF1);
    UnloadSound(sndHonk);

    CloseWindow();
    return 0;
}