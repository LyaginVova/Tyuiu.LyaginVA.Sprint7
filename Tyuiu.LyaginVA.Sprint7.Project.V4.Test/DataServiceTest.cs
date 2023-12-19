using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.LyaginVA.Sprint7.Project.V4.Lib;

namespace Tyuiu.LyaginVA.Sprint7.Project.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromFileData()
        {
            string path = @"C:\Users\vova\source\repos\Tyuiu.LyaginVA.Sprint7\Tyuiu.LyaginVA.Sprint7.Project.V4\bin\Debug\OutPutFileProject.csv";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
