//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using fmc;
//using System;
//using System.Collections.Generic;
//using System.Text;
//using spatial;
//using flightmanagementcomputer;

//namespace fmc.Tests
//{
//    [TestClass()]
//    public class FMCTests
//    {
//        private FMC fmc = new FMC();
//        static private DateTime TIMESECS = DateTime.Now;
//        static private double SPEED = 100.0d;
//        static private double HEADING = 90.0d;
//        private VVector v1 = new VVector(SPEED, HEADING, TIMESECS);

    //    [TestMethod()]
    //    public void p2pSimpleTest()
    //    {
    //        double lenNM = 100d;
    //        double lengthNM = 600d / 3600d * 600d;
    //        //Assert.AreEqual(lenNM, lengthNM);
            
    //        //Assert.IsTrue(1 == 1);
            
    //    }

    //    [TestMethod()]
    //    public void Dnm2r_100Test()
    //    {
    //        double lengthNM = 100d;
    //        Assert.IsTrue(fmc.Dnm2r(100d) == 0.02908882086657216);
    //    }

    //    [TestMethod()]
    //    public void Ad2r_66Test()
    //    {
    //        Assert.IsTrue(fmc.Ad2r(66d) == 1.1519173063162575);
    //    }

    //    [TestMethod()]
    //    public void Ad2r_90Test()
    //    {
    //        Assert.IsTrue(fmc.Ad2r(90d) == 1.5707963267948966);
    //    }
    //    [TestMethod()]
    //    public void Ad2r_180Test()
    //    {
    //        Assert.IsTrue(fmc.Ad2r(180d) == 3.141592653589793);
    //    }
    //    [TestMethod()]
    //    public void Ad2r_270Test()
    //    {
    //        Assert.IsTrue(fmc.Ad2r(270d) == 4.71238898038469);
    //    }
    //    [TestMethod()]
    //    public void Ad2r_360Test()
    //    {
    //        Assert.IsTrue(fmc.Ad2r(360d) == 6.283185307179586);
    //    }

    //    [TestMethod()]
    //    public void latitudeCalc1()
    //    {
    //        //XXnewlat: 0.7754439688969073
    //        //XXlat1_radians: 0.7463551480303351 dis: 0.02908882086657216 tc: 6.283185307179586
    //        double lat1_radians = 0.7463551480303351;
    //        double distance_radians = 0.02908882086657216;
    //        double truecourse_radians = 6.283185307179586;
    //        double newlat = Math.Asin(
    //              Math.Sin(lat1_radians)
    //            * Math.Cos(distance_radians)
    //            + Math.Cos(lat1_radians)
    //            * Math.Sin(distance_radians)
    //            * Math.Cos(truecourse_radians)
    //            );
    //        Assert.IsTrue(newlat == 0.7754439688969073);
    //    }

    //    [TestMethod("Calculate Latitude")]
    //    public void latitude_givenTest()
    //    {
    //        double latgiven = Math.Asin(
    //              Math.Sin(0.592539) 
    //            * Math.Cos(0.0290888)
    //            + Math.Cos(0.592539) 
    //            * Math.Sin(0.0290888) 
    //            * Math.Cos(1.150035)
    //            );
    //        //Assert.IsTrue(latgiven == 0.604180158011369);
    //        Assert.IsTrue(latgiven == 0.6041798689300695);


    //    }

    //    [TestMethod()]
    //    public void latitudeInnerTest()
    //    {

    //        double A = Math.Sin(0.592539) * Math.Cos(0.0290888)
    //                     + Math.Cos(0.592539) * Math.Sin(0.0290888)
    //                     * Math.Cos(1.150035);
    //        Assert.IsTrue(A == 0.5680873255302352);
            
    //    }

    //    [TestMethod()]
    //    public void longitudePart1Test()
    //    {
    //        Assert.IsTrue(
    //        2.066470
    //        - Math.Asin(
    //            Math.Sin(1.150035)
    //          * Math.Sin(0.0290888)
    //          / Math.Cos(0.604180)
    //          ) == 2.0342057088546213);
    //        //2.0342055165495094
    //        // docs say 2.034206
    //    }

    //    [TestMethod()]
    //    public void longitudePart2Test()
    //    {
    //        Assert.IsTrue(
    //        fmc.mod(2.066470
    //        - Math.Asin(
    //            Math.Sin(1.150035)
    //          * Math.Sin(0.0290888)
    //          / Math.Cos(0.604180)
    //          ) + Math.PI, 2 * Math.PI) - Math.PI == 2.0342057088546213);
    //    }

    //    [TestMethod()]
    //    public void mod_minus_test()
    //    {
    //        Assert.IsTrue(fmc.mod(1, -2) < 0);
    //    }
    //    [TestMethod()]
    //    public void mod_pos_test()
    //    {
    //        Assert.IsTrue(fmc.mod(1, 2) >= 0);
    //    }
    //    [TestMethod()]
    //    public void mod_minus_test2()
    //    {
    //        Assert.IsTrue(fmc.mod(-1, -2) < 0);
    //    }
    //    [TestMethod()]
    //    public void mod_pos_test2()
    //    {
    //        Assert.IsTrue(fmc.mod(-1, 2) > 0);
    //    }


    //    /*
    //    XXmod(-1,2) :1
    //    XXmod(1,2) :1
    //    XXmod(1,-2) :-1
    //    XXmod(-1,-2) :-1
    //    XXmod(-.0001,-2) :-0.0001
    //    XXmod(-.0001,2) :1.9999
    //    XXmod(.0001,-2) :-1.9999
    //    XXmod(.0001,2) :0.0001
    //    */
    //}
//}