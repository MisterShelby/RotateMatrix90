using RotateMatrix.Core.Services;
using System;
using Xunit;

namespace RotateMatrix.Tests.Services
{
	public class MatrixRotateServiceTests
	{
		private readonly IMatrixRotateService _matrixService;
		public MatrixRotateServiceTests()
		{
			_matrixService = new MatrixRotateService();
		}
		[Fact]
		public void MatrixService_Should_Throw_Argument_Exception_If_InputMatrix_Is_Null()
		{
			Assert.Throws<ArgumentException>(() => _matrixService.RotateMatrix(3, null));

			Assert.Equal(0, 3);
		}
	}
}
