using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CrmAppSchool.Controllers;

namespace UnitTest
{
    [TestClass]
    public class gebruikerControllerUC
    {

        // VoegGebruikerToe
        [TestMethod]
        public void TestVoegGebruikerToeNull()
        { 
            // Probeert een null waarde te inserten
            CrmAppSchool.Controllers.GebruikerController gc = new GebruikerController();
            gc.voegGebruikerToe(null);
        }
        [TestMethod]
        public void TestVoegGebruikerToeMetNietBestaandeGebruikerSoort()
        {
            // Probeert een waarde te inserten die niet in de enum soortgebruiker kan
            CrmAppSchool.Controllers.GebruikerController gc = new GebruikerController();
            CrmAppSchool.Models.Gebruiker gebruikermodel = new CrmAppSchool.Models.Gebruiker();
            gebruikermodel.Gebruikersnaam = "UnitTest69";
            gebruikermodel.Wachtwoord = "unitTest1";
            gebruikermodel.SoortGebruiker = "UnitTest1";
            gc.voegGebruikerToe(gebruikermodel);
        }

        [TestMethod]
        public void TestVoegGebruikerToeMetTeLangeGegevens()
        {
            // Probeert een waarde te inserten met een gebruikersnaam > 25 tekens
            CrmAppSchool.Controllers.GebruikerController gc = new GebruikerController();
            CrmAppSchool.Models.Gebruiker gebruikermodel = new CrmAppSchool.Models.Gebruiker();
            gebruikermodel.Gebruikersnaam = "UnitTestUnitTestUnitTestUnitTestUnitTestUnitTest"; // 48 karakters lang
            gebruikermodel.Wachtwoord = "unitTest2";
            gebruikermodel.SoortGebruiker = "Docent";
            gc.voegGebruikerToe(gebruikermodel);
            Assert.Fail();
        }

        // Verander wachtwoord gebruiker
        [TestMethod]
        public void VeranderWachtwoordNullGebruiker()
        {
            // Probeert een wachtwoord te veranderen waar de gebruiker null is en het wachtwoord ook
            CrmAppSchool.Controllers.GebruikerController gc = new GebruikerController();
            CrmAppSchool.Models.Gebruiker gebruikermodel = new CrmAppSchool.Models.Gebruiker();
            gebruikermodel.Gebruikersnaam = null;
            gebruikermodel.Wachtwoord = null;
            gc.veranderWachtwoordGebruiker(gebruikermodel);
        }
        [TestMethod]
        public void VeranderWachtwoordNietBestaandeGebruiker()
        {
            // Probeert een wachtwoord te veranderen waar de gebruiker niet bestaatis
            CrmAppSchool.Controllers.GebruikerController gc = new GebruikerController();
            CrmAppSchool.Models.Gebruiker gebruikermodel = new CrmAppSchool.Models.Gebruiker();
            gebruikermodel.Gebruikersnaam = "badeend1337<3";
            gc.veranderWachtwoordGebruiker(gebruikermodel);
            Assert.Fail();
        }
    }
}
;