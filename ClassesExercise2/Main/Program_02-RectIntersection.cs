/*
 * Rechteck Definition
 * -------------------
 * Um eine Überschneidung zwischen 2 Rechtecken berechnen zu können
 * muss die Rechteck Definition um die X und Y Position erweitert werden.
 * 
 */

double rect1_PosX = 4;
double rect1_PosY = 8;
double rect1_Width = 10;
double rect1_Height = 20;

double rect2_PosX = 6;
double rect2_PosY = 10;
double rect2_Width = 12;
double rect2_Height = 22;

double rect3_PosX = 8;
double rect3_PosY = 12;
double rect3_Width = 14;
double rect3_Height = 24;

// -----------------------------------------------
// Rechteck Flächenberechnung
// -----------------------------------------------

double rect1_area = rect1_Width * rect1_Height;
double rect2_area = rect2_Width * rect2_Height;
double rect3_area = rect3_Width * rect3_Height;

Console.WriteLine("Rect1 Area: {0}", rect1_area);
Console.WriteLine("Rect2 Area: {0}", rect2_area);
Console.WriteLine("Rect3 Area: {0}", rect3_area);


// -----------------------------------------------
// Rechteck Überschneidungsflächenberechnung
// -----------------------------------------------


// Überschneidung von rect1 und rect2
//------------------------------------

double left_r1_r2 = Math.Max(rect1_PosX, rect2_PosX);
double right_r1_r2 = Math.Min(rect1_PosX + rect1_Width, rect2_PosX + rect2_Width);
double bottom_r1_r2 = Math.Max(rect1_PosY, rect2_PosY);
double top_r1_r2 = Math.Min(rect1_PosY + rect1_Height, rect2_PosY + rect2_Height);

bool hasIntersection_r1_r2 = left_r1_r2 < right_r1_r2 && bottom_r1_r2 < top_r1_r2;


double intersectionArea_r1_r2;
if (hasIntersection_r1_r2 == false)
{
    intersectionArea_r1_r2 = 0;
}
else
{
    double intersectionWidth = right_r1_r2 - left_r1_r2;
    double intersectionHeight = top_r1_r2 - bottom_r1_r2;

    intersectionArea_r1_r2 = intersectionWidth * intersectionHeight;
}

// Überschneidung von rect1 und rect3
//------------------------------------

double left_r1_r3 = Math.Max(rect1_PosX, rect3_PosX);
double right_r1_r3 = Math.Min(rect1_PosX + rect1_Width, rect3_PosX + rect3_Width);
double bottom_r1_r3 = Math.Max(rect1_PosY, rect3_PosY);
double top_r1_r3 = Math.Min(rect1_PosY + rect1_Height, rect3_PosY + rect3_Height);

bool hasIntersection_r1_r3 = left_r1_r3 < right_r1_r3 && bottom_r1_r3 < top_r1_r3;


double intersectionArea_r1_r3;
if (hasIntersection_r1_r3 == false)
{
    intersectionArea_r1_r3 = 0;
}
else
{
    double intersectionWidth = right_r1_r3 - left_r1_r3;
    double intersectionHeight = top_r1_r3 - bottom_r1_r3;

    intersectionArea_r1_r3 = intersectionWidth * intersectionHeight;
}

// Überschneidung von rect2 und rect3
//------------------------------------

double left_r2_r3 = Math.Max(rect2_PosX, rect3_PosX);
double right_r2_r3 = Math.Min(rect2_PosX + rect2_Width, rect3_PosX + rect3_Width);
double bottom_r2_r3 = Math.Max(rect2_PosY, rect3_PosY);
double top_r2_r3 = Math.Min(rect2_PosY + rect2_Height, rect3_PosY + rect3_Height);

bool hasIntersection_r2_r3 = left_r2_r3 < right_r2_r3 && bottom_r2_r3 < top_r2_r3;


double intersectionArea_r2_r3;
if (hasIntersection_r2_r3 == false)
{
    intersectionArea_r2_r3 = 0;
}
else
{
    double intersectionWidth = right_r2_r3 - left_r2_r3;
    double intersectionHeight = top_r2_r3 - bottom_r2_r3;

    intersectionArea_r2_r3 = intersectionWidth * intersectionHeight;
}

// ------------------------------------------------------------------------------------

Console.WriteLine("Intersection Area of rect1 and rect2: {0}", intersectionArea_r1_r2);
Console.WriteLine("Intersection Area of rect1 and rect3: {0}", intersectionArea_r1_r3);
Console.WriteLine("Intersection Area of rect2 and rect3: {0}", intersectionArea_r2_r3);


/*
 * Der Code funktioniert korrekt. Jedoch haben wir viel Code duppliziert. Das ist nicht
 * nur fehleranfällig, sondern auch schlecht lesbar. Zusäztlich können wir die
 * implementierten Funktionalitäten nicht so einfach wiederverwenden ohne wieder Code
 * zu kopieren.
 * 
 * Was können wir tun, was können wir besser machen?
 */