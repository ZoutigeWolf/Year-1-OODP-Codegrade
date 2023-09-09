using FactoryPattern;

namespace FactoryPattern.Tests;

[TestClass]
public class FactoryPatternTest
{
    [TestMethod]
    public void CreateLightTheme_Document()
    {
        // Create a new DocumentFactory object and and create a document with a light theme
        Document document = new DocumentFactory().CreateLightTheme();
        
        // Assert that both the document BackGroundColor and FontColor contain the expected values for this theme.
        Assert.AreEqual("White", document.BackGroundColor);
        Assert.AreEqual("Black", document.FontColor);
    }

    [TestMethod]
    public void CreateDarkTheme_Document()
    {
        // Create a new DocumentFactory object and and create a document with a dark theme
        Document document = new DocumentFactory().CreateDarkTheme();
        
        // Assert that both the document BackGroundColor and FontColor contain the expected values for this theme.
        Assert.AreEqual("Black", document.BackGroundColor);
        Assert.AreEqual("White", document.FontColor);
    }

    [TestMethod]
    public void CreateLightTheme_IDE()
    {
        // Create a new IDEFactory object and and create an ide with a light theme
        IDE ide = new IDEFactory().CreateLightTheme();
        
        // Assert that both the document BackGroundColor, FontColor and ButtonColor contain the expected values for this theme.
        Assert.AreEqual("White", ide.BackGroundColor);
        Assert.AreEqual("Black", ide.FontColor);
        Assert.AreEqual("Light blue", ide.ButtonColor);
    }

    [TestMethod]
    public void CreateDarkTheme_IDE()
    {
        // Create a new IDEFactory object and and create an ide with a dark theme
        IDE ide = new IDEFactory().CreateDarkTheme();
        
        // Assert that both the document BackGroundColor, FontColor and ButtonColor contain the expected values for this theme.
        Assert.AreEqual("Black", ide.BackGroundColor);
        Assert.AreEqual("White", ide.FontColor);
        Assert.AreEqual("Light yellow", ide.ButtonColor);
    }
}