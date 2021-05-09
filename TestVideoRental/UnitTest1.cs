using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;
using VideoRentalSystem.BusinessClass;
namespace TestVideoRental
{
    [TestClass]
    public class UnitTest1
    {
        Data myData = new Data();
        //Tests connection by ensuring the GetTable method returns a valid Datatable
        [TestMethod]
        public void TestConnection()
        {

            DataTable dt = null;

            try
            {
                dt = myData.GetTable("*", "RentalsFriendly");
            }
            catch (Exception e)
            {
                throw e;
            }

            Assert.IsNotNull(dt);
        }

        //Tests GetMovie method by ensuring that it returns valid JSOn that can be deserialized to a Movie object.
        [TestMethod]
        public void TestGetMovie()
        {
            var myData = new Data();
            Movie myMovie = null;

            try
            {
                myMovie = myData.GetJson("The Revenant");
            }
            catch (Exception)
            {
            }

            Assert.IsNotNull(myMovie);
        }
    }
}
