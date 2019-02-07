using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab_19_collections;
using System.Collections.Generic;

namespace CollectionsTests
{
    [TestClass]
    public class CollectionsTest
    {
        [TestMethod]
        public void CubicArrayTest()
        {
            // arrange
            var instance01 = new CollectionProject();
            var expected = 42;
            // act
            var actual = instance01.CubicArray();

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ListTest()
        {
            // arrange
            var instance01 = new CollectionProject();
            var expected = 166375;

            // act
            var actual = instance01.List();

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DictionaryTest()
        {
            // arrange
            var instance01 = new CollectionProject();
            var expected = new Dictionary<string, string>();
            var expectedCount = 10;


            // act
            var actual = instance01.DictionaryTest();
            var actualCount = actual.Count;
            // assert
            Assert.AreEqual(expectedCount, actualCount);
            Assert.IsInstanceOfType(actual, expected.GetType());
        }


        [TestMethod]
        public void QueueTest()
        {
            // arrange
            var instance01 = new CollectionProject();
            var expected = 3025;

            // act
            var actual = instance01.QueueTest();

            // assert
            Assert.AreEqual(expected, actual);

        }


        [TestMethod]
        public void StackTest()
        {
            // arrange
            var instance01 = new CollectionProject();
            var expected = 8733475;

            // act
            var actual = instance01.StackTest();

            // assert
            Assert.AreEqual(expected, actual);

        }

    }
}
