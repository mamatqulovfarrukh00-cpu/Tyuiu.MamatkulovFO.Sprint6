using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.MamatkulovFO.Sprint6.Task7.V3.Lib
{
    public class Dataservice : ISprint6Task7V3
    {
        public int[,] GetMatrix(string path)
        {
            if (!File.Exists(path))
                throw new FileNotFoundException("Файл не найден!", path);

            var lines = File.ReadAllLines(path);
            var rows = lines.Length;
            var cols = lines[0].Split(';').Length;

            var matrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                var values = lines[i].Split(';');
                for (int j = 0; j < cols; j++)
                {
                    if (int.TryParse(values[j], out int number))
                        matrix[i, j] = number;
                }
            }

            // Первый столбец: четные числа заменяем на -1
            for (int i = 0; i < rows; i++)
            {
                if (matrix[i, 0] % 2 == 0) // если четное
                    matrix[i, 0] = -1;
            }

            return matrix;
        }
    }
}
    

