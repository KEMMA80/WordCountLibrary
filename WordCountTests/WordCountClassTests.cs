using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WordCountLibrary;

namespace WordCountTests
{
    [TestClass]
    public class WordCountClassTests
    {
        WordCountClass obj = new WordCountClass();
        /// <summary>
        /// тест на пустое слово, возврат - исключение
        /// </summary>
        [TestMethod]
        public void WordCount_EmptyWord_ReturnException()
        {
            //Arrange
            string entryString = "";
            string entryWord = "";
            //Act     
            //Assert
            Assert.ThrowsException<Exception>(() => obj.WordCount(entryString, entryWord));
        }    

        /// <summary>
        /// тест на неверную строку, возврат - исключение
        /// </summary>
        [TestMethod]
        public void WordCount_WrongString_ReturnException()
        {
            string entryString = "лягушка??7";
            string entryWord = "нет";
            Assert.ThrowsException<Exception>(() => obj.WordCount(entryString, entryWord));

        }

        /// <summary>
        /// тест на неверное слово, возврат - исключение
        /// </summary>
        [TestMethod]
        public void WordCount_WrongWord_ReturnException()
        {
            string entryString = "";
            string entryWord = "да?!";
            Assert.ThrowsException<Exception>(() => obj.WordCount(entryString, entryWord));

        }

        /// <summary>
        /// тест на количество слов в строке, возвращаемый результат - 1
        /// </summary>
        [TestMethod]
        public void WordCount_OneWordCountString_ReturnOne()
        {
            string entryString = "это лягушка";
            string entryWord = "лягушка";
            int countExpect = 1;
            int countActual = obj.WordCount(entryString, entryWord);
            Assert.AreEqual(countExpect, countActual);
        }

        /// <summary>
        /// тест на количество слов в строке, возвращаемый результат - 2
        /// </summary>
        [TestMethod]
        public void WordCount_OneWordCountString_ReturnTwo()
        {
            string entryString = "лягушка артем и лягушка арсений";
            string entryWord = "лягушка";
            int countExpect = 2;
            int countActual = obj.WordCount(entryString, entryWord);
            Assert.AreEqual(countExpect, countActual);
        }

        /// <summary>
        /// тест на количество слов в строке, возвращаемый результат - 4
        /// </summary>
        [TestMethod]
        public void WordCount_OneWordCountString_ReturnFour()
        {
            string entryString = "пустыня осталась пустыня осталась пустыня пустыня";
            string entryWord = "пустыня";
            int countExpect = 4;
            int countActual = obj.WordCount(entryString, entryWord);
            Assert.AreEqual(countExpect, countActual);
        }
        /// <summary>
        /// тест на количество слов в строке, возвращаемый результат - 0
        /// </summary>
        [TestMethod]
        public void WordCount_ZeroWordCountString_ReturnZero()
        {
            string entryString = "лягушка в пустыне";
            string entryWord = "нет";
            int countExpect = 0;
            int actualCount = obj.WordCount(entryString, entryWord);
            Assert.AreEqual(countExpect, actualCount);

        }
    }
}
