using Infrastructure.Interfaces;
using Infrastructure.Models;
using Moq;

namespace Infrastructure.Tests.Services;

public class FileService_Tests
{
    [Fact]
    public void SaveContentToFile_ShouldReturnTrue_WhenContentSavedToFile()
    {
        // Arrange
        var fileResult = new FileResult { Succeeded = false, Error = "Unable to save content." };

        var fileServiceMock = new Mock<IFileService>();
        var fileService = fileServiceMock.Object;

        fileServiceMock.Setup(fs => fs.SaveContentToFile(It.IsAny<string>(), It.IsAny<string>()))
            .Returns(fileResult);

        // Act
        var result = fileService.SaveContentToFile("", "");

        // Assert
        Assert.True(result.Succeeded);
    }
}
