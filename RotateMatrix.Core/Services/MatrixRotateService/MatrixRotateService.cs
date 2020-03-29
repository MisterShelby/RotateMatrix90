using System;

namespace RotateMatrix.Core.Services
{
	public class MatrixRotateService : IMatrixRotateService
	{
		public void RotateMatrix(int[,] inputMatrix)
		{
			if (inputMatrix == null)
			{
				throw new ArgumentException(nameof(inputMatrix));
			}

			int matrixSize = inputMatrix.GetLength(0);

			if (matrixSize == 0)
			{
				throw new ArgumentException(nameof(matrixSize));
			}

			for (int i = 0; i < matrixSize/2; i++)
			{
				for (int j = i; j < matrixSize - i - 1; j++)
				{
					int tempValue = inputMatrix[i, j];

					inputMatrix[i, j] = inputMatrix[matrixSize - 1 - j, i];

					inputMatrix[matrixSize - 1 - j, i] = inputMatrix[matrixSize - 1 - i, matrixSize - 1 - j];

					inputMatrix[matrixSize - 1 - i, matrixSize - 1 - j] = inputMatrix[j, matrixSize - 1 - i];

					inputMatrix[j, matrixSize - 1 - i] = tempValue;
				}
			}
		}
	}
}
