using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClasses.FileProcess;
using System;
using System.Configuration;
using System.IO;

namespace MyClassesTests
{
    [TestClass]
    public class FileProcessTest
    {
        private const string BAD_FILE_NAME = @"C:\BadFileName.bat";
        private string _GoodFileName = @"C:\Users\Dougl\OneDrive\Documentos\Estudo\UnitTest\FileTest\testFile.txt";

        public TestContext TestContext { get; set; }

        [TestMethod]
        [Description("Verificar se um arquivo existe")]
        [Owner("Douglas")]
        [Priority(1)]
        [TestCategory("NoException")]
        public void FileNameDoesExists()
        {
            //Tecnica AAA

            //Arange --> Instancia classes e variaveis necessarias para rodar o teste
            FileProcess fileProcess = new FileProcess();
            bool fromCall;

            //Action --> Realiza a ação de teste
            TestContext.WriteLine($"Creating file: {_GoodFileName}");
            File.AppendAllText(_GoodFileName, "Some Text");

            TestContext.WriteLine($"Testing file: {_GoodFileName}");
            fromCall = fileProcess.FileExists(_GoodFileName);

            TestContext.WriteLine($"Deleting file: {_GoodFileName}");
            File.Delete(_GoodFileName);

            //Assert --> Verifica a ação
            Assert.IsTrue(fromCall);
        }

        [TestMethod]
        [Description("Verificar se um arquivo não existe")]
        [Owner("Douglas")]
        [Priority(1)]
        [TestCategory("NoException")]
        public void FileNameDoesNotExists()
        {
            //Tecnica AAA
            //Arange --> Instância classes e variaveis necessarias para rodar o teste
            FileProcess fileProcess = new FileProcess();
            bool fromCall;

            //Action --> Realiza a ação de teste
            fromCall = fileProcess.FileExists(BAD_FILE_NAME);

            //Assert --> Verifica a ação
            Assert.IsFalse(fromCall);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        [Description("Verificar se um arquivo é vazio ou nulo")]
        [Owner("Douglas")]
        [Priority(0)]
        [TestCategory("Exception")]
        public void FileNameNullOrEmpty_ThrowsArgumentNullException()
        {
            //Exception Handling
            FileProcess fileProcess = new FileProcess();

            fileProcess.FileExists("");
        }

        [TestMethod]
        [Owner("Douglas")]
        [Description("Verificar se um arquivo é vazio ou nulo usando try catch")]
        [Priority(0)]
        [TestCategory("Exception")]
        public void FileNameNullOrEmpty_ThrowsArgumentNullException_UsingTryCatch()
        {
            //Arange
            FileProcess fileProcess = new FileProcess();

            try
            {
                //Action
                fileProcess.FileExists("");
            }
            catch (ArgumentException)
            {
                //Isso foi um sucesso
                return;
            }

            //Assert
            Assert.Fail("Fail expected");
        }


    }
}
