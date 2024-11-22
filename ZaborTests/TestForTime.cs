using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ArtLib;
using System.Collections.Generic;
using System.IO;
namespace ZaborTests
{
    [TestClass]
    public class TestForTime
    {
        //Тест для одного параметра
        [TestMethod]
        public void TestWithOneParam1()
        {
            var result = Calculate.Calcl(new List<int> { 2 });
            Assert.AreEqual(2, result);
        }
        //Тест для двух параметров
        [TestMethod]
        public void TestWithTwoParam2()
        {
            var result = Calculate.Calcl(new List<int> { 2, 17 });
            Assert.AreEqual(19, result);
        }
        //Тест для трех параметров
        [TestMethod]
        public void TestWithThreeParam3()
        {
            var result = Calculate.Calcl(new List<int> { 2, 1, 10 });
            Assert.AreEqual(12, result);
        }
        //Тест для 4-х параметров 
        [TestMethod]
        public void TestWithFourParam4()
        {
            var result = Calculate.Calcl(new List<int> { 5, 10, 15, 20 });
            Assert.AreEqual(40, result);
        }
        //Тест для 5-ти параметров
        [TestMethod]
        public void TestWithFiveParam5()
        {
            var result = Calculate.Calcl(new List<int> { 5, 10, 15, 20, 2 });
            Assert.AreEqual(42, result);
        }
        //Тест без параметров
        [TestMethod]
        public void TestWithNoParam6()
        {
            var result = Calculate.Calcl(new List<int>());
            Assert.AreEqual(0, result);
        }
        //Тест для больших параметров
        [TestMethod]
        public void TestWithLargeParam7()
        {
            var result = Calculate.Calcl(new List<int> { 1000, 2000, 3000 });
            Assert.AreEqual(4000, result);
        }
        //Тест для одного большого параметра
        [TestMethod]
        public void TestWithOneleLargeParam8()
        {
            var result = Calculate.Calcl(new List<int> { 1000 });
            Assert.AreEqual(1000, result);
        }
        //Тест на большие и короткие положительные параметры
        [TestMethod]
        public void TestWithLargeAndShortPositive9()
        {
            var result = Calculate.Calcl(new List<int> { 1000, 2, 3000 });
            Assert.AreEqual(4000, result);
        }
        //Тест на нули
        [TestMethod]
        public void TestWithZeroesParam10()
        {
            var result = Calculate.Calcl(new List<int> { 0, 0, 0, 0 });
            Assert.AreEqual(0, result);
        }
        //Тест на положительное и отрицательное значение
        [TestMethod]
        public void TestWithNegativeAndPositiveParam11()
        {
            Assert.ThrowsException<Exception>(() => Calculate.Calcl(new List<int> { 1, 2, -3, 4, 5 }));
        }
        //Тест на одно отрицательное значение
        [TestMethod]
        public void TestWithNegativeParam12()
        {
            Assert.ThrowsException<Exception>(() => Calculate.Calcl(new List<int> { -2, -3 }));
        }
        //Тест на одинаковые значения
        [TestMethod]
        public void TestWithSame13()
        {
            var result = Calculate.Calcl(new List<int> { 2, 2, 2 });
            Assert.AreEqual(4, result);
        }
        //Тест на значение нуль
        [TestMethod]
        public void TestWithOneZero14()
        {
            var result = Calculate.Calcl(new List<int> { 1, 0, 2 });
            Assert.AreEqual(3, result);
        }
        //Тест при больших отрицательных значениях
        [TestMethod]
        public void TestWithLargeNegative15()
        {

            Assert.ThrowsException<Exception>(() => Calculate.Calcl(new List<int> { -1000 }));
        }
        //Тест на отрицательные значения и нули
        [TestMethod]
        public void TestWithNegativeAndZero16()
        {
            Assert.ThrowsException<Exception>(() => Calculate.Calcl(new List<int> { -2, -3, 0 }));
        }
        //Тест на нули и положительные значения
        [TestMethod]
        public void TestWithPositiveAndZero17()
        {

            var result = Calculate.Calcl(new List<int> { 1, 0, 2, 0, 1 });
            Assert.AreEqual(4, result);
        }
        //Тест на положительные/отрицательные значения и нули
        [TestMethod]
        public void TestWithPositiveNegativeZero18()
        {
            Assert.ThrowsException<Exception>(() => Calculate.Calcl(new List<int> { -2, -3, 0, 1, 2 }));
        }
        //Тест на большое кол-во значений
        [TestMethod]
        public void TestWithManyParameters19()
        {
            var result = Calculate.Calcl(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
            Assert.AreEqual(40, result);
        }
        [TestInitialize]
        public void Setup()
        {
            string dir = @"C:\Users\Professional\Desktop\v4\Zabor\bin\Debug";
            Directory.SetCurrentDirectory(dir);
        }
        //Тест на проверку существования
        [TestMethod]
        public void TestFileExists20()
        {
            string file = "input.txt";
            string directory = Directory.GetCurrentDirectory();
            string filePath = Path.Combine(directory, file);
            bool exists = File.Exists(filePath);
            Assert.IsTrue(exists, "Файл не существует");
          
        }
        //Тест на пустоту файла
        [TestMethod]
        public void TestFileNoEmpty21()
        {
            string file = "input.txt";
            string directory = Directory.GetCurrentDirectory();
            string filePath = Path.Combine(directory, file);
            // Проверяем, что файл не пустой
            long fileSize = new FileInfo(filePath).Length;
            Assert.IsTrue(fileSize > 0, "Файл пустой");
        }
    }

}
