﻿// Проект закрашивание руки
 int[,] image = new int[15,15];
void PrintImage(int[,]image)
{
    for(int i = 0;i < image.GetLength(0);i++)
    {
        for(int j = 0;j < image.GetLength(1);j++)
    {
        if(image[i,j] == 0)Console.Write($" + ");
        else Console.Write($"+");
    }
    Console.WriteLine();
    }
}
// void FillImage(int row,int col)
// {
    // if(Pic[ row, col] ==0)
    // {
        // Predicate[row,col] =1;
        // FillImage["row-1;col"];
        // FillImage["row;col-1"];
        // FillImage["row+1;col"];
        // FillImage["row;col+1"];
//  }
// }
PrintImage(image);
// FillImage(13,13);
// PrintImage(pic);