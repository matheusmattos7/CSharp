namespace EditorHtml
{
    public static class DrawScreen
    {
        public static void Draw(int rowsLength, int columnsLength)
        {
            DrawRows(rowsLength);
            DrawColumns(columnsLength, rowsLength);
            DrawRows(rowsLength);
        }

        public static void DrawRows(int rowsLength)
        {   
            Console.Write("+");
            for (int i = 0; i <= rowsLength; i++)
                Console.Write("-");

            Console.Write("+");
            Console.Write("\n");
        }

        public static void DrawColumns(int columnsLength, int rowsLength)
        {
            for (int lines = 0; lines <= columnsLength; lines++)
            {
                Console.Write("|");
                for (int i = 0; i <= rowsLength; i++)
                    Console.Write(" ");

                Console.Write("|");
                Console.Write("\n");
            }
        }
    }
}