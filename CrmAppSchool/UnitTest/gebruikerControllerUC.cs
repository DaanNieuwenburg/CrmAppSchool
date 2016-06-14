using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CrmAppSchool.Controllers;

namespace UnitTest
{
    [TestClass]
    public class gebruikerControllerUC
    {
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
            gebruikermodel.Gebruikersnaam = "1111";
            gebruikermodel.Wachtwoord = "1111";
            gebruikermodel.SoortGebruiker = "111";
            gc.voegGebruikerToe(gebruikermodel);
        }
    }
}
;