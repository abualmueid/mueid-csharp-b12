int[] ages = new int[5];
ages[0] = 10;

Console.WriteLine(ages[0]);

DateTime dateTime = DateTime.Now;
Console.WriteLine(dateTime);
DateTime dateTime2 = DateTime.MinValue;
Console.WriteLine(dateTime2);

// Multi-Dimensional Array // It's not array of array

int[,] matrix = new int[5, 5];
matrix[0, 0] = 10;
Console.WriteLine(matrix[0, 0]);

int[,,] cube = new int[2, 3, 5];
cube[1, 2, 4] = 20;
Console.WriteLine(cube[1, 2, 4]);

// Jagged Array // It's array of array

// 2D Array
int[][] matrix2 = new int[3][];
matrix2[0] = new int[5];
matrix2[1] = new int[3];
matrix2[2] = new int[4];

// 3D Array
int[][][] matrix3 = new int[3][][];
matrix3[0] = new int[3][];
matrix3[1] = new int[3][];
matrix3[2] = new int[3][];

matrix3[0][0] = new int[3];
matrix3[0][1] = new int[3];
matrix3[1][0] = new int[3];
matrix3[1][1] = new int[3];

// 4D Array
int[][][][] matrix4 = new int[3][][][];
matrix4[0] = new int[3][][];
matrix4[1] = new int[3][][];
matrix4[2] = new int[3][][];

matrix4[0][0] = new int[3][];
matrix4[0][1] = new int[3][];
matrix4[0][2] = new int[3][];
matrix4[1][0] = new int[3][];
matrix4[1][1] = new int[3][];
matrix4[1][2] = new int[3][];
matrix4[2][0] = new int[3][];
matrix4[2][1] = new int[3][];
matrix4[2][2] = new int[3][];

matrix4[0][0][0] = new int[3];
matrix4[0][0][1] = new int[3];
matrix4[0][0][2] = new int[3];
matrix4[1][1][0] = new int[3];
matrix4[1][1][1] = new int[3];
matrix4[1][1][2] = new int[3];
matrix4[2][2][0] = new int[3];
matrix4[2][2][1] = new int[3];
matrix4[2][2][2] = new int[3];

// 4D Array with Multi-Dimensional Array

int[,,,] Array4D = new int[3, 3, 3, 3];
Array4D[2, 2, 1, 0] = 50;
Console.WriteLine(Array4D[2, 2, 1, 0]);













