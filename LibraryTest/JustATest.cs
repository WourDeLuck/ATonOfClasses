using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ATonOfClasses;

namespace LibraryTest
{
    [TestClass]
    public class JustATest
    {
        [TestMethod]
        public void CloudDataTesting()
        {
            Cloud c1 = new Cloud(1, "cirrus", 150, "balloon", 15, 12000);
            var test = c1.Size;

            Assert.AreNotEqual(c1.Shape, "cat");
            Assert.IsNotNull(c1.MoveSpeed);
            Assert.ReferenceEquals(test, c1.Size);
            Assert.AreEqual(c1.Type, "cirrus");
            Assert.IsFalse(c1.Height == 0);
        }

        [TestMethod]
        public void LawOfPhysicsDataTesting()
        {
            string someLaw = "An object at rest stays at rest and an object in motion stays in motion";
            LawOfPhysics law = new LawOfPhysics("Newton's Law 1", "Isaac Newton", 1678, someLaw);
            law.Formula.Add("dp/dt = F", 1);
            law.Formula.Add("m*a = F", 2);

            Assert.IsTrue(law.Name.Contains("Newton"));
            Assert.IsFalse(law.DiscoverDate.Equals(2017));
            Assert.IsNotNull(law.Formula);
        }

        [TestMethod]
        public void TrafficLightDataTesting()
        {
            TrafficLight tl1 = new TrafficLight(1, "highway", "Davis Blvd", "LED", "Active");
            tl1.LightsInfo.Add(new TrafficLight.Light { LightColor = "Red", Status = "Active" });

            Assert.AreEqual("Davis Blvd", tl1.Location);
            Assert.IsNotNull(tl1.Id);
            Assert.IsTrue(tl1.LampsType.Equals("LED"));
            Assert.IsFalse(tl1.WorkStatus.Equals("Offline"));
        }
    }
}
