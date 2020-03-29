using RotateMatrix.Core.Services;
using System;
using System.Collections.Generic;
using Xunit;

namespace RotateMatrix90.Tests.Services
{
	public class MatrixRotateServiceTests
	{
		[Fact]
		public void Should_Throw_Exception_If_InputMatrix_Is_Null()
		{
			//arrange
			var matrixService = new MatrixRotateService();

			//assert
			Assert.Throws<ArgumentException>(() => matrixService.RotateMatrix(null));
		}


		[Theory]
		[MemberData(nameof(TestData))]
		public void Should_Rotate_MAtrix_By_90_Angle_ClockWise(int[,] inputMatrix, int[,] exceptedMatrix)
		{
			//arrange 
			var matrixService = new MatrixRotateService();
			//act
			matrixService.RotateMatrix(inputMatrix);
			//assert
			Assert.Equal(exceptedMatrix, inputMatrix);
		}

		public static IEnumerable<object[]> TestData
		{
			get
			{
				return new List<object[]>
				{
					new object[] { new int[,] {{ 25, 38, 12}, { 1, 7, 76}, { 21, 64, 54} }, new int[,]{ { 21, 1, 25 }, { 64, 7, 38 }, { 54, 76, 12 }, }},
					new object[] { new int[,] {{1,2 },{4,5} }, new int[,] {{4,1 },{5,2} } }
				};
			}
		}
	}
}
